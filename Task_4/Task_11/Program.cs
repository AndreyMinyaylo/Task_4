using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class MyClass
    {
        public string end(int cop, string firstEnd, string secondEnd, string thirdEnd)
        {
            if ((cop%10) == 1)
            {
                return firstEnd;
            }
            if(((cop%10)==2)|| ((cop % 10) == 3))
            {
                return secondEnd;
            }
            if(((cop % 10) >= 5) && ((cop % 10) <= 9))
            {
                return thirdEnd;
            }
            if (((cop%10) == 0) || ((cop == 11)))
            {
                return thirdEnd;
            }
            return "0";
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
            var cop = input("Enter number of 1 to 99");
            string firstEnd = "копейка";
            string secondEnd = "копейки";
            string thirdEnd = "копеек";
            MyClass myclassObject = new MyClass();
            var result = myclassObject.end(cop, firstEnd, secondEnd, thirdEnd);
            Console.WriteLine("You entet {0} {1}", cop, result);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            consoleOut();
        }
    }
}
