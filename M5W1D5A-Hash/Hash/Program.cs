using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("This is a test");
            Console.WriteLine(Compute.Hash("This is a test"));

            Console.Write("Enter phrase to be hashed: ");
            string inputPhrase = Console.ReadLine();
            Console.WriteLine(Compute.Hash(inputPhrase));

            Console.WriteLine("---------------------------");

            string clearText = "Now is the time...really!";
            Console.WriteLine(clearText);

            string cipherText = Compute.Encrypt(clearText);
            Console.WriteLine(cipherText);

            string result = Compute.Decrypt(cipherText);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
