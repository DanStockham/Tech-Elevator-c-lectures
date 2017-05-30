using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture.Aids
{
    /*
    * Programs can work with the files in the file system.
    *
    * In most cases either an absolute path is determined to open
    * the file in question or a relative path based on where the program
    * is currently running to open the file in question.
    *
    * We need to add a reference to System.IO
    */
    public static class FileAndDirectories
    {

        /*        
        * The static class Directory exposes a lot of methods
        * A class DirectoryInfo is an instance of a Directory and provides
        * a lot of detail about the directory in question (last access, created date, etc.)
        *
        * NOTE
        * Normally if you use a \ in a string you need to escape it with two \\.
        * C# lets you put the @ in front of a string and it will realize that if any \ are typed
        * they do not need to be escaped and will show up as the literal value.        
        */
        public static void UsingTheDirectoryClass()
        {            
            // Getting the current directory our program is running in
            // not always the same directory
            string currentDirectory = Directory.GetCurrentDirectory();

            // Check to see if a directory exists
            bool directoryExists = Directory.Exists(@"C:\TestDirectory\SubDirectory");

            if (!directoryExists)
            {
                // Creating a directory
                Directory.CreateDirectory(@"C:\TestDirectory");

                // Getting a list of directories within a directory
                // One could write a for-loop to print each directory out
                string[] subDirectories = Directory.GetDirectories(@"C:\TestDirectory\SubDirectory");

                // Get the parent directory of the directory path
                // If the below directory exists it should return C:\TestDirectory
                DirectoryInfo parentDirectory = Directory.GetParent(@"C:\TestDirectory\SubDirectory");

                // We can get a list of files within a directory
                string[] files = Directory.GetFiles(@"C:\TestDirectory\SubDirectory");

                // Delete a directory
                Directory.Delete(@"C:\TestDirectory");
            }
        }

        /*        
        * The static class File exposes a lot of methods to manipulate files
        * A class FileInfo is an instance of a File and provides
        * a lot of detail about the file in question (last access, created date, etc.)
        *
        * They work hand in hand
        */
        public static void UsingTheFileClass()
        {
            const string FilePath = @"C:\TestDirectory\FileName.txt";

            // Check to see if a file exists
            bool fileExists = File.Exists(FilePath);
            if (fileExists)
            {
                // To copy a file we need the source and destination
                File.Copy(FilePath, @"C:\TestDirectory\DestinationFileName.txt");
               
                // To delete a file we can use the file path
                File.Delete(FilePath);
            }
        }



    }
}
