using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Barcode_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap barCode = CreateBarcode("*Testing*");
            barCode.Save(@"C:\TestBar.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Console.WriteLine("Barcode saved as \"C:\\TestBar.jpg\"");
            Console.ReadLine();
        }

        private static System.Drawing.Bitmap CreateBarcode(System.String data)
        {
            data = data.ToUpper();

            Bitmap barCode = new Bitmap(1, 1);

            Font threeOfNine = new Font("Free 3 of 9", 60, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Font timesNR = new Font("Times New Roman", 20, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

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

            graphics.DrawString(data, threeOfNine, new SolidBrush(Color.Black), ((dataSize.Width / 2f) - (dataSize_bar.Width / 2f)), 0);
            graphics.DrawString(data, timesNR, new SolidBrush(Color.Black), ((dataSize.Width / 2f) - (dataSize_text.Width / 2f)), dataSize_bar.Height);

            graphics.Flush();

            threeOfNine.Dispose();

            graphics.Dispose();

            return barCode;
        }

    }
}
