namespace RefTagFinder
{
    partial class frmTagFinder
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
            System.Windows.Forms.Label unitNameLabel;
            System.Windows.Forms.Label equipmentNameLabel;
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnEditEquipmentType = new System.Windows.Forms.Button();
            this.equipmentNameComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddEquipmentType = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.unitNameComboBox = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolsPnl = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.unitImagePictureBox = new System.Windows.Forms.PictureBox();
            this.test_Timer = new System.Windows.Forms.Timer(this.components);
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            unitNameLabel = new System.Windows.Forms.Label();
            equipmentNameLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // unitNameLabel
            // 
            unitNameLabel.AutoSize = true;
            unitNameLabel.Location = new System.Drawing.Point(12, 10);
            unitNameLabel.Name = "unitNameLabel";
            unitNameLabel.Size = new System.Drawing.Size(101, 23);
            unitNameLabel.TabIndex = 21;
            unitNameLabel.Text = "Unit Name:";
            // 
            // equipmentNameLabel
            // 
            equipmentNameLabel.AutoSize = true;
            equipmentNameLabel.Location = new System.Drawing.Point(457, 7);
            equipmentNameLabel.Name = "equipmentNameLabel";
            equipmentNameLabel.Size = new System.Drawing.Size(155, 23);
            equipmentNameLabel.TabIndex = 24;
            equipmentNameLabel.Text = "Equipment Name:";
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
            this.btnExit.Location = new System.Drawing.Point(1109, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 37);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1165, 26);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabelInfo.Text = "toolStripStatusLabel1";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnEditEquipmentType);
            this.pnlTop.Controls.Add(equipmentNameLabel);
            this.pnlTop.Controls.Add(this.equipmentNameComboBox);
            this.pnlTop.Controls.Add(this.btnAddEquipmentType);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(unitNameLabel);
            this.pnlTop.Controls.Add(this.unitNameComboBox);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1165, 67);
            this.pnlTop.TabIndex = 20;
            // 
            // btnEditEquipmentType
            // 
            this.btnEditEquipmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnEditEquipmentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEquipmentType.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditEquipmentType.FlatAppearance.BorderSize = 0;
            this.btnEditEquipmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEquipmentType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEquipmentType.ForeColor = System.Drawing.Color.White;
            this.btnEditEquipmentType.Location = new System.Drawing.Point(872, 0);
            this.btnEditEquipmentType.Name = "btnEditEquipmentType";
            this.btnEditEquipmentType.Size = new System.Drawing.Size(60, 37);
            this.btnEditEquipmentType.TabIndex = 26;
            this.btnEditEquipmentType.Text = "Edit";
            this.btnEditEquipmentType.UseVisualStyleBackColor = false;
            this.btnEditEquipmentType.Click += new System.EventHandler(this.btnEditEquipmentType_Click);
            // 
            // equipmentNameComboBox
            // 
            this.equipmentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("DisplayMember", this.equipmentTypeBindingSource, "EquipmentName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.equipmentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ValueMember", this.equipmentTypeBindingSource, "EquipmentTypeID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.equipmentNameComboBox.FormattingEnabled = true;
            this.equipmentNameComboBox.Location = new System.Drawing.Point(618, 4);
            this.equipmentNameComboBox.Name = "equipmentNameComboBox";
            this.equipmentNameComboBox.Size = new System.Drawing.Size(184, 29);
            this.equipmentNameComboBox.TabIndex = 25;
            this.equipmentNameComboBox.SelectedIndexChanged += new System.EventHandler(this.equipmentNameComboBox_SelectedIndexChanged);
            // 
            // equipmentTypeBindingSource
            // 
            this.equipmentTypeBindingSource.DataSource = typeof(RefTagFinder.Classes.DataControl.EquipmentType);
            // 
            // btnAddEquipmentType
            // 
            this.btnAddEquipmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddEquipmentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEquipmentType.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddEquipmentType.FlatAppearance.BorderSize = 0;
            this.btnAddEquipmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipmentType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipmentType.ForeColor = System.Drawing.Color.White;
            this.btnAddEquipmentType.Location = new System.Drawing.Point(808, 0);
            this.btnAddEquipmentType.Name = "btnAddEquipmentType";
            this.btnAddEquipmentType.Size = new System.Drawing.Size(58, 37);
            this.btnAddEquipmentType.TabIndex = 24;
            this.btnAddEquipmentType.Text = "Add";
            this.btnAddEquipmentType.UseVisualStyleBackColor = false;
            this.btnAddEquipmentType.Click += new System.EventHandler(this.btnAddEquipmentType_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(391, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 37);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // unitNameComboBox
            // 
            this.unitNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.unitBindingSource, "UnitID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.unitNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "UnitName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.unitNameComboBox.FormattingEnabled = true;
            this.unitNameComboBox.Location = new System.Drawing.Point(119, 7);
            this.unitNameComboBox.Name = "unitNameComboBox";
            this.unitNameComboBox.Size = new System.Drawing.Size(202, 29);
            this.unitNameComboBox.TabIndex = 22;
            this.unitNameComboBox.SelectedIndexChanged += new System.EventHandler(this.unitNameComboBox_SelectedIndexChanged);
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(RefTagFinder.Classes.DataControl.Unit);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(327, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 37);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1007, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(56, 37);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.lblTest);
            this.panel2.Controls.Add(this.toolsPnl);
            this.panel2.Controls.Add(this.unitImagePictureBox);
            this.panel2.Location = new System.Drawing.Point(12, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 441);
            this.panel2.TabIndex = 21;
            // 
            // toolsPnl
            // 
            this.toolsPnl.BackColor = System.Drawing.Color.Purple;
            this.toolsPnl.Controls.Add(this.btnAddEquipment);
            this.toolsPnl.Controls.Add(this.btnRefresh);
            this.toolsPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolsPnl.Location = new System.Drawing.Point(1052, 0);
            this.toolsPnl.Name = "toolsPnl";
            this.toolsPnl.Size = new System.Drawing.Size(89, 441);
            this.toolsPnl.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.Location = new System.Drawing.Point(0, 408);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 33);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // unitImagePictureBox
            // 
            this.unitImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.unitImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.unitBindingSource, "ImagePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.unitImagePictureBox.Location = new System.Drawing.Point(4, 6);
            this.unitImagePictureBox.Name = "unitImagePictureBox";
            this.unitImagePictureBox.Size = new System.Drawing.Size(305, 156);
            this.unitImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.unitImagePictureBox.TabIndex = 0;
            this.unitImagePictureBox.TabStop = false;
            this.unitImagePictureBox.Click += new System.EventHandler(this.unitImagePictureBox_Click);
            this.unitImagePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.unitImagePictureBox_MouseDown);
            // 
            // test_Timer
            // 
            this.test_Timer.Interval = 2000;
            this.test_Timer.Tick += new System.EventHandler(this.test_Timer_Tick);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEquipment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddEquipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEquipment.FlatAppearance.BorderSize = 0;
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipment.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.ForeColor = System.Drawing.Color.White;
            this.btnAddEquipment.Location = new System.Drawing.Point(0, 0);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(89, 37);
            this.btnAddEquipment.TabIndex = 27;
            this.btnAddEquipment.Text = "Add";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(987, 58);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(59, 23);
            this.lblTest.TabIndex = 28;
            this.lblTest.Text = "label1";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.Yellow;
            this.btnCopy.Location = new System.Drawing.Point(976, 125);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(70, 37);
            this.btnCopy.TabIndex = 29;
            this.btnCopy.Text = "1111";
            this.btnCopy.UseVisualStyleBackColor = false;
            // 
            // frmTagFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1165, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTagFinder";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tag Finder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTagFinder_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolsPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox unitImagePictureBox;
        private System.Windows.Forms.ComboBox unitNameComboBox;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.Panel toolsPnl;
        //private Forms.User_Controls.EquipmentControl equipmentControl1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Timer test_Timer;
        private System.Windows.Forms.Button btnAddEquipmentType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox equipmentNameComboBox;
        private System.Windows.Forms.BindingSource equipmentTypeBindingSource;
        private System.Windows.Forms.Button btnEditEquipmentType;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnAddEquipment;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCopy;
    }
}