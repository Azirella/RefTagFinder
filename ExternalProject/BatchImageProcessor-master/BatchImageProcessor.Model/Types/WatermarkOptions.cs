using System;
using System.Drawing;
using BatchImageProcessor.Model.Types.Enums;

namespace BatchImageProcessor.Model.Types
{
	[Serializable]
	public class WatermarkOptions
	{
		private Font _watermarkFont;

		public WatermarkOptions()
		{
			WatermarkFont = new Font("Calibri", 12f);
		}

		~WatermarkOptions()
		{
			_watermarkFont?.Dispose();
		}

		public bool WatermarkGreyscale { get; set; } = true;
		public string WatermarkText { get; set; } = string.Empty;
		public string WatermarkImagePath { get; set; } = string.Empty;
		public Alignment WatermarkAlignment { get; set; } = Alignment.Bottom_Right;
		public double WatermarkOpacity { get; set; } = 0.7;
		public WatermarkType WatermarkType { get; set; } = WatermarkType.Text;
		public string WatermarkFontString => $"{WatermarkFont.FontFamily.Name}, {WatermarkFont.SizeInPoints}pt";

		public Font WatermarkFont
		{
			get { return _watermarkFont; }
			set
			{
				_watermarkFont?.Dispose();
				_watermarkFont = value;
			}
		}
	}
}