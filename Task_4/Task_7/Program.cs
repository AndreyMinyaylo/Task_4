using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class MyClass
    {
        public string month(int someNumber, string oUT, string spring, string summer, string autumn, string winter)
        {
            if ((someNumber >= 3) && (someNumber <= 5))
            {
                return spring;
            }
            if ((someNumber >= 6) && (someNumber <= 8))
            {
                return summer;
            }
            if ((someNumber >= 9) && (someNumber <= 11))
            {
                return autumn;
            }
            if ((someNumber == 12) && (someNumber == 1) && (someNumber == 2))
            {
                return winter;
            }
            return oUT;
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

        public static void run()
        {
            var someNumber = input("Enter number at 1 to 12");
            string spring = "Now is Spring";
            string summer = "Now is Summer";
            string autumn = "Now is Outem";
            string winter = "Now is Winter";
            string oUT = "input number is not in the range of 1 to 12";
            MyClass myclassObject = new MyClass();
            var result = myclassObject.month(someNumber, oUT, spring, summer, autumn, winter);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
         run();   
        }
    }
}
