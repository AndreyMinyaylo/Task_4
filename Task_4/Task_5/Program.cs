using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Work
    {
        public bool isEqual(int firstNumber, int secondtNumber, int thirdNumber)
        {
            if ((firstNumber == secondtNumber) || (firstNumber == thirdNumber) || (secondtNumber == thirdNumber))
            {
                return true;
            }
            return false;
        }

        
    }

    class MyClass
    {
        public static int input(string consoleMsg = "Enter numder")
        {
            Console.WriteLine(consoleMsg);
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public static void change(bool end)
        {
            if (end == true)
            {
                Console.WriteLine("there is one a pair of equal");
            }
            else
            {
                Console.WriteLine("there isn`t anyone a pair of equal");
            }
            Console.ReadKey();
        }

        public static void result()
        {
            var firstNumber = input("Enter first number:");
            var secondtNumber = input("Enter second number:");
            var thirdNumber = input("Enter third number:");
            Work workObject = new Work();
            bool end = workObject.isEqual(firstNumber, secondtNumber, thirdNumber);
            change(end);
        }   
    

    static void Main(string[] args)
        {
            result();
        }
    }
}
