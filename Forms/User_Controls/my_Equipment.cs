using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefTagFinder.Forms.User_Controls
{
    public class My_Equipment : Button
    {
        public My_Equipment(IContainer container, EquipmentControl equipmentControl = null)
        {
            container.Add(this);

            if (equipmentControl != null)
            {
                My_equipmentControl = equipmentControl;
                My_equipmentControl.Top = this.Top;
                My_equipmentControl.Left = this.Left + this.Width;
            }
        }
        public My_Equipment(EquipmentControl equipmentControl = null)
        {
            if (equipmentControl != null)
            {
                My_equipmentControl = equipmentControl;
                My_equipmentControl.Top = this.Top;
                My_equipmentControl.Left = this.Left + this.Width;
            }
        }
        public bool IsValid 
        {
            get
            {
                bool returnedValue = false;

                return returnedValue;
            }
        }

        private EquipmentControl my_equipmentControl;
        public EquipmentControl My_equipmentControl 
        {
            get 
            { 
                return my_equipmentControl; 
            }
            set 
            {
                my_equipmentControl = value; 
            }
        }

        //this.Click += new System.EventHandler(this.btn_Click);
        public void btn_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}
