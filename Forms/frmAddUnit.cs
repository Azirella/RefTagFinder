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
        /*SqlConnection con1;
        SqlCommand cmd1;
        SqlDataAdapter da1;*/
        public frmAddUnit()
        {
            InitializeComponent();

            
        }
        //private var info = 1234;
        
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\DBs\\db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //string cnnStr = HelperStatic.LoadConnectionString("LocalDBConnectionString");
        

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

            pnlTop.Height = btnExit.Height = btnMinimize.Height = this.Height * 5 / 100;
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
