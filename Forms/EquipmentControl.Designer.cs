
namespace RefTagFinder.Forms
{
    partial class EquipmentControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label equipmentIDLabel;
            System.Windows.Forms.Label equipmentNameLabel;
            System.Windows.Forms.Label equipmentTypeIDLabel;
            System.Windows.Forms.Label isDatumLabel;
            System.Windows.Forms.Label latitudeLabel;
            System.Windows.Forms.Label longitudeLabel;
            System.Windows.Forms.Label tagLabel;
            System.Windows.Forms.Label unitNameLabel;
            System.Windows.Forms.Label unitIDLabel;
            System.Windows.Forms.Label xOffsetLabel;
            System.Windows.Forms.Label yOffsetLabel;
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentIDLabel1 = new System.Windows.Forms.Label();
            this.equipmentNameComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentTypeIDLabel1 = new System.Windows.Forms.Label();
            this.isDatumRadioButton = new System.Windows.Forms.RadioButton();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.unitNameComboBox = new System.Windows.Forms.ComboBox();
            this.unitIDLabel1 = new System.Windows.Forms.Label();
            this.xOffsetTextBox = new System.Windows.Forms.TextBox();
            this.yOffsetTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EquipmentBtn = new System.Windows.Forms.Button();
            equipmentIDLabel = new System.Windows.Forms.Label();
            equipmentNameLabel = new System.Windows.Forms.Label();
            equipmentTypeIDLabel = new System.Windows.Forms.Label();
            isDatumLabel = new System.Windows.Forms.Label();
            latitudeLabel = new System.Windows.Forms.Label();
            longitudeLabel = new System.Windows.Forms.Label();
            tagLabel = new System.Windows.Forms.Label();
            unitNameLabel = new System.Windows.Forms.Label();
            unitIDLabel = new System.Windows.Forms.Label();
            xOffsetLabel = new System.Windows.Forms.Label();
            yOffsetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(RefTagFinder.Classes.DataControl.Equipment);
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(21, 15);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(96, 17);
            equipmentIDLabel.TabIndex = 1;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // equipmentIDLabel1
            // 
            this.equipmentIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentID", true));
            this.equipmentIDLabel1.Location = new System.Drawing.Point(180, 15);
            this.equipmentIDLabel1.Name = "equipmentIDLabel1";
            this.equipmentIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.equipmentIDLabel1.TabIndex = 2;
            this.equipmentIDLabel1.Text = "label1";
            // 
            // equipmentNameLabel
            // 
            equipmentNameLabel.AutoSize = true;
            equipmentNameLabel.Location = new System.Drawing.Point(21, 53);
            equipmentNameLabel.Name = "equipmentNameLabel";
            equipmentNameLabel.Size = new System.Drawing.Size(120, 17);
            equipmentNameLabel.TabIndex = 2;
            equipmentNameLabel.Text = "Equipment Name:";
            // 
            // equipmentNameComboBox
            // 
            this.equipmentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentType.EquipmentName", true));
            this.equipmentNameComboBox.FormattingEnabled = true;
            this.equipmentNameComboBox.Location = new System.Drawing.Point(180, 46);
            this.equipmentNameComboBox.Name = "equipmentNameComboBox";
            this.equipmentNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.equipmentNameComboBox.TabIndex = 3;
            // 
            // equipmentTypeIDLabel
            // 
            equipmentTypeIDLabel.AutoSize = true;
            equipmentTypeIDLabel.Location = new System.Drawing.Point(21, 86);
            equipmentTypeIDLabel.Name = "equipmentTypeIDLabel";
            equipmentTypeIDLabel.Size = new System.Drawing.Size(132, 17);
            equipmentTypeIDLabel.TabIndex = 4;
            equipmentTypeIDLabel.Text = "Equipment Type ID:";
            // 
            // equipmentTypeIDLabel1
            // 
            this.equipmentTypeIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentTypeID", true));
            this.equipmentTypeIDLabel1.Location = new System.Drawing.Point(180, 86);
            this.equipmentTypeIDLabel1.Name = "equipmentTypeIDLabel1";
            this.equipmentTypeIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.equipmentTypeIDLabel1.TabIndex = 5;
            this.equipmentTypeIDLabel1.Text = "label1";
            // 
            // isDatumLabel
            // 
            isDatumLabel.AutoSize = true;
            isDatumLabel.Location = new System.Drawing.Point(21, 123);
            isDatumLabel.Name = "isDatumLabel";
            isDatumLabel.Size = new System.Drawing.Size(67, 17);
            isDatumLabel.TabIndex = 6;
            isDatumLabel.Text = "Is Datum:";
            // 
            // isDatumRadioButton
            // 
            this.isDatumRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.equipmentBindingSource, "IsDatum", true));
            this.isDatumRadioButton.Location = new System.Drawing.Point(180, 119);
            this.isDatumRadioButton.Name = "isDatumRadioButton";
            this.isDatumRadioButton.Size = new System.Drawing.Size(104, 24);
            this.isDatumRadioButton.TabIndex = 7;
            this.isDatumRadioButton.TabStop = true;
            this.isDatumRadioButton.Text = "radioButton1";
            this.isDatumRadioButton.UseVisualStyleBackColor = true;
            // 
            // latitudeLabel
            // 
            latitudeLabel.AutoSize = true;
            latitudeLabel.Location = new System.Drawing.Point(21, 161);
            latitudeLabel.Name = "latitudeLabel";
            latitudeLabel.Size = new System.Drawing.Size(63, 17);
            latitudeLabel.TabIndex = 8;
            latitudeLabel.Text = "Latitude:";
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Latitude", true));
            this.latitudeTextBox.Location = new System.Drawing.Point(180, 158);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(100, 22);
            this.latitudeTextBox.TabIndex = 9;
            // 
            // longitudeLabel
            // 
            longitudeLabel.AutoSize = true;
            longitudeLabel.Location = new System.Drawing.Point(21, 198);
            longitudeLabel.Name = "longitudeLabel";
            longitudeLabel.Size = new System.Drawing.Size(75, 17);
            longitudeLabel.TabIndex = 10;
            longitudeLabel.Text = "Longitude:";
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Longitude", true));
            this.longitudeTextBox.Location = new System.Drawing.Point(180, 195);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(100, 22);
            this.longitudeTextBox.TabIndex = 11;
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new System.Drawing.Point(21, 235);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(37, 17);
            tagLabel.TabIndex = 12;
            tagLabel.Text = "Tag:";
            // 
            // tagTextBox
            // 
            this.tagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Tag", true));
            this.tagTextBox.Location = new System.Drawing.Point(180, 232);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(100, 22);
            this.tagTextBox.TabIndex = 13;
            // 
            // unitNameLabel
            // 
            unitNameLabel.AutoSize = true;
            unitNameLabel.Location = new System.Drawing.Point(21, 277);
            unitNameLabel.Name = "unitNameLabel";
            unitNameLabel.Size = new System.Drawing.Size(78, 17);
            unitNameLabel.TabIndex = 14;
            unitNameLabel.Text = "Unit Name:";
            // 
            // unitNameComboBox
            // 
            this.unitNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Unit.UnitName", true));
            this.unitNameComboBox.FormattingEnabled = true;
            this.unitNameComboBox.Location = new System.Drawing.Point(180, 274);
            this.unitNameComboBox.Name = "unitNameComboBox";
            this.unitNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.unitNameComboBox.TabIndex = 15;
            // 
            // unitIDLabel
            // 
            unitIDLabel.AutoSize = true;
            unitIDLabel.Location = new System.Drawing.Point(21, 315);
            unitIDLabel.Name = "unitIDLabel";
            unitIDLabel.Size = new System.Drawing.Size(54, 17);
            unitIDLabel.TabIndex = 16;
            unitIDLabel.Text = "Unit ID:";
            // 
            // unitIDLabel1
            // 
            this.unitIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "UnitID", true));
            this.unitIDLabel1.Location = new System.Drawing.Point(180, 315);
            this.unitIDLabel1.Name = "unitIDLabel1";
            this.unitIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.unitIDLabel1.TabIndex = 17;
            this.unitIDLabel1.Text = "label1";
            // 
            // xOffsetLabel
            // 
            xOffsetLabel.AutoSize = true;
            xOffsetLabel.Location = new System.Drawing.Point(21, 357);
            xOffsetLabel.Name = "xOffsetLabel";
            xOffsetLabel.Size = new System.Drawing.Size(59, 17);
            xOffsetLabel.TabIndex = 18;
            xOffsetLabel.Text = "XOffset:";
            // 
            // xOffsetTextBox
            // 
            this.xOffsetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "XOffset", true));
            this.xOffsetTextBox.Location = new System.Drawing.Point(180, 354);
            this.xOffsetTextBox.Name = "xOffsetTextBox";
            this.xOffsetTextBox.Size = new System.Drawing.Size(100, 22);
            this.xOffsetTextBox.TabIndex = 19;
            // 
            // yOffsetLabel
            // 
            yOffsetLabel.AutoSize = true;
            yOffsetLabel.Location = new System.Drawing.Point(21, 397);
            yOffsetLabel.Name = "yOffsetLabel";
            yOffsetLabel.Size = new System.Drawing.Size(59, 17);
            yOffsetLabel.TabIndex = 20;
            yOffsetLabel.Text = "YOffset:";
            // 
            // yOffsetTextBox
            // 
            this.yOffsetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "YOffset", true));
            this.yOffsetTextBox.Location = new System.Drawing.Point(180, 394);
            this.yOffsetTextBox.Name = "yOffsetTextBox";
            this.yOffsetTextBox.Size = new System.Drawing.Size(100, 22);
            this.yOffsetTextBox.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(equipmentIDLabel);
            this.panel1.Controls.Add(yOffsetLabel);
            this.panel1.Controls.Add(this.equipmentIDLabel1);
            this.panel1.Controls.Add(this.yOffsetTextBox);
            this.panel1.Controls.Add(this.equipmentNameComboBox);
            this.panel1.Controls.Add(xOffsetLabel);
            this.panel1.Controls.Add(equipmentNameLabel);
            this.panel1.Controls.Add(this.xOffsetTextBox);
            this.panel1.Controls.Add(this.equipmentTypeIDLabel1);
            this.panel1.Controls.Add(unitIDLabel);
            this.panel1.Controls.Add(equipmentTypeIDLabel);
            this.panel1.Controls.Add(this.unitIDLabel1);
            this.panel1.Controls.Add(this.isDatumRadioButton);
            this.panel1.Controls.Add(unitNameLabel);
            this.panel1.Controls.Add(isDatumLabel);
            this.panel1.Controls.Add(this.unitNameComboBox);
            this.panel1.Controls.Add(this.latitudeTextBox);
            this.panel1.Controls.Add(tagLabel);
            this.panel1.Controls.Add(latitudeLabel);
            this.panel1.Controls.Add(this.tagTextBox);
            this.panel1.Controls.Add(this.longitudeTextBox);
            this.panel1.Controls.Add(longitudeLabel);
            this.panel1.Location = new System.Drawing.Point(14, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 437);
            this.panel1.TabIndex = 22;
            // 
            // EquipmentBtn
            // 
            this.EquipmentBtn.Location = new System.Drawing.Point(0, 0);
            this.EquipmentBtn.Name = "EquipmentBtn";
            this.EquipmentBtn.Size = new System.Drawing.Size(31, 23);
            this.EquipmentBtn.TabIndex = 23;
            this.EquipmentBtn.Text = "X";
            this.EquipmentBtn.UseVisualStyleBackColor = true;
            this.EquipmentBtn.Click += new System.EventHandler(this.EquipmentBtn_Click);
            this.EquipmentBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EquipmentBtn_MouseDown);
            // 
            // EquipmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EquipmentBtn);
            this.Controls.Add(this.panel1);
            this.Name = "EquipmentControl";
            this.Size = new System.Drawing.Size(353, 437);
            this.Load += new System.EventHandler(this.EquipmentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.Label equipmentIDLabel1;
        private System.Windows.Forms.ComboBox equipmentNameComboBox;
        private System.Windows.Forms.Label equipmentTypeIDLabel1;
        private System.Windows.Forms.RadioButton isDatumRadioButton;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.ComboBox unitNameComboBox;
        private System.Windows.Forms.Label unitIDLabel1;
        private System.Windows.Forms.TextBox xOffsetTextBox;
        private System.Windows.Forms.TextBox yOffsetTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EquipmentBtn;
    }
}
