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
    public partial class EquipmentControlBar : UserControl
    {
        public EquipmentControlBar(Equipment equipment = null)
        {
            InitializeComponent();
            if (equipment != null)
            {
                _equipment = equipment;
            }
        }

        private Equipment _equipment = new Equipment();
        public Equipment _Equipment
        {
            get { return _equipment; }
            set { _equipment = value; }
        }

        private void EquipmentBtn_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;
            pnlMain.Visible = !pnlMain.Visible;
            if (pnlMain.Visible)
            {
                this.Width = pnlMain.Width;// + EquipmentBtn.Width;
                this.Height = pnlMain.Height;
            }
            else
            {
                this.Width = EquipmentBtn.Width;
                this.Height = EquipmentBtn.Height;
            }
            //EquipmentBtn.Text = this.Top.ToString();
            //MessageBox.Show($"top: {this.Top}\nleft: {this.Left}");
        }

        private void EquipmentControl_Load(object sender, EventArgs e)
        {
            #region Binding
            equipmentBindingSource.DataSource = _equipment;
            equipmentBindingSource.ResetBindings(true);
            #endregion

            EquipmentBtn_Click(sender, e);

            pnlMain.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void EquipmentBtn_MouseDown(object sender, MouseEventArgs e)
        {
            this.Top = e.Y;
            this.Left = e.X;
        }

        private void EquipmentControl_Move(object sender, EventArgs e)
        {
            
        }

        public void _Move(int top1 = 10, int left1 = 10)
        {
            this.Top = top1;
            this.Left = left1;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
