using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class MyClass
    {
        public string you(int growth, int weight, string weightPlus, string weightMinus)
        {
            var opt = growth - 100;
            return opt < weight ? weightMinus : weightPlus;
        }
    }
    class Program
    {
        public static int input(string consoleMsg = "Enter numder")
        {
            Console.WriteLine(consoleMsg);
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public static void consoleOut()
        {
            var growth = input("Enter you growth in sm");
            var weight = input("Enter you the weight in kg");
            string weightPlus = "You need to gain weight";
            string weightMinus = "You need to lose weight";
            MyClass myclassObject = new MyClass();
            var result = myclassObject.you(growth, weight, weightPlus, weightMinus);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            consoleOut();
        }
    }
}
