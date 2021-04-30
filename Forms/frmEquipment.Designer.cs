
namespace RefTagFinder.Forms
{
    partial class frmEquipment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tagLabel;
            System.Windows.Forms.Label equipmentNameLabel;
            System.Windows.Forms.Label unitNameLabel;
            System.Windows.Forms.Label isDatumLabel;
            System.Windows.Forms.Label latitudeLabel;
            System.Windows.Forms.Label longitudeLabel;
            System.Windows.Forms.Label xOffsetLabel;
            System.Windows.Forms.Label yOffsetLabel;
            System.Windows.Forms.Label equipmentIDLabel;
            System.Windows.Forms.Label equipmentTypeIDLabel;
            System.Windows.Forms.Label unitIDLabel;
            this.btnExit = new System.Windows.Forms.Button();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentNameComboBox = new System.Windows.Forms.ComboBox();
            this.unitNameComboBox = new System.Windows.Forms.ComboBox();
            this.isDatumCheckBox = new System.Windows.Forms.CheckBox();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.xOffsetTextBox = new System.Windows.Forms.TextBox();
            this.yOffsetTextBox = new System.Windows.Forms.TextBox();
            this.equipmentIDLabel1 = new System.Windows.Forms.Label();
            this.equipmentTypeIDLabel1 = new System.Windows.Forms.Label();
            this.unitIDLabel1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            tagLabel = new System.Windows.Forms.Label();
            equipmentNameLabel = new System.Windows.Forms.Label();
            unitNameLabel = new System.Windows.Forms.Label();
            isDatumLabel = new System.Windows.Forms.Label();
            latitudeLabel = new System.Windows.Forms.Label();
            longitudeLabel = new System.Windows.Forms.Label();
            xOffsetLabel = new System.Windows.Forms.Label();
            yOffsetLabel = new System.Windows.Forms.Label();
            equipmentIDLabel = new System.Windows.Forms.Label();
            equipmentTypeIDLabel = new System.Windows.Forms.Label();
            unitIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new System.Drawing.Point(10, 10);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(43, 23);
            tagLabel.TabIndex = 20;
            tagLabel.Text = "Tag:";
            // 
            // equipmentNameLabel
            // 
            equipmentNameLabel.AutoSize = true;
            equipmentNameLabel.Location = new System.Drawing.Point(10, 80);
            equipmentNameLabel.Name = "equipmentNameLabel";
            equipmentNameLabel.Size = new System.Drawing.Size(146, 23);
            equipmentNameLabel.TabIndex = 21;
            equipmentNameLabel.Text = "Equipment Type:";
            // 
            // unitNameLabel
            // 
            unitNameLabel.AutoSize = true;
            unitNameLabel.Location = new System.Drawing.Point(10, 115);
            unitNameLabel.Name = "unitNameLabel";
            unitNameLabel.Size = new System.Drawing.Size(101, 23);
            unitNameLabel.TabIndex = 22;
            unitNameLabel.Text = "Unit Name:";
            // 
            // isDatumLabel
            // 
            isDatumLabel.AutoSize = true;
            isDatumLabel.Location = new System.Drawing.Point(10, 45);
            isDatumLabel.Name = "isDatumLabel";
            isDatumLabel.Size = new System.Drawing.Size(87, 23);
            isDatumLabel.TabIndex = 23;
            isDatumLabel.Text = "Is Datum:";
            // 
            // latitudeLabel
            // 
            latitudeLabel.AutoSize = true;
            latitudeLabel.Location = new System.Drawing.Point(10, 150);
            latitudeLabel.Name = "latitudeLabel";
            latitudeLabel.Size = new System.Drawing.Size(82, 23);
            latitudeLabel.TabIndex = 24;
            latitudeLabel.Text = "Latitude:";
            // 
            // longitudeLabel
            // 
            longitudeLabel.AutoSize = true;
            longitudeLabel.Location = new System.Drawing.Point(10, 185);
            longitudeLabel.Name = "longitudeLabel";
            longitudeLabel.Size = new System.Drawing.Size(97, 23);
            longitudeLabel.TabIndex = 25;
            longitudeLabel.Text = "Longitude:";
            // 
            // xOffsetLabel
            // 
            xOffsetLabel.AutoSize = true;
            xOffsetLabel.Location = new System.Drawing.Point(10, 220);
            xOffsetLabel.Name = "xOffsetLabel";
            xOffsetLabel.Size = new System.Drawing.Size(76, 23);
            xOffsetLabel.TabIndex = 26;
            xOffsetLabel.Text = "XOffset:";
            // 
            // yOffsetLabel
            // 
            yOffsetLabel.AutoSize = true;
            yOffsetLabel.Location = new System.Drawing.Point(10, 255);
            yOffsetLabel.Name = "yOffsetLabel";
            yOffsetLabel.Size = new System.Drawing.Size(75, 23);
            yOffsetLabel.TabIndex = 27;
            yOffsetLabel.Text = "YOffset:";
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(10, 290);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(126, 23);
            equipmentIDLabel.TabIndex = 28;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // equipmentTypeIDLabel
            // 
            equipmentTypeIDLabel.AutoSize = true;
            equipmentTypeIDLabel.Location = new System.Drawing.Point(10, 320);
            equipmentTypeIDLabel.Name = "equipmentTypeIDLabel";
            equipmentTypeIDLabel.Size = new System.Drawing.Size(169, 23);
            equipmentTypeIDLabel.TabIndex = 29;
            equipmentTypeIDLabel.Text = "Equipment Type ID:";
            // 
            // unitIDLabel
            // 
            unitIDLabel.AutoSize = true;
            unitIDLabel.Location = new System.Drawing.Point(10, 355);
            unitIDLabel.Name = "unitIDLabel";
            unitIDLabel.Size = new System.Drawing.Size(72, 23);
            unitIDLabel.TabIndex = 30;
            unitIDLabel.Text = "Unit ID:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(402, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 37);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tagTextBox
            // 
            this.tagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Tag", true));
            this.tagTextBox.Location = new System.Drawing.Point(183, 7);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(214, 29);
            this.tagTextBox.TabIndex = 21;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(RefTagFinder.Classes.DataControl.Equipment);
            // 
            // equipmentNameComboBox
            // 
            this.equipmentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentType.EquipmentName", true));
            this.equipmentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ValueMember", this.equipmentBindingSource, "EquipmentTypeID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.equipmentNameComboBox.DataSource = this.equipmentBindingSource;
            this.equipmentNameComboBox.FormattingEnabled = true;
            this.equipmentNameComboBox.Location = new System.Drawing.Point(183, 76);
            this.equipmentNameComboBox.Name = "equipmentNameComboBox";
            this.equipmentNameComboBox.Size = new System.Drawing.Size(214, 29);
            this.equipmentNameComboBox.TabIndex = 22;
            this.equipmentNameComboBox.SelectedIndexChanged += new System.EventHandler(this.equipmentNameComboBox_SelectedIndexChanged);
            // 
            // unitNameComboBox
            // 
            this.unitNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Unit.UnitName", true));
            this.unitNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ValueMember", this.equipmentBindingSource, "UnitID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.unitNameComboBox.FormattingEnabled = true;
            this.unitNameComboBox.Location = new System.Drawing.Point(183, 111);
            this.unitNameComboBox.Name = "unitNameComboBox";
            this.unitNameComboBox.Size = new System.Drawing.Size(214, 29);
            this.unitNameComboBox.TabIndex = 23;
            this.unitNameComboBox.SelectedIndexChanged += new System.EventHandler(this.unitNameComboBox_SelectedIndexChanged);
            // 
            // isDatumCheckBox
            // 
            this.isDatumCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.equipmentBindingSource, "IsDatum", true));
            this.isDatumCheckBox.Location = new System.Drawing.Point(183, 46);
            this.isDatumCheckBox.Name = "isDatumCheckBox";
            this.isDatumCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDatumCheckBox.TabIndex = 24;
            this.isDatumCheckBox.Text = "Is Datum";
            this.isDatumCheckBox.UseVisualStyleBackColor = true;
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Latitude", true));
            this.latitudeTextBox.Location = new System.Drawing.Point(183, 147);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(214, 29);
            this.latitudeTextBox.TabIndex = 25;
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Longitude", true));
            this.longitudeTextBox.Location = new System.Drawing.Point(183, 182);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(214, 29);
            this.longitudeTextBox.TabIndex = 26;
            // 
            // xOffsetTextBox
            // 
            this.xOffsetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "XOffset", true));
            this.xOffsetTextBox.Location = new System.Drawing.Point(183, 217);
            this.xOffsetTextBox.Name = "xOffsetTextBox";
            this.xOffsetTextBox.Size = new System.Drawing.Size(214, 29);
            this.xOffsetTextBox.TabIndex = 27;
            // 
            // yOffsetTextBox
            // 
            this.yOffsetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "YOffset", true));
            this.yOffsetTextBox.Location = new System.Drawing.Point(183, 252);
            this.yOffsetTextBox.Name = "yOffsetTextBox";
            this.yOffsetTextBox.Size = new System.Drawing.Size(214, 29);
            this.yOffsetTextBox.TabIndex = 28;
            // 
            // equipmentIDLabel1
            // 
            this.equipmentIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentID", true));
            this.equipmentIDLabel1.Location = new System.Drawing.Point(179, 290);
            this.equipmentIDLabel1.Name = "equipmentIDLabel1";
            this.equipmentIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.equipmentIDLabel1.TabIndex = 29;
            this.equipmentIDLabel1.Text = "label1";
            // 
            // equipmentTypeIDLabel1
            // 
            this.equipmentTypeIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentTypeID", true));
            this.equipmentTypeIDLabel1.Location = new System.Drawing.Point(179, 322);
            this.equipmentTypeIDLabel1.Name = "equipmentTypeIDLabel1";
            this.equipmentTypeIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.equipmentTypeIDLabel1.TabIndex = 30;
            this.equipmentTypeIDLabel1.Text = "label1";
            // 
            // unitIDLabel1
            // 
            this.unitIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "UnitID", true));
            this.unitIDLabel1.Location = new System.Drawing.Point(179, 356);
            this.unitIDLabel1.Name = "unitIDLabel1";
            this.unitIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.unitIDLabel1.TabIndex = 31;
            this.unitIDLabel1.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(393, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 37);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(303, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 37);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 387);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(457, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // frmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(457, 412);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(unitIDLabel);
            this.Controls.Add(this.unitIDLabel1);
            this.Controls.Add(equipmentTypeIDLabel);
            this.Controls.Add(this.equipmentTypeIDLabel1);
            this.Controls.Add(equipmentIDLabel);
            this.Controls.Add(this.equipmentIDLabel1);
            this.Controls.Add(yOffsetLabel);
            this.Controls.Add(this.yOffsetTextBox);
            this.Controls.Add(xOffsetLabel);
            this.Controls.Add(this.xOffsetTextBox);
            this.Controls.Add(longitudeLabel);
            this.Controls.Add(this.longitudeTextBox);
            this.Controls.Add(latitudeLabel);
            this.Controls.Add(this.latitudeTextBox);
            this.Controls.Add(isDatumLabel);
            this.Controls.Add(this.isDatumCheckBox);
            this.Controls.Add(unitNameLabel);
            this.Controls.Add(this.unitNameComboBox);
            this.Controls.Add(equipmentNameLabel);
            this.Controls.Add(this.equipmentNameComboBox);
            this.Controls.Add(tagLabel);
            this.Controls.Add(this.tagTextBox);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "frmEquipment";
            this.Opacity = 0.9D;
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.ComboBox equipmentNameComboBox;
        private System.Windows.Forms.ComboBox unitNameComboBox;
        private System.Windows.Forms.CheckBox isDatumCheckBox;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.TextBox xOffsetTextBox;
        private System.Windows.Forms.TextBox yOffsetTextBox;
        private System.Windows.Forms.Label equipmentIDLabel1;
        private System.Windows.Forms.Label equipmentTypeIDLabel1;
        private System.Windows.Forms.Label unitIDLabel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}