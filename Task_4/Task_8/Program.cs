using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class MyClass
    {
        public int sale(int sum)
        {
            return sum < 1000 ? sum : sum - ((sum/100)*10);
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
            var sum = input("Enter how much cost this");
            MyClass myclassObject = new MyClass();
            var result = myclassObject.sale(sum);
            Console.WriteLine("You device cost {0}", result);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            consoleOut();
        }
    }
}
