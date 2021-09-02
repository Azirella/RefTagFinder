//using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RefTagFinder.Forms
{
	partial class PrintForm : Form
	{
		private MainForm owner;
        private bool FirstLoad = true;

        public PrintForm(PrintDocument pd, string docTitle)
		{
			InitializeComponent();
			/*SetDraggableControls(new List<Control>() { 
				printPreviewControl1, 
				documentLabel, marginsLabel, leftLabel, rightLabel, topLabel, bottomLabel
			});*/

			leftMarginTextBox.Value = pd.DefaultPageSettings.Margins.Left;
			topMarginTextBox.Value = pd.DefaultPageSettings.Margins.Top;
			rightMarginTextBox.Value = pd.DefaultPageSettings.Margins.Right;
			bottomMarginTextBox.Value = pd.DefaultPageSettings.Margins.Bottom;

			printPreviewControl1.Document = pd;

			titleTextBox.Text = docTitle;
		}

		

		private void marginsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			printPreviewControl1.Document.OriginAtMargins = marginsCheckBox.Checked;
			printPreviewControl1.InvalidatePreview();

			leftMarginTextBox.Enabled = marginsCheckBox.Checked;
			topMarginTextBox.Enabled = marginsCheckBox.Checked;
			rightMarginTextBox.Enabled = marginsCheckBox.Checked;
			bottomMarginTextBox.Enabled = marginsCheckBox.Checked;

			setMarginsButton.Visible = marginsCheckBox.Checked;
		}

		private void horizontalCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			printPreviewControl1.Document.DefaultPageSettings.Landscape = horizontalCheckBox.Checked;
			printPreviewControl1.InvalidatePreview();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			printPreviewControl1.Document.DocumentName = titleTextBox.Text;
			printPreviewControl1.Document.PrinterSettings.PrintFileName = titleTextBox.Text;
			DialogResult = DialogResult.OK;
		}

		private void PrintForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) Close();
		}

		private void centerCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			/*owner.printCenterImage = centerCheckbox.Checked;
			printPreviewControl1.InvalidatePreview();*/
		}

		private void setMarginsButton_Click(object sender, EventArgs e)
		{
			try
			{
				printPreviewControl1.Document.DefaultPageSettings.Margins.Left = Convert.ToInt32(leftMarginTextBox.Value);
				printPreviewControl1.Document.DefaultPageSettings.Margins.Top = Convert.ToInt32(topMarginTextBox.Value);
				printPreviewControl1.Document.DefaultPageSettings.Margins.Right = Convert.ToInt32(rightMarginTextBox.Value);
				printPreviewControl1.Document.DefaultPageSettings.Margins.Bottom = Convert.ToInt32(bottomMarginTextBox.Value);
				printPreviewControl1.InvalidatePreview();
			}
			catch
			{
                /*DialogMan.ShowInfo(
					this,
					LangMan.Get("plugin-not-found"),
					LangMan.Get("print-margins-error"),
					DarkMode
				);*/
                MessageBox.Show("Test");
            }
		}

		private void setMarginsButton_EnabledChanged(object sender, EventArgs e)
		{
			/*if (DarkMode)
			{
				Button btn = (Button)sender;

				if (btn.Enabled) btn.BackColor = ThemeMan.DarkSecondColor;
				else btn.BackColor = ThemeMan.DarkSecondColor;
			}*/
		}

		private void PrintForm_Load(object sender, EventArgs e)
		{
			owner = Owner as MainForm;

			//centerCheckbox.Checked = owner.printCenterImage;
			marginsCheckBox.Checked = printPreviewControl1.Document.OriginAtMargins;
            if (FirstLoad)
            {
				this.printPreviewControl1.Document.DefaultPageSettings.Landscape = true;
			}
			horizontalCheckBox.Checked = printPreviewControl1.Document.DefaultPageSettings.Landscape;
			FirstLoad = false;
		}

		

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void leftMarginTextBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
