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
using static pdf2image.SautinSoft.PdfFocus.Program;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using Dapper;
namespace RefTagFinder.Forms
{
    public partial class FrmAddEquipmentType : Form
    {
        EquipmentType _mainFormEquipmentType = new EquipmentType();

        public FrmAddEquipmentType(EquipmentType equipmentType = null)
        {
            InitializeComponent();
            if (equipmentType != null)
            {
                _mainFormEquipmentType = equipmentType;
            }
            
        }

        private void FrmTagFinder_Load(object sender, EventArgs e)
        {
            
            #region Binding
            equipmentTypeBindingSource.DataSource = _mainFormEquipmentType;
            equipmentTypeBindingSource.ResetBindings(true); 
            #endregion
            
           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
