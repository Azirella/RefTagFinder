using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SautinSoft;
//using System.Threading.Task;

namespace pdf2image.SautinSoft.PdfFocus
{
    public static class Program
    {
        public enum Definition
        {
            One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10
        }

        /// <summary>
        /// 将PDF文档转换为图片的方法
        /// </summary>
        /// <param name="pdfInputPath">PDF文件路径</param>
        /// <param name="imageOutputPath">图片输出路径</param>
        /// <param name="imageName">生成图片的名字</param>
        /// <param name="startPageNum">从PDF文档的第几页开始转换</param>
        /// <param name="endPageNum">从PDF文档的第几页开始停止转换</param>
        /// <param name="imageFormat">设置所需图片格式</param>
        /// <param name="definition">设置图片的清晰度，数字越大越清晰</param>
        public static List<byte[]> ConvertPDF2Image(string pdfInputPath, string imageOutputPath,
            string imageName, int startPageNum, int endPageNum, ImageFormat imageFormat, Definition definition)
        {

            global::SautinSoft.PdfFocus pdfFocus = new global::SautinSoft.PdfFocus();

            pdfFocus.OpenPdf(pdfInputPath);

            if (!Directory.Exists(imageOutputPath))
            {
                Directory.CreateDirectory(imageOutputPath);
            }

            // validate pageNum
            if (startPageNum <= 0)
            {
                startPageNum = 1;
            }

            if (endPageNum > pdfFocus.PageCount)
            {
                endPageNum = pdfFocus.PageCount;
            }

            if (startPageNum > endPageNum)
            {
                int tempPageNum = startPageNum;
                startPageNum = endPageNum;
                endPageNum = startPageNum;
            }
            List<byte[]> images = new List<byte[]>();
            // start to convert each page
            for (int i = startPageNum; i <= endPageNum; i++)
            {
                byte[] img = pdfFocus.ToImage(i);

                
                images.Add(img);
                using (FileStream fs1 = File.Create(imageOutputPath + imageName + i.ToString() + "." + imageFormat.ToString()))
                {
                    fs1.Write(img, 0, img.Length);
                }
            }
            //byte[] bmp = pdfFocus.ToImage(1);

            pdfFocus.ClosePdf();
            return images;
        }

        public static byte[] ConvertPDF2Image(string pdfInputPath)
        {

            global::SautinSoft.PdfFocus pdfFocus = new global::SautinSoft.PdfFocus();

            pdfFocus.OpenPdf(pdfInputPath);
            //Task
            
            byte[] img = pdfFocus.ToImage(1);
            //byte[] bmp = pdfFocus.ToImage(1);

            pdfFocus.ClosePdf();
            return img;
        }
        public static void Main(string[] args)
        {
            ConvertPDF2Image("C:\\FileServer\\test.pdf", "C:\\FileServer\\", "test", 1, 5, ImageFormat.Png, Definition.One);
            
        }

    }
}



