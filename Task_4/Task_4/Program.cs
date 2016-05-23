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

        public static void Main(string[] args)
        {
            result();
        }
    }
}
