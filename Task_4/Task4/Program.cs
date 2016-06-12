using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Speed
    {
        public double isEqual(double firstNumber, double secondNumber)
        {
            double constanta = 3.6;
            secondNumber = secondNumber*constanta;
            double max; 
            max = firstNumber;
            if (secondNumber>max)
            {
                max = secondNumber;
            }
            return max;
        }

    }
    class MyClass {

        public static double input(string consoleMsg = "Enter numder")
        {
            Console.WriteLine(consoleMsg);
            var number = Convert.ToDouble(Console.ReadLine());
            return number;
        }

        public static void speed()
        {
            Speed speedObject = new Speed();
            var firstNumber = input("Enter speed in Km/h:");
            var secondNumber = input("Enter speed in m/s:");
            var result = speedObject.isEqual(firstNumber, secondNumber);
            Console.WriteLine("Biggest speed is = {0}", result);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            speed();
        }
    }
}
