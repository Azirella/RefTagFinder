using RefTagFinder.Classes.DataControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefTagFinder.Forms.User_Controls

{
    public partial class EquipmentControl : UserControl
    {
        public EquipmentControl(Equipment equipment = null)
        {
            InitializeComponent();
            if (equipment != null)
            {
                _equipment = equipment;
            }
        }

        Equipment _equipment = new Equipment();

        private void EquipmentBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            if (panel1.Visible)
            {
                this.Width = panel1.Width;// + EquipmentBtn.Width;
                this.Height = panel1.Height;
            }
            else
            {
                this.Width = EquipmentBtn.Width;
                this.Height = EquipmentBtn.Height;
            }
            EquipmentBtn.Text = this.Top.ToString();
        }

        private void EquipmentControl_Load(object sender, EventArgs e)
        {
            #region Binding
            equipmentBindingSource.DataSource = _equipment;
            equipmentBindingSource.ResetBindings(true);
            #endregion

            EquipmentBtn_Click(sender, e);

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void EquipmentBtn_MouseDown(object sender, MouseEventArgs e)
        {
            this.Top = e.Y;
            this.Left = e.X;
        }
    }
}
