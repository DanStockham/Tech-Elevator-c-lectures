using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Aids
{
    public static class BinaryFileWriter
    {
        /*
        * Another type of writer exists, the BinaryWriter. It simplifies writing primitive data types to a stream.
        * When you create the BinaryWriter, you provide the stream that you write to and optionally
        * the Encoding to apply. 
        */
        public static void WritePrimitiveValues()
        {
            // Get the full path where we will output the file
            string directory = Environment.CurrentDirectory;
            string filename = "primitivevalues.dat";
            string fullPath = Path.Combine(directory, filename);


            // For Brevity the try-catch block is left out

            // Binary Writer doesn't use a file path in its constructor
            // It requires a stream that has a handle on the file
            // The FileStream class implements the IDisposable interface and gets a using
            using (FileStream fs = File.Open(fullPath, FileMode.Create))
            {
                // We use the FileStream to open the BinaryWrtier
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(1.52);
                    writer.Write(true);
                    writer.Write(2550613);
                    writer.Write(@"C:\Temp");
                }
            }            
        }

        /*
        * The Binary Reader is only able to read primitive values.
        */
        public static void ReadPrimitiveValues()
        {
            // Get the full path where we will output the file
            string directory = Environment.CurrentDirectory;
            string filename = "primitivevalues.dat";
            string fullPath = Path.Combine(directory, filename);

            // Binary Reader doesn't use a file path in its constructor
            // It requires a stream that has a handle on the file
            using (FileStream fs = File.Open(fullPath, FileMode.Open))
            {
                // Use the FileStream to open the BinaryReader
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    // There are all sorts of reader methods
                    // to read different primitive types
                    double dbl = reader.ReadDouble();
                    bool boolean = reader.ReadBoolean();
                    int number = reader.ReadInt32();
                    string path = reader.ReadString();
                }
            }

        }
    }
}
