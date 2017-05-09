using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration statement for a variable named "result" of type boolean
            bool result;




            Console.WriteLine("****************************");
            Console.WriteLine("*** COMPARISON OPERATORS ***");
            Console.WriteLine("****************************");
            Console.WriteLine();
            
            /*
             ==  Equal to
             !=  Not equal to
            */

            result = (2 == 2);
            Console.WriteLine("2 == 2 : " + result);

            result = (2 == 3);
            Console.WriteLine("2 == 3 : " + result);

            result = ('a' == 'a');
            Console.WriteLine("'a' == 'a' : " + result);

            result = ('a' == 'b');
            Console.WriteLine("'a' == 'b' : " + result);

            result = (2 != 2);
            Console.WriteLine("2 != 2 : " + result);

            result = (2 != 3);
            Console.WriteLine("2 != 3 : " + result);

            result = ('a' != 'a');
            Console.WriteLine("'a' != 'a' : " + result);

            result = ('a' != 'b');
            Console.WriteLine("'a' != 'b' : " + result);

            Console.WriteLine();




            /*
             >  Greater than
             <  Less than
             >= Greater than or equal to
             <= Less than or equal to
            */
            result = (2 > 1);
            Console.WriteLine("2 > 1 : " + result);

            result = (2 < 2);
            Console.WriteLine("2 < 2 : " + result);

            result = (2 < 2);
            Console.WriteLine("2 < 2 : " + result);

            result = (2 <= 3);
            Console.WriteLine("2 <= 3 : " + result);

            result = (5 >= 5);
            Console.WriteLine("5 >= 5 : " + result);

            Console.WriteLine();




            Console.WriteLine("*************************");
            Console.WriteLine("*** LOGICAL OPERATORS ***");
            Console.WriteLine("*************************");
            Console.WriteLine();       

            /*
		     &&  AND
		    ||  OR
		    !  NOT
		    ^  XOR  (exclusive OR)
		    */
            result = true && true;
            Console.WriteLine("true && true : " + result);

            result = true && false;
            Console.WriteLine("true && false : " + result);

            result = false && false;
            Console.WriteLine("false && false : " + result);

            result = true || true;
            Console.WriteLine("true || true : " + result);

            result = true || false;
            Console.WriteLine("true || false : " + result);

            result = false || false;
            Console.WriteLine("false || false : " + result);

            result = !true;
            Console.WriteLine("!true : " + result);

            result = !false;
            Console.WriteLine("!false : " + result);

            result = true ^ true;
            Console.WriteLine("true ^ true : " + result);

            result = true ^ false;
            Console.WriteLine("true ^ false : " + result);

            result = false ^ false;
            Console.WriteLine("false ^ false : " + result);

            Console.WriteLine();





            Console.WriteLine("***************************");
            Console.WriteLine("*** BOOLEAN EXPRESSIONS ***");
            Console.WriteLine("***************************");
            Console.WriteLine();

            int value = 100;
            result = (value > 200) || (value < 500);
            Console.WriteLine("(value > 200) || (value < 500) : " + result);

            result = (value > 200) && (value < 500);
            Console.WriteLine("(value > 200) && (value < 500) : " + result);

            result = !(value >= 300);
            Console.WriteLine("!(value >= 300) : " + result);



            
        }

    }
}
