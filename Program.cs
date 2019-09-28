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

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
