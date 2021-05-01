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
using RefTagFinder.Forms;

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

        List<Unit> _AllUnins;// = new List<Unit>();
        Unit _CurrentUnit;// = new Unit();

        List<EquipmentType> _AllEquipmentTypes;// = new List<EquipmentType>();
        EquipmentType _CurrentEquipmentType;// = new EquipmentType();

        List<Equipment> _AllEquipments;// = new List<Equipment>();
        Equipment _CurrentEquipment;// = new Equipment();

        bool loadIsFinished = false;
        public enum ClickedTask
        {
            AddEquipment, DeleteEquipment, nulll
        }

        ClickedTask my_clickedTask = ClickedTask.nulll;


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
            unitBindingSource.ResetBindings(true);

            equipmentTypeBindingSource.DataSource = _CurrentEquipmentType;
            equipmentTypeBindingSource.ResetBindings(true);

            equipmentBindingSource.DataSource = _CurrentEquipment;
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

            this.equipmentNameComboBox.SelectedIndexChanged += new System.EventHandler(this.equipmentNameComboBox_SelectedIndexChanged);
            this.unitNameComboBox.SelectedIndexChanged += new System.EventHandler(this.unitNameComboBox_SelectedIndexChanged);
            equipmentNameComboBox_SelectedIndexChanged(sender, null);
            unitNameComboBox_SelectedIndexChanged(sender, null);


            #region loadAllEquipment
            using (IDbConnection cnn = new SqlConnection(HelperStatic.LoadConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@tblName", "Equipment");
                string sql = "[dbo].[SelectTable]";
                _AllEquipments = cnn.Query<Equipment>(sql, p,
                    commandType: CommandType.StoredProcedure).ToList();
                foreach (Equipment equipment in _AllEquipments)
                {
                    int x = 0;
                    Int32.TryParse(equipment.XOffset.ToString(),out x);
                    int y = 0;
                    Int32.TryParse(equipment.YOffset.ToString(), out y);
                    MouseEventArgs e1 = new MouseEventArgs(MouseButtons.Left, 1, x, y, 1);
                    my_clickedTask = ClickedTask.AddEquipment;
                    unitImagePictureBox_MouseDown(sender, e1);
                    //e1.X = equipment.XOffset;
                }
            }
            #endregion

            
             unitNameComboBox.DataSource =
                _AllUnins.OrderBy(x => x.UnitName).Select(x => x.UnitName).ToList();
            
             equipmentNameComboBox.DataSource =
                _AllEquipmentTypes.OrderBy(x => x.EquipmentName).Select(x => x.EquipmentName).ToList();


            
            loadIsFinished = true;
            //test_Timer.Start();
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

        
        private void unitImagePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelInfo.Text = $"x: {e.X}  y:{e.Y}  location:{e.Location}" +
                                            $"  Button: {e.Button}  Clicks:{e.Clicks}";

            if (e.Button != System.Windows.Forms.MouseButtons.Middle)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:

                        if (my_clickedTask == ClickedTask.AddEquipment)
                        {
                            Button me = new Button();
                            me.Text = new Point(e.X, e.Y).ToString();
                            me.Name = new Point(e.X, e.Y).ToString();
                            me.Size = new Size(20, 20);
                            me.Location = new Point(e.X, e.Y);
                            me.Enabled = me.Visible = true;

                            me.Click += new EventHandler(btnDynamic_click);
                            unitImagePictureBox.Controls.Add(me);
                            if (loadIsFinished)
                            {
                                btnDynamic_click(me, e);
                            }
                            

                            toolStripStatusLabelInfo.Text = $"x: {e.X}  y:{e.Y}  location:{e.Location}" +
                                                            $"  Button: {e.Button}  Clicks:{e.Clicks}  Delta:{e.Delta}";
                            
                            my_clickedTask = ClickedTask.nulll;
                        }
                        break;
                    case MouseButtons.Right:
                        toolStripStatusLabelInfo.Text = $"x: {e.X}  y:{e.Y}  location:{e.Location}" +
                                                        $"  Button: {e.Button}  Clicks:{e.Clicks}  Delta:{e.Delta}";
                        break;

                }

            }
        }

        private void btnDynamic_click(object sender, EventArgs e)
        {
            Equipment tttEquipment;
            tttEquipment = _AllEquipments.Where(x => x.XOffset == (sender as Button).Location.X &&
                                                     x.YOffset == (sender as Button).Location.Y)
                                               .FirstOrDefault();
            if (tttEquipment == null)
            {
                tttEquipment = new Equipment();
                tttEquipment.XOffset = (sender as Button).Location.X;
                tttEquipment.YOffset = (sender as Button).Location.Y;
                tttEquipment.Unit = _CurrentUnit;
                tttEquipment.EquipmentType = _CurrentEquipmentType;

            }
            frmEquipment f = new frmEquipment(tttEquipment);
            f.Location = new Point(10, 10);
            f.ShowDialog();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            my_clickedTask = ClickedTask.AddEquipment;
        }
    }
}
