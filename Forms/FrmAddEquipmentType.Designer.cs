namespace RefTagFinder.Forms
{
    partial class FrmAddEquipmentType
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
            System.Windows.Forms.Label equipmentTypeIDLabel;
            System.Windows.Forms.Label equipmentNameLabel;
            System.Windows.Forms.Label x_Label;
            System.Windows.Forms.Label y_Label;
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.y_TextBox = new System.Windows.Forms.TextBox();
            this.x_TextBox = new System.Windows.Forms.TextBox();
            this.equipmentNameTextBox = new System.Windows.Forms.TextBox();
            this.equipmentTypeIDLabel1 = new System.Windows.Forms.Label();
            this.equipmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            equipmentTypeIDLabel = new System.Windows.Forms.Label();
            equipmentNameLabel = new System.Windows.Forms.Label();
            x_Label = new System.Windows.Forms.Label();
            y_Label = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentTypeIDLabel
            // 
            equipmentTypeIDLabel.AutoSize = true;
            equipmentTypeIDLabel.Location = new System.Drawing.Point(21, 12);
            equipmentTypeIDLabel.Name = "equipmentTypeIDLabel";
            equipmentTypeIDLabel.Size = new System.Drawing.Size(169, 23);
            equipmentTypeIDLabel.TabIndex = 0;
            equipmentTypeIDLabel.Text = "Equipment Type ID:";
            // 
            // equipmentNameLabel
            // 
            equipmentNameLabel.AutoSize = true;
            equipmentNameLabel.Location = new System.Drawing.Point(21, 46);
            equipmentNameLabel.Name = "equipmentNameLabel";
            equipmentNameLabel.Size = new System.Drawing.Size(155, 23);
            equipmentNameLabel.TabIndex = 2;
            equipmentNameLabel.Text = "Equipment Name:";
            // 
            // x_Label
            // 
            x_Label.AutoSize = true;
            x_Label.Location = new System.Drawing.Point(21, 82);
            x_Label.Name = "x_Label";
            x_Label.Size = new System.Drawing.Size(31, 23);
            x_Label.TabIndex = 4;
            x_Label.Text = "X :";
            // 
            // y_Label
            // 
            y_Label.AutoSize = true;
            y_Label.Location = new System.Drawing.Point(21, 117);
            y_Label.Name = "y_Label";
            y_Label.Size = new System.Drawing.Size(30, 23);
            y_Label.TabIndex = 6;
            y_Label.Text = "Y :";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(427, 0);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 228);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(483, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(483, 45);
            this.pnlTop.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(y_Label);
            this.panel2.Controls.Add(this.y_TextBox);
            this.panel2.Controls.Add(x_Label);
            this.panel2.Controls.Add(this.x_TextBox);
            this.panel2.Controls.Add(equipmentNameLabel);
            this.panel2.Controls.Add(this.equipmentNameTextBox);
            this.panel2.Controls.Add(equipmentTypeIDLabel);
            this.panel2.Controls.Add(this.equipmentTypeIDLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 183);
            this.panel2.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.equipmentTypeBindingSource, "IsValid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(416, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 30);
            this.btnAdd.TabIndex = 104;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(346, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 30);
            this.btnDelete.TabIndex = 103;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // y_TextBox
            // 
            this.y_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentTypeBindingSource, "Y_", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.y_TextBox.Location = new System.Drawing.Point(200, 114);
            this.y_TextBox.Name = "y_TextBox";
            this.y_TextBox.Size = new System.Drawing.Size(63, 29);
            this.y_TextBox.TabIndex = 7;
            // 
            // x_TextBox
            // 
            this.x_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentTypeBindingSource, "X_", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.x_TextBox.Location = new System.Drawing.Point(200, 79);
            this.x_TextBox.Name = "x_TextBox";
            this.x_TextBox.Size = new System.Drawing.Size(63, 29);
            this.x_TextBox.TabIndex = 5;
            // 
            // equipmentNameTextBox
            // 
            this.equipmentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentTypeBindingSource, "EquipmentName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.equipmentNameTextBox.Location = new System.Drawing.Point(200, 43);
            this.equipmentNameTextBox.Name = "equipmentNameTextBox";
            this.equipmentNameTextBox.Size = new System.Drawing.Size(198, 29);
            this.equipmentNameTextBox.TabIndex = 3;
            // 
            // equipmentTypeIDLabel1
            // 
            this.equipmentTypeIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentTypeBindingSource, "EquipmentTypeID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.equipmentTypeIDLabel1.Location = new System.Drawing.Point(196, 12);
            this.equipmentTypeIDLabel1.Name = "equipmentTypeIDLabel1";
            this.equipmentTypeIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.equipmentTypeIDLabel1.TabIndex = 1;
            this.equipmentTypeIDLabel1.Text = "label1";
            // 
            // equipmentTypeBindingSource
            // 
            this.equipmentTypeBindingSource.DataSource = typeof(RefTagFinder.Classes.DataControl.EquipmentType);
            // 
            // FrmAddEquipmentType
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(483, 250);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddEquipmentType";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tag Finder";
            this.Load += new System.EventHandler(this.FrmTagFinder_Load);
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox y_TextBox;
        private System.Windows.Forms.BindingSource equipmentTypeBindingSource;
        private System.Windows.Forms.TextBox x_TextBox;
        private System.Windows.Forms.TextBox equipmentNameTextBox;
        private System.Windows.Forms.Label equipmentTypeIDLabel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}