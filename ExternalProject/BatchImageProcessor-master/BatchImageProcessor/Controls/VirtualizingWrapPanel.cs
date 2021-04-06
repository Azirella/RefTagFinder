﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace BatchImageProcessor.Controls
{
	public class VirtualizingWrapPanel : VirtualizingPanel, IScrollInfo
	{
		#region Properties

		private Size ChildSlotSize => new Size(ItemWidth, ItemHeight);

		#endregion

		#region Fields

		private readonly Dictionary<UIElement, Rect> _realizedChildLayout = new Dictionary<UIElement, Rect>();
		private WrapPanelAbstraction _abstractPanel;
		private Size _childSize;
		private UIElementCollection _children;
		private Size _extent = new Size(0, 0);
		private int _firstIndex;
		private IItemContainerGenerator _generator;
		private ItemsControl _itemsControl;
		private Point _offset = new Point(0, 0);
		private Size _pixelMeasuredViewport = new Size(0, 0);
		private Size _viewport = new Size(0, 0);

		#endregion

		#region Dependency Properties

		public static readonly DependencyProperty ItemHeightProperty = DependencyProperty.Register("ItemHeight",
			typeof (double), typeof (VirtualizingWrapPanel), new FrameworkPropertyMetadata(double.PositiveInfinity));

		public static readonly DependencyProperty ItemWidthProperty = DependencyProperty.Register("ItemWidth",
			typeof (double),
			typeof (VirtualizingWrapPanel), new FrameworkPropertyMetadata(double.PositiveInfinity));

		public static readonly DependencyProperty OrientationProperty =
			StackPanel.OrientationProperty.AddOwner(typeof (VirtualizingWrapPanel),
				new FrameworkPropertyMetadata(Orientation.Horizontal));

		[TypeConverter(typeof (LengthConverter))]
		public double ItemHeight
		{
			get { return (double) GetValue(ItemHeightProperty); }
			set { SetValue(ItemHeightProperty, value); }
		}

		[TypeConverter(typeof (LengthConverter))]
		public double ItemWidth
		{
			get { return (double) GetValue(ItemWidthProperty); }
			set { SetValue(ItemWidthProperty, value); }
		}

		public Orientation Orientation
		{
			get { return (Orientation) GetValue(OrientationProperty); }
			set { SetValue(OrientationProperty, value); }
		}

		#endregion

		#region Methods

		private void SetFirstRowViewItemIndex(int index)
		{
			SetVerticalOffset((index)/Math.Floor((_viewport.Width)/_childSize.Width));
			SetHorizontalOffset((index)/Math.Floor((_viewport.Height)/_childSize.Height));
		}

		public void Resizing(object sender, EventArgs e)
		{
			if (!(Math.Abs(_viewport.Width) > 0)) return;
			var firstIndexCache = _firstIndex;
			_abstractPanel = null;
			MeasureOverride(_viewport);
			SetFirstRowViewItemIndex(_firstIndex);
			_firstIndex = firstIndexCache;
		}

		public int GetFirstVisibleSection()
		{
			int section;
			var maxSection = 0;
			if (_abstractPanel != null)
			{
				maxSection = _abstractPanel.Max(x => x.Section);
			}
			if (Orientation == Orientation.Horizontal)
			{
				section = (int) _offset.Y;
			}
			else
			{
				section = (int) _offset.X;
			}
			if (section > maxSection)
				section = maxSection;
			return section;
		}

		public int GetFirstVisibleIndex()
		{
			var section = GetFirstVisibleSection();

			var item = _abstractPanel?.FirstOrDefault(x => x.Section == section);
			return item?.Index ?? 0;
		}

		public void CleanUpItems(int minDesiredGenerated, int maxDesiredGenerated)
		{
			for (var i = _children.Count - 1; i >= 0; i--)
			{
				var childGeneratorPos = new GeneratorPosition(i, 0);
				var itemIndex = _generator.IndexFromGeneratorPosition(childGeneratorPos);
				if (itemIndex >= minDesiredGenerated && itemIndex <= maxDesiredGenerated) continue;
				try
				{
					_generator.Remove(childGeneratorPos, 1);
				}
				catch
				{
					Debug.WriteLine("Some shit went down...");
				}

				RemoveInternalChildRange(i, 1);
			}
		}

		private void ComputeExtentAndViewport(Size pixelMeasuredViewportSize, int visibleSections)
		{
			if (Orientation == Orientation.Horizontal)
			{
				_viewport.Height = visibleSections;
				_viewport.Width = pixelMeasuredViewportSize.Width;
			}
			else
			{
				_viewport.Width = visibleSections;
				_viewport.Height = pixelMeasuredViewportSize.Height;
			}

			if (Orientation == Orientation.Horizontal)
			{
				_extent.Height = _abstractPanel.SectionCount + ViewportHeight - 1;
			}
			else
			{
				_extent.Width = _abstractPanel.SectionCount + ViewportWidth - 1;
			}
			ScrollOwner.InvalidateScrollInfo();
		}

		private void ResetScrollInfo()
		{
			_offset.X = 0;
			_offset.Y = 0;
		}

		private int GetNextSectionClosestIndex(int itemIndex)
		{
			var abstractItem = _abstractPanel[itemIndex];
			if (abstractItem.Section >= _abstractPanel.SectionCount - 1) return itemIndex;
			var ret = _abstractPanel.
				Where(x => x.Section == abstractItem.Section + 1).
				OrderBy(x => Math.Abs(x.SectionIndex - abstractItem.SectionIndex)).
				First();
			return ret.Index;
		}

		private int GetLastSectionClosestIndex(int itemIndex)
		{
			var abstractItem = _abstractPanel[itemIndex];
			if (abstractItem.Section <= 0) return itemIndex;
			var ret = _abstractPanel.
				Where(x => x.Section == abstractItem.Section - 1).
				OrderBy(x => Math.Abs(x.SectionIndex - abstractItem.SectionIndex)).
				First();
			return ret.Index;
		}

		private void NavigateDown()
		{
			var gen = _generator.GetItemContainerGeneratorForPanel(this);
			var selected = (UIElement) Keyboard.FocusedElement;
			var itemIndex = gen.IndexFromContainer(selected);
			var depth = 0;
			while (itemIndex == -1)
			{
				selected = (UIElement) VisualTreeHelper.GetParent(selected);
				itemIndex = gen.IndexFromContainer(selected);
				depth++;
			}
			DependencyObject next;
			if (Orientation == Orientation.Horizontal)
			{
				var nextIndex = GetNextSectionClosestIndex(itemIndex);
				next = gen.ContainerFromIndex(nextIndex);
				while (next == null)
				{
					SetVerticalOffset(VerticalOffset + 1);
					UpdateLayout();
					next = gen.ContainerFromIndex(nextIndex);
				}
			}
			else
			{
				if (itemIndex == _abstractPanel.ItemCount - 1)
					return;
				next = gen.ContainerFromIndex(itemIndex + 1);
				while (next == null)
				{
					SetHorizontalOffset(HorizontalOffset + 1);
					UpdateLayout();
					next = gen.ContainerFromIndex(itemIndex + 1);
				}
			}
			while (depth != 0)
			{
				next = VisualTreeHelper.GetChild(next, 0);
				depth--;
			}
			((UIElement) next).Focus();
		}

		private void NavigateLeft()
		{
			var gen = _generator.GetItemContainerGeneratorForPanel(this);

			var selected = (UIElement) Keyboard.FocusedElement;
			var itemIndex = gen.IndexFromContainer(selected);
			var depth = 0;
			while (itemIndex == -1)
			{
				selected = (UIElement) VisualTreeHelper.GetParent(selected);
				itemIndex = gen.IndexFromContainer(selected);
				depth++;
			}
			DependencyObject next;
			if (Orientation == Orientation.Vertical)
			{
				var nextIndex = GetLastSectionClosestIndex(itemIndex);
				next = gen.ContainerFromIndex(nextIndex);
				while (next == null)
				{
					SetHorizontalOffset(HorizontalOffset - 1);
					UpdateLayout();
					next = gen.ContainerFromIndex(nextIndex);
				}
			}
			else
			{
				if (itemIndex == 0)
					return;
				next = gen.ContainerFromIndex(itemIndex - 1);
				while (next == null)
				{
					SetVerticalOffset(VerticalOffset - 1);
					UpdateLayout();
					next = gen.ContainerFromIndex(itemIndex - 1);
				}
			}
			while (depth != 0)
			{
				next = VisualTreeHelper.GetChild(next, 0);
				depth--;
			}
			((UIElement) next).Focus();
		}

		private void NavigateRight()
		{
			var gen = _generator.GetItemContainerGeneratorForPanel(this);
			var selected = (UIElement) Keyboard.FocusedElement;
			var itemIndex = gen.IndexFromContainer(selected);
			var depth = 0;
			while (itemIndex == -1)
			{
				selected = (UIElement) VisualTreeHelper.GetParent(selected);
				itemIndex = gen.IndexFromContainer(selected);
				depth++;
			}
			DependencyObject next;
			if (Orientation == Orientation.Vertical)
			{
				var nextIndex = GetNextSectionClosestIndex(itemIndex);
				next = gen.ContainerFromIndex(nextIndex);
				while (next == null)
				{
					SetHorizontalOffset(HorizontalOffset + 1);
					UpdateLayout();
					next = gen.ContainerFromIndex(nextIndex);
				}
			}
			else
			{
				if (itemIndex == _abstractPanel.ItemCount - 1)
					return;
				next = gen.ContainerFromIndex(itemIndex + 1);
				while (next == null)
				{
					SetVerticalOffset(VerticalOffset + 1);
					UpdateLayout();
					next = gen.ContainerFromIndex(itemIndex + 1);
				}
			}
			while (depth != 0)
			{
				next = VisualTreeHelper.GetChild(next, 0);
				depth--;
			}
			((UIElement) next).Focus();
		}

		private void NavigateUp()
		{
			var gen = _generator.GetItemContainerGeneratorForPanel(this);
			var selected = (UIElement) Keyboard.FocusedElement;
			var itemIndex = gen.IndexFromContainer(selected);
			var depth = 0;
			while (itemIndex == -1)
			{
				selected = (UIElement) VisualTreeHelper.GetParent(selected);
				itemIndex = gen.IndexFromContainer(selected);
				depth++;
			}
			DependencyObject next;
			if (Orientation == Orientation.Horizontal)
			{
				var nextIndex = GetLastSectionClosestIndex(itemIndex);
				next = gen.ContainerFromIndex(nextIndex);
				while (next == null)
				{
					SetVerticalOffset(VerticalOffset - 1);
					UpdateLayout();
					next = gen.ContainerFromIndex(nextIndex);
				}
			}
			else
			{
				if (itemIndex == 0)
					return;
				next = gen.ContainerFromIndex(itemIndex - 1);
				while (next == null)
				{
					SetHorizontalOffset(HorizontalOffset - 1);
					UpdateLayout();
					next = gen.ContainerFromIndex(itemIndex - 1);
				}
			}
			while (depth != 0)
			{
				next = VisualTreeHelper.GetChild(next, 0);
				depth--;
			}
			((UIElement) next).Focus();
		}

		#endregion

		#region Override

		protected override void OnKeyDown(KeyEventArgs e)
		{
			switch (e.Key)
			{
				case Key.Down:
					NavigateDown();
					e.Handled = true;
					break;
				case Key.Left:
					NavigateLeft();
					e.Handled = true;
					break;
				case Key.Right:
					NavigateRight();
					e.Handled = true;
					break;
				case Key.Up:
					NavigateUp();
					e.Handled = true;
					break;
				default:
					base.OnKeyDown(e);
					break;
			}
		}


		protected override void OnItemsChanged(object sender, ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
			_abstractPanel = null;
			ResetScrollInfo();

			// ...ADD THIS...
			switch (args.Action)
			{
				case NotifyCollectionChangedAction.Remove:
				case NotifyCollectionChangedAction.Replace:
					RemoveInternalChildRange(args.Position.Index, args.ItemUICount);
					break;
				case NotifyCollectionChangedAction.Move:
					RemoveInternalChildRange(args.OldPosition.Index, args.ItemUICount);
					break;
			}
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			_itemsControl = ItemsControl.GetItemsOwner(this);
			_children = InternalChildren;
			_generator = ItemContainerGenerator;
			SizeChanged += Resizing;
		}

		protected override Size MeasureOverride(Size availableSize)
		{
			if (_itemsControl == null || _itemsControl.Items.Count == 0)
				return availableSize;
			if (_abstractPanel == null)
				_abstractPanel = new WrapPanelAbstraction(_itemsControl.Items.Count);

			_pixelMeasuredViewport = availableSize;

			_realizedChildLayout.Clear();

			var realizedFrameSize = availableSize;

			var itemCount = _itemsControl.Items.Count;
			var firstVisibleIndex = GetFirstVisibleIndex();

			var startPos = _generator.GeneratorPositionFromIndex(firstVisibleIndex);

			var childIndex = (startPos.Offset == 0) ? startPos.Index : startPos.Index + 1;
			var current = firstVisibleIndex;
			var visibleSections = 1;
			using (_generator.StartAt(startPos, GeneratorDirection.Forward, true))
			{
				var stop = false;
				var isHorizontal = Orientation == Orientation.Horizontal;
				double currentX = 0;
				double currentY = 0;
				double maxItemSize = 0;
				var currentSection = GetFirstVisibleSection();
				while (current < itemCount)
				{
					bool newlyRealized;

					// Get or create the child                    
					var child = _generator.GenerateNext(out newlyRealized) as UIElement;
					if (newlyRealized)
					{
						// Figure out if we need to insert the child at the end or somewhere in the middle
						if (childIndex >= _children.Count)
						{
							if (child != null) AddInternalChild(child);
						}
						else
						{
							if (child != null) InsertInternalChild(childIndex, child);
						}
						_generator.PrepareItemContainer(child);

						//if (double.IsInfinity(ChildSlotSize.Width))
						//	ChildSlotSize.Width = this.MaxWidth;

						child?.Measure(ChildSlotSize);
					}
					else
					{
						// The child has already been created, let's be sure it's in the right spot

						Debug.Assert(Equals(child, _children[childIndex]), "Wrong child was generated");
					}
					if (child != null)
					{
						_childSize = child.DesiredSize;
						var childRect = new Rect(new Point(currentX, currentY), _childSize);
						if (isHorizontal)
						{
							maxItemSize = Math.Max(maxItemSize, childRect.Height);
							if (childRect.Right > realizedFrameSize.Width) //wrap to a new line
							{
								currentY = currentY + maxItemSize;
								currentX = 0;
								maxItemSize = childRect.Height;
								childRect.X = currentX;
								childRect.Y = currentY;
								currentSection++;
								visibleSections++;
							}
							if (currentY > realizedFrameSize.Height)
								stop = true;
							currentX = childRect.Right;
						}
						else
						{
							maxItemSize = Math.Max(maxItemSize, childRect.Width);
							if (childRect.Bottom > realizedFrameSize.Height) //wrap to a new column
							{
								currentX = currentX + maxItemSize;
								currentY = 0;
								maxItemSize = childRect.Width;
								childRect.X = currentX;
								childRect.Y = currentY;
								currentSection++;
								visibleSections++;
							}
							if (currentX > realizedFrameSize.Width)
								stop = true;
							currentY = childRect.Bottom;
						}
						_realizedChildLayout.Add(child, childRect);
					}
					_abstractPanel.SetItemSection(current, currentSection);

					if (stop)
						break;
					current++;
					childIndex++;
				}
			}
			CleanUpItems(firstVisibleIndex, current - 1);

			ComputeExtentAndViewport(availableSize, visibleSections);

			return availableSize;
		}

		protected override Size ArrangeOverride(Size finalSize)
		{
			if (_children == null) return finalSize;
			foreach (UIElement child in _children)
			{
				var layoutInfo = _realizedChildLayout[child];
				child.Arrange(layoutInfo);
			}
			return finalSize;
		}

		#endregion

		#region IScrollInfo Members

		public bool CanHorizontallyScroll { get; set; }

		public bool CanVerticallyScroll { get; set; }

		public double ExtentHeight => _extent.Height;

		public double ExtentWidth => _extent.Width;

		public double HorizontalOffset => _offset.X;

		public double VerticalOffset => _offset.Y;

		public void LineDown()
		{
			if (Orientation == Orientation.Vertical)
				SetVerticalOffset(VerticalOffset + 20);
			else
				SetVerticalOffset(VerticalOffset + 1);
		}

		public void LineLeft()
		{
			if (Orientation == Orientation.Horizontal)
				SetHorizontalOffset(HorizontalOffset - 20);
			else
				SetHorizontalOffset(HorizontalOffset - 1);
		}

		public void LineRight()
		{
			if (Orientation == Orientation.Horizontal)
				SetHorizontalOffset(HorizontalOffset + 20);
			else
				SetHorizontalOffset(HorizontalOffset + 1);
		}

		public void LineUp()
		{
			if (Orientation == Orientation.Vertical)
				SetVerticalOffset(VerticalOffset - 20);
			else
				SetVerticalOffset(VerticalOffset - 1);
		}

		public Rect MakeVisible(Visual visual, Rect rectangle)
		{
			var gen = _generator.GetItemContainerGeneratorForPanel(this);
			var element = (UIElement) visual;
			var itemIndex = gen.IndexFromContainer(element);
			while (itemIndex == -1)
			{
				element = (UIElement) VisualTreeHelper.GetParent(element);
				itemIndex = gen.IndexFromContainer(element);
			}
			var elementRect = _realizedChildLayout[element];
			if (Orientation == Orientation.Horizontal)
			{
				var viewportHeight = _pixelMeasuredViewport.Height;
				if (elementRect.Bottom > viewportHeight)
					_offset.Y += 1;
				else if (elementRect.Top < 0)
					_offset.Y -= 1;
			}
			else
			{
				var viewportWidth = _pixelMeasuredViewport.Width;
				if (elementRect.Right > viewportWidth)
					_offset.X += 1;
				else if (elementRect.Left < 0)
					_offset.X -= 1;
			}
			InvalidateMeasure();
			return elementRect;
		}

		public void MouseWheelDown()
		{
			PageDown();
		}

		public void MouseWheelLeft()
		{
			PageLeft();
		}

		public void MouseWheelRight()
		{
			PageRight();
		}

		public void MouseWheelUp()
		{
			PageUp();
		}

		public void PageDown()
		{
			SetVerticalOffset(VerticalOffset + _viewport.Height*0.8);
		}

		public void PageLeft()
		{
			SetHorizontalOffset(HorizontalOffset - _viewport.Width*0.8);
		}

		public void PageRight()
		{
			SetHorizontalOffset(HorizontalOffset + _viewport.Width*0.8);
		}

		public void PageUp()
		{
			SetVerticalOffset(VerticalOffset - _viewport.Height*0.8);
		}

		public ScrollViewer ScrollOwner { get; set; }

		public void SetHorizontalOffset(double offset)
		{
			if (offset < 0 || _viewport.Width >= _extent.Width)
			{
				offset = 0;
			}
			else
			{
				if (offset + _viewport.Width >= _extent.Width)
				{
					offset = _extent.Width - _viewport.Width;
				}
			}

			_offset.X = offset;

			ScrollOwner?.InvalidateScrollInfo();

			InvalidateMeasure();
			_firstIndex = GetFirstVisibleIndex();
		}

		public void SetVerticalOffset(double offset)
		{
			if (offset < 0 || _viewport.Height >= _extent.Height)
			{
				offset = 0;
			}
			else
			{
				if (offset + _viewport.Height >= _extent.Height)
				{
					offset = _extent.Height - _viewport.Height;
				}
			}

			_offset.Y = offset;

			ScrollOwner?.InvalidateScrollInfo();

			//_trans.Y = -offset;

			InvalidateMeasure();
			_firstIndex = GetFirstVisibleIndex();
		}

		public double ViewportHeight => _viewport.Height;

		public double ViewportWidth => _viewport.Width;

		#endregion

		#region helper data structures

		private class ItemAbstraction
		{
			private readonly WrapPanelAbstraction _panel;
			public readonly int Index;
			private int _section = -1;
			private int _sectionIndex = -1;

			public ItemAbstraction(WrapPanelAbstraction panel, int index)
			{
				_panel = panel;
				Index = index;
			}

			public int SectionIndex
			{
				get
				{
					if (_sectionIndex == -1)
					{
						return Index%_panel.AverageItemsPerSection - 1;
					}
					return _sectionIndex;
				}
				set
				{
					if (_sectionIndex == -1)
						_sectionIndex = value;
				}
			}

			public int Section
			{
				get
				{
					if (_section == -1)
					{
						return Index/_panel.AverageItemsPerSection;
					}
					return _section;
				}
				set
				{
					if (_section == -1)
						_section = value;
				}
			}
		}

		private class WrapPanelAbstraction : IEnumerable<ItemAbstraction>
		{
			private readonly object _syncRoot = new object();
			public readonly int ItemCount;
			private int _currentSetItemIndex = -1;
			private int _currentSetSection = -1;
			private int _itemsInCurrentSecction;
			public int AverageItemsPerSection;

			public WrapPanelAbstraction(int itemCount)
			{
				var items = new List<ItemAbstraction>(itemCount);
				for (var i = 0; i < itemCount; i++)
				{
					var item = new ItemAbstraction(this, i);
					items.Add(item);
				}

				Items = new ReadOnlyCollection<ItemAbstraction>(items);
				AverageItemsPerSection = itemCount;
				ItemCount = itemCount;
			}

			public int SectionCount
			{
				get
				{
					var ret = _currentSetSection + 1;
					if (_currentSetItemIndex + 1 >= Items.Count) return ret;
					var itemsLeft = Items.Count - _currentSetItemIndex;
					ret += itemsLeft/AverageItemsPerSection + 1;
					return ret;
				}
			}

			private ReadOnlyCollection<ItemAbstraction> Items { get; }
			public ItemAbstraction this[int index] => Items[index];

			#region IEnumerable<ItemAbstraction> Members

			public IEnumerator<ItemAbstraction> GetEnumerator()
			{
				return Items.GetEnumerator();
			}

			#endregion

			#region IEnumerable Members

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}

			#endregion

			public void SetItemSection(int index, int section)
			{
				lock (_syncRoot)
				{
					if (section > _currentSetSection + 1 || index != _currentSetItemIndex + 1) return;
					_currentSetItemIndex++;
					Items[index].Section = section;
					if (section == _currentSetSection + 1)
					{
						_currentSetSection = section;
						if (section > 0)
						{
							AverageItemsPerSection = (index)/(section);
						}
						_itemsInCurrentSecction = 1;
					}
					else
						_itemsInCurrentSecction++;
					Items[index].SectionIndex = _itemsInCurrentSecction - 1;
				}
			}
		}

		#endregion
	}
}