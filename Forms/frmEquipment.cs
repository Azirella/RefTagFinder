using Dapper;
using RefTagFinder.Classes.DataControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefTagFinder.Forms
{
    public partial class frmEquipment : Form
    {
        Equipment _mainFormEquipment = new Equipment();
        Unit _CurrentUnit;
        EquipmentType _CurrentEquipmentType;

        List<Unit> _AllUnins;
        List<EquipmentType> _AllEquipmentTypes;
        List<Equipment> _AllEquipments;

        List<Equipment> isDatums1 = new List<Equipment>();
        isValidUintArea isValidUintArea1 = new isValidUintArea();

        bool firstLoad = true;

        struct isValidUintArea
        {
            public int top;
            public int bottom;
            public int left;
            public int right;
            public bool isValid 
            {
                get 
                {
                    bool returnValue = false;
                    if (top != bottom &&
                        right != left
                        )
                    {
                        returnValue = true;
                    }
                    return returnValue;
                }
            }
        }

        public frmEquipment(Equipment _FormEquipment = null)
        {
            InitializeComponent();
            if (_FormEquipment !=null)
            {
                _mainFormEquipment = _FormEquipment;
            }
        }
        private void frmEquipment_Load(object sender, EventArgs e)
        {
            #region Binding
            equipmentBindingSource.DataSource = _mainFormEquipment;
            equipmentBindingSource.ResetBindings(true);
            #endregion

            if (firstLoad)
            {
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

                

                firstLoad = false;
            }


            isDatums1 = isDatums();
            _mainFormEquipment.IsDatum = false;
            if (isDatums1.Count() < 3)
            {
                _mainFormEquipment.IsDatum = true;
            }

            if (isDatums1.Count() > 0)
            {
                isValidUintArea1.top = isDatums1.Min(x => x.YOffset).Value;
                isValidUintArea1.bottom = isDatums1.Max(x => x.YOffset).Value;
                isValidUintArea1.left = isDatums1.Min(x => x.XOffset).Value;
                isValidUintArea1.right = isDatums1.Max(x => x.XOffset).Value;
            }

            #region comboBoxes_Binding
            unitNameComboBox.DataSource =
                _AllUnins.OrderBy(x => x.UnitName).Select(x => x.UnitName).ToList();
            
             equipmentNameComboBox.DataSource =
                _AllEquipmentTypes.OrderBy(x => x.EquipmentName).Select(x => x.EquipmentName).ToList();


            unitNameComboBox.Text = (_AllUnins.Where(x => x.UnitID == _mainFormEquipment.UnitID).FirstOrDefault())
                .UnitName;
            equipmentNameComboBox.Text = (_AllEquipmentTypes.Where(x => x.EquipmentTypeID == _mainFormEquipment.EquipmentTypeID).FirstOrDefault())
                .EquipmentName;

            this.unitNameComboBox.SelectedIndexChanged += new EventHandler(this.unitNameComboBox_SelectedIndexChanged);
            this.equipmentNameComboBox.SelectedIndexChanged += new EventHandler(this.equipmentNameComboBox_SelectedIndexChanged);
            #endregion

        }

        private List<Equipment> isDatums()
        {
            return _AllEquipments.Where(x => x.IsDatum == true && x.UnitID == _mainFormEquipment.UnitID).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mainFormEquipment.IsDatum == false && isValidUintArea1.isValid)
                {
                    _mainFormEquipment.Latitude = "0";
                    _mainFormEquipment.Longitude = "0";

                }
                using (IDbConnection cnn = new SqlConnection(HelperStatic.LoadConnectionString()))
                {
                    string sql = $@"DELETE FROM  Equipment  WHERE EquipmentID = {_mainFormEquipment.EquipmentID}";
                    cnn.Execute(sql);

                    //INSERT INTO [dbo].[Equipment] (EquipmentID ,EquipmentTypeID,UnitID,Latitude,Longitude,XOffset,YOffset,IsDatum,Tag) VALUES (@EquipmentID ,@EquipmentTypeID2,@UnitID2,@Latitude,@Longitude,@XOffset,@YOffset,@IsDatum,@Tag)
                    sql = $@"INSERT INTO [dbo].[Equipment] (EquipmentTypeID,UnitID,Latitude,Longitude,XOffset,YOffset,IsDatum,Tag) "+
                          $@"VALUES (@EquipmentTypeID,@UnitID,@Latitude,@Longitude,@XOffset,@YOffset,@IsDatum,@Tag)";
                    cnn.Execute(sql, _mainFormEquipment);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void equipmentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 <= equipmentNameComboBox.SelectedIndex)
            {
                _CurrentEquipmentType = _AllEquipmentTypes.Where(x => x.EquipmentName == equipmentNameComboBox.Text).First();
                _mainFormEquipment.EquipmentTypeID = _CurrentEquipmentType.EquipmentTypeID;
                equipmentNameComboBox.Text = _CurrentEquipmentType.EquipmentName;
            }
            //formGeneralChange();
        }

        private void unitNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 <= unitNameComboBox.SelectedIndex)
            {
                _CurrentUnit = _AllUnins.Where(x => x.UnitName == unitNameComboBox.Text).First();
                _mainFormEquipment.UnitID = _CurrentUnit.UnitID;
                unitNameComboBox.Text = _CurrentUnit.UnitName;
            }
            //formGeneralChange();
        }

        private void formGeneralChange()
        {
            if (_CurrentUnit != null)
            {
                equipmentNameComboBox.Text = _CurrentEquipmentType.EquipmentName;
            }
            if (_CurrentEquipmentType != null)
            {
                unitNameComboBox.Text = _CurrentUnit.UnitName;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(HelperStatic.LoadConnectionString()))
                {
                    string sql = $@"DELETE FROM  Equipment  WHERE EquipmentID = {_mainFormEquipment.EquipmentID}";
                    cnn.Execute(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            this.Close();
        }
    }
}
