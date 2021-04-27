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
using Dapper;
using RefTagFinder.Classes.DataControl;
using System.Threading;

namespace RefTagFinder
{
    public partial class frmTagFinder : Form
    {
        /*SqlConnection con1;
        SqlCommand cmd1;
        SqlDataAdapter da1;
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\DBs\\db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();*/

        List<Unit> _AllUnins;
        Unit _CurrentUnit;


        public frmTagFinder()
        {
            InitializeComponent();


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void frmTagFinder_Load(object sender, EventArgs e)
        {

            #region reposition
            btnExit.Top = 0;
            btnExit.Left = this.Width - btnExit.Width;

            btnMinimize.Top = 0;
            btnMinimize.Left = btnExit.Left - btnExit.Width - 2;

            pnlTop.Height = btnExit.Height = btnMinimize.Height = this.Height * 5 / 100;

            unitImagePictureBox.Dock = DockStyle.Fill;
            #endregion

            #region loadAllUnits
            using (IDbConnection cnn = new SqlConnection(HelperStatic.LoadConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@tblName", "Unit");
                string sql = "[dbo].[SelectTable]";
                _AllUnins = cnn.Query<Unit>(sql, p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            #endregion

            /*#region Binding
            unitBindingSource.DataSource = CurrentUnit;
            unitBindingSource.ResetBindings(true);
            #endregion*/

            unitNameComboBox.DataSource = _AllUnins.OrderBy(x => x.UnitName).Select(x => x.UnitName).ToList();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddUnit f = new FrmAddUnit();
            f.ShowDialog();
            /*if (f.DialogResult == DialogResult.OK)
            {
                frmTagFinder_Load(sender, e);
            }*/
            frmTagFinder_Load(sender, e);
        }

        private void unitNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CurrentUnit = _AllUnins.Where(x => x.UnitName == unitNameComboBox.Text).First();
            unitImagePictureBox.ImageLocation = _CurrentUnit.ImagePath;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAddUnit f = new FrmAddUnit(_CurrentUnit);
            f.ShowDialog();
            frmTagFinder_Load(sender, e);
        }
    }
}
