using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class MyClass
    {
        public double price(double cost, double day)
        {
            return day == 6 || day == 7 ? cost - ((cost / 100) * 20) : cost;
        }
    }
    class Program
    {
        public static double input(string consoleMsg = "Enter numder")
        {
            Console.WriteLine(consoleMsg);
            var number = Convert.ToDouble(Console.ReadLine());
            return number;
        }

        public static void consoleOut()
        {
            var cost = input("Enter the price per minute");
            var day = input("Enter day of the week , when calling");
            MyClass myclassObject = new MyClass();
            var result = myclassObject.price(cost, day);
            Console.WriteLine("You prise is {0}", result);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            consoleOut();
        }
    }
}
