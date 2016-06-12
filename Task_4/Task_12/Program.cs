using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class MyClass
    {
        public string wind(string first, string second, string third, string four, int someNumber)
        {
            if (someNumber == 1)
            {
                return first;
            }
            if (someNumber == 2)
            {
                return second;
            }
            if (someNumber == 3)
            {
                return third;
            }
            if (someNumber == 4)
            {
                return four;
            }
            return "0";
        }
    }
    class Program
    {
        public static int input(string consoleMsg = "Enter numder")
        {
            Console.Write(consoleMsg);
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public static void consoleOut()
        {
            var someNumber = input("Select the character of the wind:\n" +
                                   "weak = 1 " +
                                   "moderate = 2 " +
                                   "strong = 3 " +
                                   "hurricane = 4\n");
            string first = "of 1 to 4 m/s";
            string second = "of 5 to 10 m/s";
            string third = "of 9 to 18 m/s";
            string four = "more 19 m/s";
            MyClass myclassObject = new MyClass();
            var result = myclassObject.wind(first, second, third, four, someNumber);
            Console.WriteLine("Wind speed is {0}", result);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            consoleOut();
        }
    }
}
