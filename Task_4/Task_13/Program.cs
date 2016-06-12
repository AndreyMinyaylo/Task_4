using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class MyClass
    {
        public int function(int number, int sum)
        {
             
            if (sum > 0)
            {
                return 2*number;
            }
                return 0 * number;
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
            var A = input("Enter A");
            var B = input("Enter B");
            var C = input("Enter C");
            MyClass myclassObject = new MyClass();
            var sum = A + B + C;
            var resultA = myclassObject.function(A, sum);
            var resultB = myclassObject.function(B, sum);
            var resultC = myclassObject.function(C, sum);
            Console.WriteLine("Result is A = {0}, B = {1}, C = {2}",resultA, resultB, resultC);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            consoleOut();
        }
    }
}
