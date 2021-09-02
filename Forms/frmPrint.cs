using RefTagFinder.Classes.DataControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefTagFinder.Forms
{
    public partial class frmPrint : Form
    {
        List<Equipment> Equipments = new List<Equipment>();
        public bool printCenterImage = true;

        public frmPrint()
        {
            InitializeComponent();
        }

        public frmPrint(Image image,List<Equipment> equipment)
        {
            InitializeComponent();
            pixUnit.Image = image;
            //printDocument1.
            //printPreviewControl1.Document = 
            Equipments = equipment;
        }
        private void frmPrint_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pixUnit_Click(sender, e);
        }

        private void pixUnit_Click(object sender, EventArgs e)
        {
            using (Graphics graphics = Graphics.FromImage(pixUnit.Image))
            {
                Pen pen = new Pen(Brushes.Black, 10);
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                foreach (Equipment equipment in Equipments)
                {
                    graphics.DrawLine(
                    pen,
                    new Point(Convert.ToInt32(equipment.XOffset) - 100, Convert.ToInt32(equipment.YOffset) - 100),
                    new Point(Convert.ToInt32(equipment.XOffset), Convert.ToInt32(equipment.YOffset)));
                }
            }
            string OutputPath = Application.StartupPath + @"\Data\Temp";
            if (!Directory.Exists(OutputPath))
            {
                Directory.CreateDirectory(OutputPath);
            }
            OutputPath = OutputPath + "\\" + "forPrint" + ".jpg";
            new Bitmap(pixUnit.Image).Save(OutputPath, ImageFormat.Jpeg);
        } 

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RectangleF marginBounds = e.MarginBounds;
            RectangleF printableArea = e.PageSettings.PrintableArea;

            int availableWidth = (int)Math.Floor(printDocument1.OriginAtMargins
                ? marginBounds.Width
                : (e.PageSettings.Landscape
                    ? printableArea.Height
                    : printableArea.Width));

            int availableHeight = (int)Math.Floor(printDocument1.OriginAtMargins
                ? marginBounds.Height
                : (e.PageSettings.Landscape
                    ? printableArea.Width
                    : printableArea.Height));

            if (availableWidth > pixUnit.Image.Width && availableHeight > pixUnit.Image.Height)
            {
                int x = 0, y = 0;
                if (printCenterImage)
                {
                    x = (availableWidth - pixUnit.Image.Width) / 2;
                    y = (availableHeight - pixUnit.Image.Height) / 2;
                }
                e.Graphics.DrawImage(pixUnit.Image, x, y, pixUnit.Image.Width, pixUnit.Image.Height);
            }
            else
            {
                double scaleW = availableWidth / (double)pixUnit.Image.Width;
                double scaleH = availableHeight / (double)pixUnit.Image.Height;

                if (scaleW < scaleH)
                {
                    int x = 0, y = 0;
                    if (printCenterImage)
                    {
                        x = (availableWidth - Convert.ToInt32(pixUnit.Image.Width * scaleW)) / 2;
                        y = (availableHeight - Convert.ToInt32(pixUnit.Image.Height * scaleW)) / 2;
                    }
                    e.Graphics.DrawImage(pixUnit.Image, x, y, availableWidth, Convert.ToInt32(pixUnit.Image.Height * scaleW));
                }
                else
                {
                    int x = 0, y = 0;
                    if (printCenterImage)
                    {
                        x = (availableWidth - Convert.ToInt32(pixUnit.Image.Width * scaleH)) / 2;
                        y = (availableHeight - Convert.ToInt32(pixUnit.Image.Height * scaleH)) / 2;
                    }
                    e.Graphics.DrawImage(pixUnit.Image, x, y, Convert.ToInt32(pixUnit.Image.Width * scaleH), availableHeight);
                }
            }
            //pixUnit.Image
            //e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*Graphics g = pixUnit.CreateGraphics();
            bmp = new Bitmap(pixUnit.Size.Width, pixUnit.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            
            mg.CopyFromScreen(pixUnit.Location.X, pixUnit.Location.Y, 0, 0, pixUnit.Size);

            printPreviewDialog1.ShowDialog();*/
            string OutputPath = Application.StartupPath + @"\Data\Temp";
            if (!Directory.Exists(OutputPath))
            {
                Directory.CreateDirectory(OutputPath);
            }
            OutputPath = OutputPath + "\\" + "forPrint" + ".jpg";
            new Bitmap(pixUnit.Image).Save(OutputPath, ImageFormat.Jpeg);
            if (File.Exists(OutputPath))
            {
                printDocument1.DocumentName = OutputPath;
                printDocument1.PrinterSettings.PrintFileName = OutputPath;
                PrintForm pf = new PrintForm(printDocument1, OutputPath);
                pf.Owner = this;
                if (pf.ShowDialog() == DialogResult.OK && printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
                pf.Dispose();
            }
        }

        private void btnSendTo_Click(object sender, EventArgs e)
        {
            try
            {
                string OutputPathFolder = Application.StartupPath + @"\Data\Temp";
                if (!Directory.Exists(OutputPathFolder))
                {
                    Directory.CreateDirectory(OutputPathFolder);
                }
                string OutputPathFile = OutputPathFolder + "\\" + "forPrint" + ".jpg";
                if (File.Exists(OutputPathFile))
                    Process.Start("C:\\Windows\\System32\\mspaint.exe", '"' + OutputPathFile + '"');

            }
            catch
            {
                MessageBox.Show("unable-to-run-external-app");
            }
        }
    }
}
