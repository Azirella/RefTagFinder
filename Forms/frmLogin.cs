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
    public partial class frmTagFinder : Form
    {
        /*SqlConnection con1;
        SqlCommand cmd1;
        SqlDataAdapter da1;*/
        public frmTagFinder()
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
            btnExit.Top = this.Height - btnExit.Height;
            btnExit.Left = this.Width - btnExit.Width;
        }
    }
}
