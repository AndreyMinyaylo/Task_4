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
            processing(firstNumber, secondNumber, thirdNumbert);
        }
    }

    class twiceNumber
    {
        public static int input()
        {
            Console.WriteLine("Enter number:");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public static void number(int someNumber)
        {
            if ((someNumber > 0) && (someNumber%7 == 0))
            {
                Console.WriteLine("Number is: "+someNumber*2);
            }
            else
            {
                Console.WriteLine("Enter number is not divisible on 7");
            }
            Console.ReadKey();
        }

        public static void consoleOut()
        {
            int someNumber = input();
            number(someNumber);
        }
    }

    class consoleNumber
    {
        public static float input()
        {
            Console.WriteLine("Enter float number:");
            var number = Convert.ToSingle(Console.ReadLine());
            return number;
        }

        public static void numberFloat(float someNumber)
        {
            if ((someNumber >= 0)&&(someNumber <= 1))
            {
                Console.WriteLine("Number is range 0 to 1");
            }
        else
                {
                    Console.WriteLine("Number isn`t range 0 to 1");
                }
            Console.ReadKey();
        }

        public static void consoleOut()
        {
            float someNumber = input();
            numberFloat(someNumber);
        }

    }

    class twoNumbers
    {
        public static int input()
        {
            Console.WriteLine("Enter number:");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public static void workWithNumber(int firstNumber, int secondNumber)
        {
            int max = firstNumber;
       
            if (secondNumber > max)
            {
                Console.WriteLine("Second number is biggest. Result is: " + (firstNumber + secondNumber));
            }
            else
            {
                Console.WriteLine("First number is biggest. Result is: " + (firstNumber - secondNumber));
            }
            Console.ReadKey();
        }



        public static void consoleOut()
        {
            int firstNumber = input();
            int secondNumber = input();
            workWithNumber(firstNumber,secondNumber);
        }
    }

    class  task_4_6
    {
        public static void resultWork(int firstNumber, int secondNumber)
        {
            int someNumber = firstNumber + secondNumber;
            if ((someNumber >= 11) && (someNumber <= 19))
            {
                Console.WriteLine("Sum number`s is: " + someNumber);
            }
            else
            {
                Console.WriteLine("Sum numbers isn`t in range of 11 to 19");
            }
            Console.ReadKey();
        }
        public static void consoleOut()
        {
            int firstNumber = twoNumbers.input();
            int secondNumber = twoNumbers.input();
            resultWork(firstNumber,secondNumber);

        }
    }

   /* class task_4_7
    {
        public static bool resultWork(int firstNumber, int secondNumber)
        {   
            bool someNumber = true;
            if ((firstNumber%secondNumber != 0) || (secondNumber%firstNumber != 0))
            {
                return false;
            }
            
            return someNumber;
            //Console.WriteLine("the number of divided without a remainder: " + );
        }

        public static void console(bool someNumber, int firstNumber, int secondNumber)
        {
            if (someNumber == true)
            {
                
            }
        }

        public static void consoleOut()
        {
            int firstNumber = twoNumbers.input();
            int secondNumber = twoNumbers.input();
            resultWork(firstNumber, secondNumber);

        }
    }*/


    class writeConsole
        {
            public static void Main(string[] args)
            {
                worktime.result();
                biggestNumber.consoleOut();
                twiceNumber.consoleOut();
                consoleNumber.consoleOut();
                twoNumbers.consoleOut();
                task_4_6.consoleOut();
            }
        }

    }

