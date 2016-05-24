using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class worktime
    {
        public static int input()
        {
            Console.WriteLine("Enter how many time is now");
            var time = Convert.ToInt32(Console.ReadLine());
            return time;
        }

        public static void processing(int currentTime)

        {
           
            if((currentTime < 9)||(currentTime >= 18)&&(currentTime <= 24))
            {
                Console.WriteLine("I am relax");
            }
            else
            {
                Console.Write("I am at work");
            }
            Console.ReadKey();
        }

        public static void result()
        {
            int currentTime = input(); 
            processing(currentTime);
            
        }
        
    }

    class biggestNumber
    {
        public static int input()
        {
            Console.WriteLine("Enter number");
            var time = Convert.ToInt32(Console.ReadLine());
            return time;
        }

        public static void processing(int firstNumber, int secondNumber, int thirdNumber)
        {
            int max;
            max = firstNumber;

            if (secondNumber > max)
            {
                max = secondNumber;
            }
            if (thirdNumber > max)
            {
                max = thirdNumber;
            }
            Console.WriteLine("Biggest number is: " + max);
            Console.ReadKey();
        }

        public static void consoleOut()
        {
            int firstNumber = input();
            int secondNumber = input();
            int thirdNumbert = input();
            processing(firstNumber,secondNumber,thirdNumbert);
        }
        public static void Main(string[] args)
        {
            worktime.result();
            consoleOut();
        }

    }
}
