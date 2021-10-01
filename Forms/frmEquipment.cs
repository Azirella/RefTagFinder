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
        //Unit _CurrentUnit;
        //EquipmentType _CurrentEquipmentType;

        List<Unit> _AllUnins;
        List<EquipmentType> _AllEquipmentTypes;
        List<Equipment> _AllEquipments;

        List<Equipment> isDatums1 = new List<Equipment>();
        isValidUintArea isValidUintArea1 = new isValidUintArea();

        bool firstLoad = true;

        public struct isValidUintArea
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
            public string topLongitude;
            public string bottomLongitude;
            public string lefLatitudet;
            public string rightLatitude;
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

                firstLoad = false;
            }


            isDatums1 = isDatums();

            if (isDatums1.Count() > 0)
            {
                isValidUintArea1.top = isDatums1.Min(x => x.YOffset).Value;
                isValidUintArea1.bottom = isDatums1.Max(x => x.YOffset).Value;
                isValidUintArea1.left = isDatums1.Min(x => x.XOffset).Value;
                isValidUintArea1.right = isDatums1.Max(x => x.XOffset).Value;

                if (_mainFormEquipment.IsDatum != true)
                {
                    if (!isValidUintArea1.isValid)
                    {
                        _mainFormEquipment.IsDatum = true;
                    }
                    else
                    {
                        _mainFormEquipment.IsDatum = false;
                        _mainFormEquipment.XPercent = (double)(_mainFormEquipment.XOffset - isValidUintArea1.left) /
                            (double)(isValidUintArea1.right - isValidUintArea1.left) * 100;
                        _mainFormEquipment.YPercent = (double)(_mainFormEquipment.YOffset - isValidUintArea1.top) /
                            (double)(isValidUintArea1.bottom - isValidUintArea1.top) * 100;

                        isValidUintArea1.topLongitude = isDatums1.FirstOrDefault(c => c.YOffset == isValidUintArea1.top).Longitude;
                        isValidUintArea1.bottomLongitude = isDatums1.FirstOrDefault(c => c.YOffset == isValidUintArea1.bottom).Longitude;
                        isValidUintArea1.lefLatitudet = isDatums1.FirstOrDefault(c => c.XOffset == isValidUintArea1.left).Latitude;
                        isValidUintArea1.rightLatitude = isDatums1.FirstOrDefault(c => c.XOffset == isValidUintArea1.right).Latitude;

                        _mainFormEquipment.Longitude =
                            CalculateLL(convertToDigit(isValidUintArea1.topLongitude),
                            convertToDigit(isValidUintArea1.bottomLongitude),
                            _mainFormEquipment.YPercent).ToString();
                        _mainFormEquipment.Latitude =
                            CalculateLL(convertToDigit(isValidUintArea1.lefLatitudet),
                            convertToDigit(isValidUintArea1.rightLatitude),
                            _mainFormEquipment.XPercent).ToString();
                    } 
                }
            }

            

        }

        public double CalculateLL(double v1, double v2, double? percent = 1)
        {
            return (double)(v1 + ((v2 - v1) / percent / 100));
        }

        public double convertToDigit(string LL)
        {
            try
            {
                string hhh = LL.Substring(0, 2) + LL.Substring(3, 2) + LL.Substring(6, 6);
                double returnValue;
                double.TryParse(hhh, out returnValue);
                return returnValue;
                
            }
            catch// (Exception ex)
            {
                double returnValue;
                double.TryParse(LL, out returnValue);
                return returnValue;
                //MessageBox.Show(ex.Message);
            }
            /*finally
            { return 0; }*/
            
            //return 0;
        }

        private List<Equipment> isDatums()
        {
            return _AllEquipments.Where(x => x.IsDatum == true && x.UnitID == _mainFormEquipment.UnitID).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(HelperStatic.LoadConnectionString()))
                {
                    string sql = $@"DELETE FROM  Equipment  WHERE EquipmentID = {_mainFormEquipment.EquipmentID}";
                    int deleted = cnn.Execute(sql);

                    //INSERT INTO [dbo].[Equipment] (EquipmentID ,EquipmentTypeID,UnitID,Latitude,Longitude,XOffset,YOffset,IsDatum,Tag) VALUES (@EquipmentID ,@EquipmentTypeID2,@UnitID2,@Latitude,@Longitude,@XOffset,@YOffset,@IsDatum,@Tag)
                    sql = $@"INSERT INTO [dbo].[Equipment] (EquipmentTypeID,UnitID,Latitude,Longitude,XOffset,YOffset,IsDatum,Tag) "+
                          $@"VALUES (@EquipmentTypeID,@UnitID,@Latitude,@Longitude,@XOffset,@YOffset,@IsDatum,@Tag)";
                    if (deleted > 0)
                    {
                        cnn.Execute(sql, _mainFormEquipment);
                    }
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
                //_CurrentEquipmentType = _AllEquipmentTypes.Where(x => x.EquipmentName == equipmentNameComboBox.Text).First();
                _mainFormEquipment.EquipmentType = _AllEquipmentTypes.Where(x => x.EquipmentName == equipmentNameComboBox.Text).First();
                /*int a = _CurrentEquipmentType.EquipmentTypeID;
                _mainFormEquipment.EquipmentTypeID = a;*/
                //equipmentNameComboBox.Text = _CurrentEquipmentType.EquipmentName;
            }
            //formGeneralChange();
        }

        private void unitNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 <= unitNameComboBox.SelectedIndex)
            {
                //_CurrentEquipmentType = _AllUnins.Where(x => x.UnitName == unitNameComboBox.Text).First();
                _mainFormEquipment.Unit = _AllUnins.Where(x => x.UnitName == unitNameComboBox.Text).First();
                /*int a = _CurrentEquipmentType.EquipmentTypeID;
                _mainFormEquipment.EquipmentTypeID = a;*/
                //unitNameComboBox.Text = _mainFormEquipment.Unit.UnitName;
            }

        }

        /*private void formGeneralChange()
        {
            if (_CurrentUnit != null)
            {
                equipmentNameComboBox.Text = _CurrentEquipmentType.EquipmentName;
            }
            if (_CurrentEquipmentType != null)
            {
                unitNameComboBox.Text = _CurrentUnit.UnitName;
            }

        }*/

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
