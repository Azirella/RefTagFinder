/*
 * Created by SharpDevelop.
 * User: 832954
 * Date: 02/27/2021
 * Time: 12:26 ب.ظ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using static pdf2image.SautinSoft.PdfFocus.Program;




//using RefTagFinder.Mainpaint;

namespace RefTagFinder
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		/*string pdf_filename = @"D:\DW-6340S-100-0060-1001-Rev.8.pdf";
		string png_filename = @"D:\";// converted.png";*/
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			//Form fff = new ma
			Mainpaint.Form1 fff = new Mainpaint.Form1();
			fff.pictureBox1.Image = this.pictureBox1.Image;
			
			fff.Show();

			

		}

        private void button2_Click(object sender, EventArgs e)
        {
			var img = ConvertPDF2Image("C:\\FileServer\\test.pdf");

			Bitmap src = (Bitmap)((new ImageConverter()).ConvertFrom(img));

			pictureBox1.Image = src;

			Rectangle cropRect = new Rectangle(pictureBox1.Top + 50, pictureBox1.Left + 50, pictureBox1.Width - 100, pictureBox1.Height - 100);
			
			Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

			using (Graphics g = Graphics.FromImage(target))
			{
				g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
								 cropRect,
								 GraphicsUnit.Pixel);
			}

			pictureBox1.Image = target;

			
			/*
			 
			 Image image = new Bitmap("Apple.gif");

				// Draw the image unaltered with its upper-left corner at (0, 0).
				e.Graphics.DrawImage(image, 0, 0);

				// Make the destination rectangle 30 percent wider and
				// 30 percent taller than the original image.
				// Put the upper-left corner of the destination
				// rectangle at (150, 20).
				int width = image.Width;
				int height = image.Height;
				RectangleF destinationRect = new RectangleF(
					150,
					20,
					1.3f * width,
					1.3f * height);

				// Draw a portion of the image. Scale that portion of the image
				// so that it fills the destination rectangle.
				RectangleF sourceRect = new RectangleF(0, 0, .75f * width, .75f * height);
				e.Graphics.DrawImage(
					image,
					destinationRect,
					sourceRect,
					GraphicsUnit.Pixel);
			 
			 */


		}

		private void MainForm_Load(object sender, EventArgs e)
        {
			panel1.Height = this.Height - panel2.Height;
			
        }

        private void button3_Click(object sender, EventArgs e)
        {
			
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			//this.Owner.Close();
			Application.Exit();
        }
    }
}
