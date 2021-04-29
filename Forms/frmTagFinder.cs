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
using RefTagFinder.Forms.User_Controls;

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

        List<EquipmentType> _AllEquipmentTypes;
        EquipmentType _CurrentEquipmentType;

        List<Equipment> _AllEquipments;
        Equipment _CurrentEquipment;

        public enum ClickedTask
        {
            AddEquipment, DeleteEquipment, nulll
        }

        ClickedTask my_clickedTask;
        public ClickedTask MyProperty 
        {
            get { return my_clickedTask; } 
            set { my_clickedTask = value; } 
        }

        public frmTagFinder()
        {
            InitializeComponent();


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        public void frmTagFinder_Load(object sender, EventArgs e)
        {

            #region reposition
            btnExit.Top = 0;
            btnExit.Left = this.Width - btnExit.Width;

            btnMinimize.Top = 0;
            btnMinimize.Left = btnExit.Left - btnExit.Width - 2;

            pnlTop.Height = btnExit.Height = btnMinimize.Height = this.Height * 5 / 100;

            unitImagePictureBox.Dock = DockStyle.Fill;
            #endregion

            #region Binding
            /*unitBindingSource.DataSource = _CurrentUnit;
            unitBindingSource.ResetBindings(true);*/

            /*equipmentTypeBindingSource.DataSource = _CurrentEquipmentType;
            equipmentTypeBindingSource.ResetBindings(true);*/

            /*equipmentBindingSource.DataSource = _CurrentEquipment;
            equipmentBindingSource.ResetBindings(true);*/
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

            #region loadAllEquipmentType
            using (IDbConnection cnn = new SqlConnection(HelperStatic.LoadConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@tblName", "EquipmentType");
                string sql = "[dbo].[SelectTable]";
                _AllEquipmentTypes = cnn.Query<EquipmentType>(sql, p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            #endregion

            #region loadAllEquipment
            using (IDbConnection cnn = new SqlConnection(HelperStatic.LoadConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@tblName", "Equipment");
                string sql = "[dbo].[SelectTable]";
                _AllEquipments = cnn.Query<Equipment>(sql, p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            #endregion

            unitNameComboBox1.DataSource =
             unitNameComboBox.DataSource =
                _AllUnins.OrderBy(x => x.UnitName).Select(x => x.UnitName).ToList();
            equipmentNameComboBox1.DataSource =
             equipmentNameComboBox.DataSource =
                _AllEquipmentTypes.OrderBy(x => x.EquipmentName).Select(x => x.EquipmentName).ToList();


            test_Timer.Start();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddUnit f = new FrmAddUnit();
            f.Show();// Dialog();
            /*if (f.DialogResult == DialogResult.OK)
            {
                frmTagFinder_Load(sender, e);
            }*/
            //frmTagFinder_Load(sender, e);
        }

        private void unitNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (0 <= unitNameComboBox.SelectedIndex)
            {
                _CurrentUnit = _AllUnins.Where(x => x.UnitName == unitNameComboBox.Text).First();
                unitImagePictureBox.ImageLocation = _CurrentUnit.ImagePath;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAddUnit f = new FrmAddUnit(_CurrentUnit);
            unitNameComboBox.SelectedIndex = -1;
            f.ShowDialog();
            frmTagFinder_Load(sender, e);
        }

        private void test_Timer_Tick(object sender, EventArgs e)
        {
            /*equipmentControl1.Top += 10;
            equipmentControl1.Left += 10;*/
        }

        private void btnAddEquipmentType_Click(object sender, EventArgs e)
        {
            Forms.FrmAddEquipmentType f = new Forms.FrmAddEquipmentType();
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmTagFinder_Load(sender, e);
        }

        private void equipmentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 <= equipmentNameComboBox.SelectedIndex)
            {
                _CurrentEquipmentType = _AllEquipmentTypes.Where(x => x.EquipmentName == equipmentNameComboBox.Text).First();
            }
        }

        private void btnEditEquipmentType_Click(object sender, EventArgs e)
        {
            Forms.FrmAddEquipmentType f = new Forms.FrmAddEquipmentType(_CurrentEquipmentType);
            f.ShowDialog();
            frmTagFinder_Load(sender, e);
        }

        private void unitImagePictureBox_Click(object sender, EventArgs e)
        {
            /*
            */
        }

        private void unitImagePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelInfo.Text = $"x: {e.X}  y:{e.Y}  location:{e.Location}" +
                                            $"  Button: {e.Button}  Clicks:{e.Clicks}";
            EquipmentControl equipmentControl = new EquipmentControl();
            

            //equipmentControl.Location = new Point(e.X, e.Y);
            /*equipmentControl.my_Equipment.IsDatum = true;
            equipmentControl.my_Equipment.Latitude = "13213";
            equipmentControl.my_Equipment.Longitude = "1111111";*/

            equipmentControl.BringToFront();
            unitImagePictureBox.Controls.Add(equipmentControl);

            equipmentControl.Top = e.X;
            equipmentControl.Left = e.Y;// + (sender as Button).Width;

            //equipmentControl._Move(e.X, e.Y);
            toolStripStatusLabelInfo.Text += $"____ eqTop : {equipmentControl.Top}, eqLeft : {equipmentControl.Left}";

            /*if (e.Button != System.Windows.Forms.MouseButtons.Middle)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        
                        //Forms.User_Controls.My_Equipment me = new Forms.User_Controls.My_Equipment(new Forms.User_Controls.EquipmentControl());
                        Button me = new Button();
                        me.Text = new Point(e.X, e.Y).ToString();
                        me.Name = new Point(e.X, e.Y).ToString();
                        me.Size = new Size(20, 20);
                        me.Location = new Point(1000, 1000); //new Point(e.X, e.Y);
                        me.Enabled = me.Visible = true;
                        me.Click += new EventHandler(btnDynamic_click);

                        unitImagePictureBox.Controls.Add(me);

                        btnDynamic_click(me, e);


                        toolStripStatusLabelInfo.Text = $"x: {e.X}  y:{e.Y}  location:{e.Location}" +
                                                        $"  Button: {e.Button}  Clicks:{e.Clicks}  Delta:{e.Delta}";
                        break;
                    case MouseButtons.Right:
                        lblTest.Text = $"Button: {e.Button}\n Clicks:{e.Clicks}\n Delta:{e.Delta}";
                        break;
                        
                }

            }*/
        }

        private void btnDynamic_click(object sender, EventArgs e)
        {
            MessageBox.Show($"top: {(sender as Button).Top}\nleft: {(sender as Button).Left}");

            EquipmentControl equipmentControl = new EquipmentControl();
            equipmentControl.Top = (sender as Button).Top;
            equipmentControl.Left = (sender as Button).Left + (sender as Button).Width;
            unitImagePictureBox.Controls.Add(equipmentControl);

            
            //this.Close();
        }
    }
}
