using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Aids
{
    public class Memory_StreamSample
    {
        public static void ReadStream()
        {
            string folder = Environment.CurrentDirectory;
            string file = "input.txt";
            string fullPath = Path.Combine(folder, file);

            byte[] bytes = File.ReadAllBytes(fullPath);
            using(FileStream fs = File.Open(fullPath, FileMode.Open))
            {
                fs.re
            }



        }

    }
}
