using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarationStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            // DECLARING VARIABLES
            // ----------------------------------
            
            // Variable declaration
            int x;
            bool isDotNetAwesome;
            bool isDotNetAwesome2;

            // Assignment statement
            x = 3;
            isDotNetAwesome = true;

            // We can also declare and assign in one statement
            int y = 5;

            // variable names should start with a lower case letter and use camelCase
            int ageOfAdulthood = 18;

            // literal values of type char appear between single quotes
            char theFirstLetter = 'a';

            // use floating point types like double to represent decimal values
            double averageNumberNumberOfChildren = 2.5;

            // three different types of assignment statements
            // 1) assigning a literal
            x = 2;
            // 2) assigning from another variable
            y = x;
            // 3) assigning the result of an expression
            y = x + 3;

            // declaring constants
            const int MinimumVotingAge = 18;
            const int LegalDrivingAge = 16;
            const double Pi = 3.14;

            // trying to change the value of a constant
            //Pi = 4.2;

            // declaring a decimal variable to hold a bank account balance of $99.25
            //the runtime thinks 99.25 is literally a double, not a decimal so we have to use a literal suffix 'M' to indicate
            //yes this is really a decimal
            decimal bankAccountBalance = 99.25M;

            // declaring a char variable
            char hyphenChar = '-';




            // USING STRING LITERALS
            // ----------------------------------
            // String literals appear between double quotes
            string firstName = "John";
            string lastName = "Doe";
            // the + operator is used for String concatenation
            string fullName = firstName + " " + lastName;

            //Printing it out to the screen
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(fullName);



            // **********************
            // ARITHMETIC OPERATORS
            // **********************
            int a = 12;
            Console.WriteLine("What happens to b?");
            int b = a + 3;  // ADDITION
            Console.WriteLine(b);
            b = a - 5;  // SUBTRACTION
            Console.WriteLine(b);
            b = a * 2;  // MULTIPLICATION
            Console.WriteLine(b);
            b = a / 2;  // DIVISION
            Console.WriteLine(b);

            // Modulus division
            int remainder = 10 % 3;
            Console.WriteLine("The remainder of dividing 10 by 3 is " + remainder);

            remainder = 8 % 4;
            Console.WriteLine("The remainder of dividing 8 by 4 is " + remainder);



            // **********************
            // TRUNCATION AND CASTING
            // **********************
            int cookiesEaten = 10;
            int numberOfChildrenEatingCookies = 6;
            float averageCookiesEaten = cookiesEaten / numberOfChildrenEatingCookies; // the right hand side of this operation is evaluated as an int, so the fractional value is truncated
            Console.WriteLine("Average Cookies Eaten: " + averageCookiesEaten);

            averageCookiesEaten = (float)cookiesEaten / numberOfChildrenEatingCookies; // here we "cast" an int variable to type float so that the result of the arithmetic operation is a float
            Console.WriteLine("(casting to float) Average Cookies Eaten: " + averageCookiesEaten);

            double aDouble = 7.89;
            //int anInteger = aDouble;  // this is a compiler error
            int anInteger = (int)aDouble;  // this will truncate the fractional part of the double
            Console.WriteLine(aDouble + " cast to an int is equal to: " + anInteger);



            // ***********************
            // ESCAPE CHARACTERS
            // ***********************
            string emerilQuote = "Emeril said, \"Bam!\"";
            Console.WriteLine(emerilQuote);

            Console.WriteLine("To print \\ I need two backslashes");

            Console.WriteLine("Hello!\n\nGoodbye!");  // The escape character for newline is \n

            Console.WriteLine("Hello\tGoodbye"); // The escape character for tab is \t            
        }
    }
}
