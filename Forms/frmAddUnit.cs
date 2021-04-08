using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;

namespace RefTagFinder
{
    public partial class frmAddUnit : Form
    {
       
        public frmAddUnit()
        {
            InitializeComponent();

            
        }
       
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTagFinder_Load(object sender, EventArgs e)
        {

            btnExit.Top = 0;
            btnExit.Left = this.Width - btnExit.Width;

            btnMinimize.Top = 0;
            btnMinimize.Left = btnExit.Left - btnExit.Width - 2;

            btnExit.Height = btnMinimize.Height = this.Height * 5 / 100;
            pnlTop.Height = btnExit.Height + 2;
            
            this.btnExit.Font     =
            this.btnMinimize.Font =
                new System.Drawing.Font
                ("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pidBrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void ImageBrowseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
