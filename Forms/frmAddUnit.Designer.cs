namespace RefTagFinder
{
    partial class FrmAddUnit
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
            System.Windows.Forms.Label unitIDLabel;
            System.Windows.Forms.Label unitNameLabel;
            System.Windows.Forms.Label pIDPathLabel;
            System.Windows.Forms.Label imagePathLabel;
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.unitIDTextBox = new System.Windows.Forms.TextBox();
            this.lblConverting = new System.Windows.Forms.Label();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.pIDPathTextBox = new System.Windows.Forms.TextBox();
            this.unitNameTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.ImageBrowseButton = new System.Windows.Forms.Button();
            this.pidBrowseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            unitIDLabel = new System.Windows.Forms.Label();
            unitNameLabel = new System.Windows.Forms.Label();
            pIDPathLabel = new System.Windows.Forms.Label();
            imagePathLabel = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // unitIDLabel
            // 
            unitIDLabel.AutoSize = true;
            unitIDLabel.Location = new System.Drawing.Point(34, 24);
            unitIDLabel.Name = "unitIDLabel";
            unitIDLabel.Size = new System.Drawing.Size(72, 23);
            unitIDLabel.TabIndex = 100;
            unitIDLabel.Text = "Unit ID:";
            // 
            // unitNameLabel
            // 
            unitNameLabel.AutoSize = true;
            unitNameLabel.Location = new System.Drawing.Point(34, 72);
            unitNameLabel.Name = "unitNameLabel";
            unitNameLabel.Size = new System.Drawing.Size(101, 23);
            unitNameLabel.TabIndex = 23;
            unitNameLabel.Text = "Unit Name:";
            // 
            // pIDPathLabel
            // 
            pIDPathLabel.AutoSize = true;
            pIDPathLabel.Location = new System.Drawing.Point(34, 120);
            pIDPathLabel.Name = "pIDPathLabel";
            pIDPathLabel.Size = new System.Drawing.Size(78, 23);
            pIDPathLabel.TabIndex = 24;
            pIDPathLabel.Text = "PIDPath:";
            // 
            // imagePathLabel
            // 
            imagePathLabel.AutoSize = true;
            imagePathLabel.Location = new System.Drawing.Point(34, 168);
            imagePathLabel.Name = "imagePathLabel";
            imagePathLabel.Size = new System.Drawing.Size(105, 23);
            imagePathLabel.TabIndex = 25;
            imagePathLabel.Text = "Image Path:";
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
            this.btnExit.Location = new System.Drawing.Point(1027, 0);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1083, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1083, 45);
            this.pnlTop.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.unitIDTextBox);
            this.panel2.Controls.Add(this.lblConverting);
            this.panel2.Controls.Add(imagePathLabel);
            this.panel2.Controls.Add(this.imagePathTextBox);
            this.panel2.Controls.Add(pIDPathLabel);
            this.panel2.Controls.Add(this.pIDPathTextBox);
            this.panel2.Controls.Add(unitNameLabel);
            this.panel2.Controls.Add(this.unitNameTextBox);
            this.panel2.Controls.Add(unitIDLabel);
            this.panel2.Controls.Add(this.OKButton);
            this.panel2.Controls.Add(this.ImageBrowseButton);
            this.panel2.Controls.Add(this.pidBrowseButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 511);
            this.panel2.TabIndex = 21;
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
            this.btnDelete.Location = new System.Drawing.Point(897, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 102;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // unitIDTextBox
            // 
            this.unitIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "UnitID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.unitIDTextBox.Location = new System.Drawing.Point(204, 21);
            this.unitIDTextBox.Name = "unitIDTextBox";
            this.unitIDTextBox.Size = new System.Drawing.Size(264, 29);
            this.unitIDTextBox.TabIndex = 0;
            // 
            // lblConverting
            // 
            this.lblConverting.AutoSize = true;
            this.lblConverting.Font = new System.Drawing.Font("Nirmala UI", 40.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblConverting.Location = new System.Drawing.Point(497, 270);
            this.lblConverting.Name = "lblConverting";
            this.lblConverting.Size = new System.Drawing.Size(0, 91);
            this.lblConverting.TabIndex = 27;
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "ImagePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imagePathTextBox.Location = new System.Drawing.Point(204, 165);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.ReadOnly = true;
            this.imagePathTextBox.Size = new System.Drawing.Size(783, 29);
            this.imagePathTextBox.TabIndex = 26;
            // 
            // pIDPathTextBox
            // 
            this.pIDPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "PIDPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pIDPathTextBox.Location = new System.Drawing.Point(204, 117);
            this.pIDPathTextBox.Name = "pIDPathTextBox";
            this.pIDPathTextBox.ReadOnly = true;
            this.pIDPathTextBox.Size = new System.Drawing.Size(783, 29);
            this.pIDPathTextBox.TabIndex = 7;
            // 
            // unitNameTextBox
            // 
            this.unitNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "UnitName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.unitNameTextBox.Location = new System.Drawing.Point(204, 69);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(264, 29);
            this.unitNameTextBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.unitBindingSource, "IsValid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.FlatAppearance.BorderSize = 0;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Location = new System.Drawing.Point(993, 478);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 30);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ImageBrowseButton
            // 
            this.ImageBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImageBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.ImageBrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageBrowseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ImageBrowseButton.FlatAppearance.BorderSize = 0;
            this.ImageBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageBrowseButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageBrowseButton.ForeColor = System.Drawing.Color.White;
            this.ImageBrowseButton.Location = new System.Drawing.Point(993, 164);
            this.ImageBrowseButton.Name = "ImageBrowseButton";
            this.ImageBrowseButton.Size = new System.Drawing.Size(90, 30);
            this.ImageBrowseButton.TabIndex = 3;
            this.ImageBrowseButton.Text = "Browse";
            this.ImageBrowseButton.UseVisualStyleBackColor = false;
            this.ImageBrowseButton.Click += new System.EventHandler(this.ImageBrowseButton_Click);
            // 
            // pidBrowseButton
            // 
            this.pidBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pidBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.pidBrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pidBrowseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pidBrowseButton.FlatAppearance.BorderSize = 0;
            this.pidBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pidBrowseButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidBrowseButton.ForeColor = System.Drawing.Color.White;
            this.pidBrowseButton.Location = new System.Drawing.Point(993, 116);
            this.pidBrowseButton.Name = "pidBrowseButton";
            this.pidBrowseButton.Size = new System.Drawing.Size(90, 30);
            this.pidBrowseButton.TabIndex = 2;
            this.pidBrowseButton.Text = "Browse";
            this.pidBrowseButton.UseVisualStyleBackColor = false;
            this.pidBrowseButton.Click += new System.EventHandler(this.pidBrowseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Location = new System.Drawing.Point(16, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF|*.pdf";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(RefTagFinder.Classes.DataControl.Unit);
            // 
            // FrmAddUnit
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1083, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddUnit";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tag Finder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddUnit_FormClosed);
            this.Load += new System.EventHandler(this.FrmTagFinder_Load);
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ImageBrowseButton;
        private System.Windows.Forms.Button pidBrowseButton;
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.TextBox pIDPathTextBox;
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblConverting;
        private System.Windows.Forms.TextBox unitIDTextBox;
        private System.Windows.Forms.Button btnDelete;
    }
}