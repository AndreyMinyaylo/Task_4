using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Mathematics
    {
        public double timeMetod(double speed, double distance)
        {
            var time = distance/speed;
            return time;
        }
    }
    class MyClass
    {
        public static double input(string consoleMsg = "Enter numder")
        {
            Console.WriteLine(consoleMsg);
            var number = Convert.ToDouble(Console.ReadLine());
            return number;
        }

        public static void result()
        {
            var speed = input("Enter speed. Km/h");
            var distance = input("Enter distance. Km");
            Mathematics mathematicsObject = new Mathematics();
            double myResult = mathematicsObject.timeMetod(speed, distance);
            Console.WriteLine("you come across about {0} hours", myResult);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            result();
        }
    }
}
