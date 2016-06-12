using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class MyClass
    {
        public int recursiv(int someNumber)
        {
            var sum = someNumber%1000;
            
            var ost = sum%10;
            sum = sum/10;
            if (ost < 10)
            {
                return ost + recursiv(sum);
            }
            return sum;
        }

        /* public int recursivTwo(int someNumber)
         {
             var firstSum = someNumber/1000;
             var ost1 = firstSum%10;
             return ost1 < 0 ? 0 : ost1 + recursivTwo(ost1);

         }

         public string isEqual(int resultOne, int resultTwo)
         {
             if (resultOne == resultTwo)
             {
                 Console.WriteLine("is happy");
             }

             Console.WriteLine("isn`t happy");
             return "0";
         }*/
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
            var someNumber = input();
            MyClass myclassObject = new MyClass();
            var resultOne = myclassObject.recursiv(someNumber);
           // var resultTwo = myclassObject.recursivTwo(someNumber);
            //var result = myclassObject.isEqual(resultOne, resultTwo);
            //Console.WriteLine("Enter number {0} {1}",someNumber,result);
            Console.WriteLine(resultOne);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            consoleOut();
        }
    }
}
