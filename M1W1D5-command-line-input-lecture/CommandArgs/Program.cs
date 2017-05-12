using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Printing out each of the arg values
            for (int i = 0; i < args.Length; i++)
            {                
                Console.WriteLine($"Argument i is {args[i]}");
            }

            //2. Print the correct command according to the arguments provided                        
            //      Try -help
            //      Try -ascii
            //      Try -clear
            //      Try -color {red | blue | yellow}
            for (int i = 0; i < args.Length; i++)
            {
                switch(args[i])
                {
                    case "-help":
                        Console.WriteLine();
                        Console.WriteLine("You asked to see the help");
                        Console.WriteLine("This is a pretty simple program and there isn't much");
                        Console.WriteLine("The commands you can submit are");
                        Console.WriteLine("     -help           to display the help");
                        Console.WriteLine("     -ascii          to create a nice ascii art");
                        Console.WriteLine("     -clear          to clear the display");
                        Console.WriteLine("     -color color    to change the color");
                        Console.WriteLine();
                        break;

                    case "-ascii":
                        Console.WriteLine();
                        Console.WriteLine(@"  $$\                         $$\                       $$\                               $$\                         ");
                        Console.WriteLine(@"  $$ |                        $$ |                      $$ |                              $$ |                        ");
                        Console.WriteLine(@"$$$$$$\    $$$$$$\   $$$$$$$\ $$$$$$$\         $$$$$$\  $$ | $$$$$$\ $$\    $$\ $$$$$$\ $$$$$$\    $$$$$$\   $$$$$$\  ");
                        Console.WriteLine(@"\_$$  _|  $$  __$$\ $$  _____|$$  __$$\       $$  __$$\ $$ |$$  __$$\\$$\  $$  |\____$$\\_$$  _|  $$  __$$\ $$  __$$\ ");
                        Console.WriteLine(@"  $$ |    $$$$$$$$ |$$ /      $$ |  $$ |      $$$$$$$$ |$$ |$$$$$$$$ |\$$\$$  / $$$$$$$ | $$ |    $$ /  $$ |$$ |  \__|");
                        Console.WriteLine(@"  $$ |$$\ $$   ____|$$ |      $$ |  $$ |      $$   ____|$$ |$$   ____| \$$$  / $$  __$$ | $$ |$$\ $$ |  $$ |$$ |      ");
                        Console.WriteLine(@"  \$$$$  |\$$$$$$$\ \$$$$$$$\ $$ |  $$ |      \$$$$$$$\ $$ |\$$$$$$$\   \$  /  \$$$$$$$ | \$$$$  |\$$$$$$  |$$ |      ");
                        Console.WriteLine(@"   \____/  \_______| \_______|\__|  \__|       \_______|\__| \_______|   \_/    \_______|  \____/  \______/ \__|      ");
                        Console.WriteLine();
                        break;

                    case "-clear":
                        Console.Clear();
                        Console.WriteLine("CLEARED");
                        Console.WriteLine();
                        break;

                    case "-color":
                        string color = args[i + 1];                        
                        if (color == "red")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;                           
                        }
                        else if (color == "blue")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        else if (color == "yellow")
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        Console.Clear();
                        break;                    
                }
            }
                         
            
            
        }
    }
}
