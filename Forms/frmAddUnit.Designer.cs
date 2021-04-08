namespace RefTagFinder
{
    partial class frmAddUnit
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
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.unitIDLabel1 = new System.Windows.Forms.Label();
            this.unitNameComboBox = new System.Windows.Forms.ComboBox();
            this.pIDPathTextBox = new System.Windows.Forms.TextBox();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.pidBrowseButton = new System.Windows.Forms.Button();
            this.ImageBrowseButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            unitIDLabel = new System.Windows.Forms.Label();
            unitNameLabel = new System.Windows.Forms.Label();
            pIDPathLabel = new System.Windows.Forms.Label();
            imagePathLabel = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(843, 0);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(899, 45);
            this.pnlTop.TabIndex = 20;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(RefTagFinder.Classes.Models.Unit);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.OKButton);
            this.panel2.Controls.Add(this.ImageBrowseButton);
            this.panel2.Controls.Add(this.pidBrowseButton);
            this.panel2.Controls.Add(imagePathLabel);
            this.panel2.Controls.Add(this.imagePathTextBox);
            this.panel2.Controls.Add(pIDPathLabel);
            this.panel2.Controls.Add(this.pIDPathTextBox);
            this.panel2.Controls.Add(unitNameLabel);
            this.panel2.Controls.Add(this.unitNameComboBox);
            this.panel2.Controls.Add(unitIDLabel);
            this.panel2.Controls.Add(this.unitIDLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 384);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.unitBindingSource, "ImagePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox1.Location = new System.Drawing.Point(16, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 198);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // unitIDLabel
            // 
            unitIDLabel.AutoSize = true;
            unitIDLabel.Location = new System.Drawing.Point(12, 6);
            unitIDLabel.Name = "unitIDLabel";
            unitIDLabel.Size = new System.Drawing.Size(72, 23);
            unitIDLabel.TabIndex = 1;
            unitIDLabel.Text = "Unit ID:";
            // 
            // unitIDLabel1
            // 
            this.unitIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "UnitID", true));
            this.unitIDLabel1.Location = new System.Drawing.Point(143, 6);
            this.unitIDLabel1.Name = "unitIDLabel1";
            this.unitIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.unitIDLabel1.TabIndex = 2;
            this.unitIDLabel1.Text = "label1";
            // 
            // unitNameLabel
            // 
            unitNameLabel.AutoSize = true;
            unitNameLabel.Location = new System.Drawing.Point(12, 42);
            unitNameLabel.Name = "unitNameLabel";
            unitNameLabel.Size = new System.Drawing.Size(101, 23);
            unitNameLabel.TabIndex = 3;
            unitNameLabel.Text = "Unit Name:";
            // 
            // unitNameComboBox
            // 
            this.unitNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "UnitName", true));
            this.unitNameComboBox.FormattingEnabled = true;
            this.unitNameComboBox.Location = new System.Drawing.Point(143, 39);
            this.unitNameComboBox.Name = "unitNameComboBox";
            this.unitNameComboBox.Size = new System.Drawing.Size(121, 29);
            this.unitNameComboBox.TabIndex = 4;
            // 
            // pIDPathLabel
            // 
            pIDPathLabel.AutoSize = true;
            pIDPathLabel.Location = new System.Drawing.Point(12, 78);
            pIDPathLabel.Name = "pIDPathLabel";
            pIDPathLabel.Size = new System.Drawing.Size(78, 23);
            pIDPathLabel.TabIndex = 5;
            pIDPathLabel.Text = "PIDPath:";
            // 
            // pIDPathTextBox
            // 
            this.pIDPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "PIDPath", true));
            this.pIDPathTextBox.Location = new System.Drawing.Point(143, 75);
            this.pIDPathTextBox.Name = "pIDPathTextBox";
            this.pIDPathTextBox.Size = new System.Drawing.Size(657, 29);
            this.pIDPathTextBox.TabIndex = 6;
            // 
            // imagePathLabel
            // 
            imagePathLabel.AutoSize = true;
            imagePathLabel.Location = new System.Drawing.Point(12, 114);
            imagePathLabel.Name = "imagePathLabel";
            imagePathLabel.Size = new System.Drawing.Size(105, 23);
            imagePathLabel.TabIndex = 7;
            imagePathLabel.Text = "Image Path:";
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "ImagePath", true));
            this.imagePathTextBox.Location = new System.Drawing.Point(143, 111);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(657, 29);
            this.imagePathTextBox.TabIndex = 8;
            // 
            // pidBrowseButton
            // 
            this.pidBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pidBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.pidBrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pidBrowseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pidBrowseButton.FlatAppearance.BorderSize = 0;
            this.pidBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pidBrowseButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidBrowseButton.ForeColor = System.Drawing.Color.White;
            this.pidBrowseButton.Location = new System.Drawing.Point(806, 75);
            this.pidBrowseButton.Name = "pidBrowseButton";
            this.pidBrowseButton.Size = new System.Drawing.Size(90, 30);
            this.pidBrowseButton.TabIndex = 20;
            this.pidBrowseButton.Text = "Browse";
            this.pidBrowseButton.UseVisualStyleBackColor = false;
            // 
            // ImageBrowseButton
            // 
            this.ImageBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.ImageBrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageBrowseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ImageBrowseButton.FlatAppearance.BorderSize = 0;
            this.ImageBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageBrowseButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageBrowseButton.ForeColor = System.Drawing.Color.White;
            this.ImageBrowseButton.Location = new System.Drawing.Point(806, 110);
            this.ImageBrowseButton.Name = "ImageBrowseButton";
            this.ImageBrowseButton.Size = new System.Drawing.Size(90, 30);
            this.ImageBrowseButton.TabIndex = 21;
            this.ImageBrowseButton.Text = "Browse";
            this.ImageBrowseButton.UseVisualStyleBackColor = false;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.FlatAppearance.BorderSize = 0;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Location = new System.Drawing.Point(806, 351);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 30);
            this.OKButton.TabIndex = 22;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // frmAddUnit
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(899, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddUnit";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tag Finder";
            this.Load += new System.EventHandler(this.frmTagFinder_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ImageBrowseButton;
        private System.Windows.Forms.Button pidBrowseButton;
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.TextBox pIDPathTextBox;
        private System.Windows.Forms.ComboBox unitNameComboBox;
        private System.Windows.Forms.Label unitIDLabel1;
    }
}