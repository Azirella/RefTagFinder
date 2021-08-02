using RefTagFinder.Classes.DataControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefTagFinder.Forms
{
    public partial class frmPrint : Form
    {
        List<Equipment> Equipments = new List<Equipment>();
        public frmPrint()
        {
            InitializeComponent();
        }

        public frmPrint(Image image,List<Equipment> equipment)
        {
            InitializeComponent();
            pixUnit.Image = image;
            Equipments = equipment;
        }
        private void frmPrint_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pixUnit_Click(sender, e);
        }

        private void pixUnit_Click(object sender, EventArgs e)
        {
            Graphics graphics = pixUnit.CreateGraphics();
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

        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //pixUnit.Image
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = pixUnit.CreateGraphics();
            bmp = new Bitmap(pixUnit.Size.Width, pixUnit.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(pixUnit.Location.X, pixUnit.Location.Y, 0, 0, pixUnit.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
