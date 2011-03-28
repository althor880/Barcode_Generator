using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;

namespace PDF_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap barCode = CreateBarcode("HTesting");
            WritePDF("HTESTING", barCode);
        }

        private static void WritePDF(String data, Bitmap barCode)
        {
            Document doc = new Document(PageSize.LETTER);
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(@"C:\Test.pdf", FileMode.Create));
                doc.Open();
                iTextSharp.text.Image bitmap = iTextSharp.text.Image.GetInstance(barCode, System.Drawing.Imaging.ImageFormat.Bmp);
                bitmap.ScalePercent(24f);
                bitmap.SetAbsolutePosition(((doc.PageSize.Width / 2f) - (bitmap.ScaledWidth / 2f)), ((doc.PageSize.Height / 2f) - (bitmap.ScaledHeight / 2f)));
                doc.Add(bitmap);
                doc.NewPage();
                doc.Add(bitmap);

            }
            catch (DocumentException dex)
            {
                Console.Write(dex.Message);
            }
            catch (IOException ioex)
            {
                Console.Write(ioex.Message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

        private static Bitmap CreateBarcode(String data)
        {
            data = data.ToUpper();

            if (data.Length > 0)
            {
                if (data[0] != '*')
                {
                    data = "*" + data;
                }

                if (data[data.Length - 1] != '*')
                {
                    data = data + "*";
                }
            }

            Bitmap barCode = new Bitmap(1, 1);

            System.Drawing.Font threeOfNine = new System.Drawing.Font("Free 3 of 9", 240, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            System.Drawing.Font timesNR = new System.Drawing.Font("Times New Roman", 80, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            Graphics graphics = Graphics.FromImage(barCode);

            SizeF dataSize = new SizeF();

            SizeF dataSize_bar = graphics.MeasureString(data, threeOfNine);
            SizeF dataSize_text = graphics.MeasureString(data, timesNR);

            if (dataSize_bar.Width > dataSize_text.Width)
            {
                dataSize.Width = dataSize_bar.Width;
            }
            else
            {
                dataSize.Width = dataSize_text.Width;
            }

            dataSize.Height = (dataSize_bar.Height + dataSize_text.Height);

            barCode = new Bitmap(barCode, dataSize.ToSize());

            graphics = Graphics.FromImage(barCode);

            graphics.Clear(Color.White);

            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            graphics.DrawString(data, threeOfNine, new SolidBrush(Color.Black), ((dataSize.Width/2f)-(dataSize_bar.Width/2f)), 0);
            graphics.DrawString(data, timesNR, new SolidBrush(Color.Black), ((dataSize.Width / 2f) - (dataSize_text.Width / 2f)), dataSize_bar.Height);

            graphics.Flush();

            threeOfNine.Dispose();

            graphics.Dispose();

            return barCode;
        }
    }
}
