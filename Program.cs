using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Video1 v1 = new Video1();

            Video2 v2 = new Video2();
            v2.Method1();
        }
    }

    class Video1
    {
        // Data types 

        byte myByte = 255;                       // 8 bits
        char myChar = 'a';                       // 16 bits
        short myShort = 65;                      // 16 bits
        int myInt = 2147483647;                  // 32 bits
        uint myUInt = 4294967295;                // 32 bits
        float myFloat = 1.23456f;                // 32 bits
        double myDouble = 1.23456;               // 64 bits
        decimal myDecimal = (decimal)1.23456;    // 128 bits 
        string myString = "Hello World!";        // Text
        bool myBool = true;                      // true or false 
    }

    class Video2
    {
        // 1. Comments 
        /* 
         * Multi 
         * line 
         * comments 
         */

        // 2. Ending lines and statements 
        /* 
         * ; 
         */

        // 3. Accessibility levels
        /*
         * private - only inside of the class, method etc where the variable vas created.
         * protected - makes the variable visible from the inherited class. 
         * public - no access restrictions. 
         * internal - 
         * protected internal - 
         */

        // 4. Different ways to declare variable (members vs properties)
        /*
         * MyVariable - public property.
         * mMyVariable - private member. 
         * myVariable - a variable inside of a method.
         */
        private string mCreditCardNumber;

        // 5. Reading text from user input 
        public void Method1()
        {
            Console.WriteLine("Please enter a number between 1 and 10...");
            string userResponse = Console.ReadLine();

            // 6. Parsing 
            int userNumber;
            if (int.TryParse(userResponse, out userNumber))
            {
                if (userNumber < 1 || userNumber > 10)
                {
                    Console.WriteLine("Sorry, the number was outside of the range.");
                }
                else
                {
                    // 7. Calculations
                    userNumber *= 2; // userNumber = userNumber * 2;

                    // 8. Constructing strings from variables 
                    Console.WriteLine($"Your new number is {userNumber}."); //Console.WriteLine("Your new number is " + userNumber + ".");
                }
            }
            else
            {
                Console.WriteLine("That was not a recognized number.");
            }

            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }

    }
}
