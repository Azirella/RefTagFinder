using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;

namespace RefTagFinder
{
    static class HelperStatic
    {
        public static Bitmap setTowPictureTransparency(Image background, Image foreground ,  int alpha)
        {
            //Bitmap result = new Bitmap(1, 1);

            Bitmap first = new Bitmap(background);
            //float alpha = ((float)alpha / 100);
            Bitmap second = SetImageOpacity(foreground, (float)alpha / 100);
            Bitmap result = new Bitmap(Math.Max(first.Width, second.Width), Math.Max(first.Height, second.Height));
            Console.WriteLine(first.Width);
            Graphics g = Graphics.FromImage(result);
            g.DrawImageUnscaled(first, 0, 0);
            g.DrawImageUnscaled(second, 0, 0);

            return result;
        }
        private static Bitmap SetImageOpacity(Image image, float opacity)
        {
            try
            {
                //create a Bitmap the size of the image provided  
                Bitmap bmp = new Bitmap(image.Width, image.Height);

                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = opacity;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static string EncryptMD5(string Value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(Value));
                return Convert.ToBase64String(data);
            }
            
        }
        public static string EncryptSH1(string Value)
        {

            using (SHA1CryptoServiceProvider sh1 = new SHA1CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = sh1.ComputeHash(utf8.GetBytes(Value));
                return Convert.ToBase64String(data);
            }
        }

        
        public static string latitudePATTERN = @"^(\+|-)?(?:90(?:(?:\.0{1,6})?)|(?:[0-9]|[1-8][0-9])(?:(?:\.[0-9]{1,6})?))$";
        public static string longitudePATTERN = @"^(\+|-)?(?:180(?:(?:\.0{1,6})?)|(?:[0-9]|[1-9][0-9]|1[0-7][0-9])(?:(?:\.[0-9]{1,6})?))$";


        public static string LoadConnectionString(string id = "LocalDBConnectionString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
namespace RefTagFinder.Classes.DataControl
{
    /*public partial class Unit
    {
        public bool IsValid
        {
            get
            {
                bool check = false;
                try
                {
                    if (
                        File.Exists(ImagePath) &&
                        File.Exists(PIDPath) &&
                        !string.IsNullOrEmpty(UnitName) &&
                        100 <= UnitID && UnitID <= 10000 && UnitID.GetType() == typeof(int)
                        ) { check = true; }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                return check;
            }

        }
    }*/

    public partial class EquipmentType
    {
        public bool IsValid
        {
            get
            {
                bool check = false;
                try
                {
                    int tttnumber;
                    if (!string.IsNullOrEmpty(EquipmentName) &&
                        Int32.TryParse(X_.ToString(), out tttnumber) &&
                        Int32.TryParse(Y_.ToString(), out tttnumber)
                        )
                    {
                        if (
                            EquipmentName.Length >= 3 &&
                            X_ > 0 && Y_ > 0 && X_ < 99 && Y_ < 99
                            )
                        {
                            check = true;
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                return check;
            }
        }
    }

    public partial class Equipment
    {
        public bool IsValid
        {
            get
            {
                bool check = false;
                if (!string.IsNullOrEmpty(Tag))
                {

                    check = true;
                }
                return check;
            }
        }
    }

}