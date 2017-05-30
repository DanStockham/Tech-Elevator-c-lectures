using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Lecture.Aids
{
    public class BinaryImageManipulator
    {
        public static void ReadFileIn()
        {
            string folder = Environment.CurrentDirectory;
            string filename = "rick.jpg";
            string fullpath = Path.Combine(folder, filename);

            byte[] bytes = File.ReadAllBytes(fullpath);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                using (Image img = Image.FromStream(ms))
                {
                    Bitmap bmp = new Bitmap(img);
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        for (int y = 0; y < bmp.Height; y++)
                        {
                            Color oldPixel = bmp.GetPixel(x, y);
                            //bmp.SetPixel(x, y, Color.FromArgb(oldPixel.R, oldPixel.G, 20));
                            bmp.SetPixel(x, y, Color.FromArgb(oldPixel.R, Color.FromKnownColor(KnownColor.Gray)));
                        }
                    }

                    bmp.Save(Path.Combine(folder, "output.jpg"));
                }
            }
        }
    }
}
