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
//using RefTagFinder.Classes.Models;
namespace RefTagFinder
{
    public partial class FrmAddUnit : Form
    {
       
        public FrmAddUnit()
        {
            InitializeComponent();

            
        }

        Unit _mainFormUnit = new Unit();
        
        

        private void FrmTagFinder_Load(object sender, EventArgs e)
        {
            #region RePositionControl
            btnExit.Top = 0;
            btnExit.Left = this.Width - btnExit.Width;
            pnlTop.Height = btnExit.Height + 2;
            this.btnExit.Font     =
                new System.Drawing.Font
                ("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitIDTextBox.Focus();
            unitIDTextBox.SelectAll();
            #endregion

            #region Binding
            unitBindingSource.DataSource = _mainFormUnit;
            unitBindingSource.ResetBindings(true);
            #endregion
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {

            try
            {
                string OutputPath = Application.StartupPath + @"\Data\Units\pid\";
                if (!Directory.Exists(OutputPath))
                {
                    Directory.CreateDirectory(OutputPath);
                }
                OutputPath += _mainFormUnit.UnitID + Path.GetExtension(_mainFormUnit.PIDPath);
                File.Copy(_mainFormUnit.PIDPath, OutputPath, true);
                _mainFormUnit.PIDPath = OutputPath;

                OutputPath = Application.StartupPath + @"\Data\Units\image\";
                if (!Directory.Exists(OutputPath))
                {
                    Directory.CreateDirectory(OutputPath);
                }
                OutputPath += _mainFormUnit.UnitID + Path.GetExtension(_mainFormUnit.ImagePath);
                File.Copy(_mainFormUnit.ImagePath, OutputPath, true);
                _mainFormUnit.ImagePath = OutputPath;

                using (IDbConnection cnn = new SqlConnection(RefTagFinder.HelperStatic.LoadConnectionString()))
                {
                    string sql1 = $@"DELETE FROM  Unit  WHERE UnitID = {_mainFormUnit.UnitID}";
                    cnn.Execute(sql1);

                    sql1 = $@"INSERT INTO Unit (UnitID,UnitName,PIDPath,ImagePath) 
                                VALUES (@UnitID,@UnitName,@PIDPath,@ImagePath)";
                    cnn.Execute(sql1, _mainFormUnit);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            if (MessageBox.Show("Exit",
                "Do you want to exit OR\n \t Add another unit information???",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information)
                == DialogResult.Yes)
            { this.Close(); }
        }

        private void pidBrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pIDPathTextBox.Text = openFileDialog1.FileName;
                
                if (MessageBox.Show("Do You Want To Convert This PDF File?", "Convert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var img = new byte[0];
                    var thread = new Thread(
                        () =>
                        {
                            img = ConvertPDF2Image(_mainFormUnit.PIDPath);
                        });
                    thread.Start();
                    lblConverting.Text = "Converting\nPlease Wait...";
                    thread.Join();
                    lblConverting.Text = "";
                    Bitmap src = (Bitmap)((new ImageConverter()).ConvertFrom(img));
                    pictureBox1.Image = src;
                    string OutputPath = Application.StartupPath + @"\Data\Temp";
                    if (!Directory.Exists(OutputPath))
                    {
                        Directory.CreateDirectory(OutputPath);
                    }
                    new Bitmap(pictureBox1.Image).Save(OutputPath+"\\"+Path.GetFileNameWithoutExtension(_mainFormUnit.PIDPath)+".jpg", ImageFormat.Jpeg);
                    MessageBox.Show("Convert Completed");
                    imagePathTextBox.Text = OutputPath + "\\" + Path.GetFileNameWithoutExtension(_mainFormUnit.PIDPath) + ".jpg";

                }
            }
        }

        private void ImageBrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePathTextBox.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = _mainFormUnit.ImagePath;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
