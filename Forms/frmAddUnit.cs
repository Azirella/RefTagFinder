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
using RefTagFinder.Classes.DataControl;
//using RefTagFinder.Classes.Models;
namespace RefTagFinder
{
    public partial class frmAddUnit : Form
    {
       
        public frmAddUnit()
        {
            InitializeComponent();

            
        }

        Unit _mainFormUnit = new Unit();
        
        

        private void frmTagFinder_Load(object sender, EventArgs e)
        {
            #region RePositionControl
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
            #endregion

            #region Binding
            unitBindingSource.DataSource = _mainFormUnit;
            unitBindingSource.ResetBindings(true);
            #endregion
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            
            bool Condition = true;
            if (Condition)
            {
                using (LINQtoDBDataContext dbtemp = new LINQtoDBDataContext())
                {
                    //_mainFormUnit.UnitID = null;
                    //Unit uuu = new Unit() { UnitName=unitNameTextBox.Text};
                    dbtemp.Units.InsertOnSubmit(_mainFormUnit);
                    dbtemp.SubmitChanges();
                }
            }
            //this.Close();
        }

        private void pidBrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void ImageBrowseButton_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
