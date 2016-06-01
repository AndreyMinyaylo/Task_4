using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class ThreeNumber
    {
        public void equal(int number, int firstNumber, int secondNumber, int thirdNumber)
        {
            if ((firstNumber == secondNumber) && (firstNumber == thirdNumber))
            {
                Console.WriteLine("Three numbers are equal");
            }
            if ((firstNumber == secondNumber) || (secondNumber == thirdNumber) || (firstNumber == thirdNumber))
            {
                Console.WriteLine("Two numbers are equal");
            }
            else
            {
                Console.WriteLine("Isn`t equal numbers");
            }
            Console.ReadKey();
        }

    
        public static int input(string consoleMsg = "Enter numder")
        {
            Console.WriteLine(consoleMsg);
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public static void threeNumber()
        {
            int number = input("Enter number");
            int firstNumber = number % 10;
            int secondNumber = (number / 10) % 10;
            int thirdNumber = number / 100;
           ThreeNumber testObject = new ThreeNumber();
            testObject.equal(number,firstNumber, secondNumber, thirdNumber);

        }

        static void Main(string[] args)
        {
            threeNumber();
        }
    }
}
