using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using QT.Entities;

namespace WSS.Image.AutoGenLogoMerchant
{
    public static class ImageUltilities
    {
        
        public static System.Drawing.Image DrawText(string text, Font font, Color textColor, Color backColor)
        {
            //first, create a dummy bitmap just to get a graphics object
            List<string> listText = new List<string>();
            System.Drawing.Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //measure the string to see how big the image needs to be
            SizeF textSizeUpper = drawing.MeasureString(text.ToUpper(), font);
            SizeF textSizeLower = drawing.MeasureString(text.ToLower(), font);
           

            //create a new image of the right size
            int width = 110;
            int height = 40;
            if (textSizeUpper.Width < width)
            {
                listText.Add(text.ToUpper());
            }
            else if (textSizeLower.Width < width)
            {
                listText.Add(text.ToLower());
            }else
            {
                var characters = text.ToCharArray().ToList();

                var kq = ImageUltilities.SplitArray<char>(characters, 11);
                foreach (var item in kq)
                {
                    listText.Add(string.Concat(item));
                }
                if (listText.Count == 2)
                {
                    int indexdaucham = text.ToLower().IndexOf('.');
                    string texttruocdaucham = text.ToLower().Substring(0, indexdaucham);
                    string textsaudaucham = text.ToLower().Substring(indexdaucham);
                    SizeF textSizeLower1 = drawing.MeasureString(texttruocdaucham.ToLower(), font);
                    if (textSizeLower1.Width > 110)
                    {
                        var textTemp = texttruocdaucham;
                        texttruocdaucham = textTemp.Substring(0, 11);
                        textsaudaucham = textTemp.Substring(11) + textsaudaucham;
                    }
                    listText.Clear();
                    listText.Add(texttruocdaucham);
                    listText.Add(textsaudaucham);
                }
            }
            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            img = new Bitmap(width, height);

            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);
            if (listText.Count == 1)
            {
                SizeF textSize1 = drawing.MeasureString(listText[0], font);
                int x1 = (int)((110 - textSize1.Width) / 2);
                drawing.DrawString(listText[0], font, textBrush, x1, 12);
            }
            else if (listText.Count == 2)
            {
                SizeF textSize1 = drawing.MeasureString(listText[0], font);
                SizeF textSize2 = drawing.MeasureString(listText[1], font);
                int x1 = (int)((110 - textSize1.Width) / 2);
                int x2 = (int)((110 - textSize2.Width) / 2);
                drawing.DrawString(listText[0], font, textBrush, x1, 5);
                drawing.DrawString(listText[1], font, textBrush, x2, 18);
            }
            else if (listText.Count >= 3)
            {
                SizeF textSize1 = drawing.MeasureString(listText[0], font);
                SizeF textSize2 = drawing.MeasureString(listText[1], font);
                SizeF textSize3 = drawing.MeasureString(listText[2], font);
                int x1 = (int)((110 - textSize1.Width) / 2);
                int x2 = (int)((110 - textSize2.Width) / 2);
                int x3 = (int)((110 - textSize3.Width) / 2);
                drawing.DrawString(listText[0], font, textBrush, x1, 0);
                drawing.DrawString(listText[1], font, textBrush, x2, 12);
                drawing.DrawString(listText[2], font, textBrush, x3, 24);
            }
            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;

        }

        public static List<List<T>> SplitArray<T>(this List<T> data, int length)
        {
            List<List<T>> lst = new List<List<T>>();
            int iStart = 0;
            while (iStart < data.Count)
            {
                int iEnd = (iStart + length < data.Count - 1) ? (iStart + length) : data.Count;
                T[] arSub = new T[iEnd - iStart];
                Array.Copy(data.ToArray(), iStart, arSub, 0, iEnd - iStart);
                lst.Add(arSub.ToList());
                iStart = iEnd;
                arSub = null;
            }
            return lst;

        }
    }
}
