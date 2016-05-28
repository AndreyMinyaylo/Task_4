using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class worktime
    {
        public  int input(string consoleMsg = "Enter numder")
        {
            Console.WriteLine(consoleMsg);
            var time = Convert.ToInt32(Console.ReadLine());
            return time;
        }

        public  void processing(int currentTime)

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

        public  void result()
        {
            int currentTime = input(); 
            processing(currentTime);
            
        }
        
    }

    class biggestNumber
    {
        public  int input()
        {
            Console.WriteLine("Enter number");
            var time = Convert.ToInt32(Console.ReadLine());
            return time;
        }

        public  void processing(int firstNumber, int secondNumber, int thirdNumber)
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

        public  void consoleOut()
        {
            int firstNumber = input();
            int secondNumber = input();
            int thirdNumbert = input();
            processing(firstNumber, secondNumber, thirdNumbert);
        }
    }

    class twiceNumber
    {
        public  int input()
        {
            Console.WriteLine("Enter number:");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public  void number(int someNumber)
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

        public  void consoleOut()
        {
            int someNumber = input();
            number(someNumber);
        }
    }

    class consoleNumber
    {
        public  float input()
        {
            Console.WriteLine("Enter float number:");
            var number = Convert.ToSingle(Console.ReadLine());
            return number;
        }

        public  void numberFloat(float someNumber)
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

        public  void consoleOut()
        {
            float someNumber = input();
            numberFloat(someNumber);
        }

    }

    class twoNumbers
    {
        public  int input()
        {
            Console.WriteLine("Enter number:");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public  void workWithNumber(int firstNumber, int secondNumber)
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



        public  void consoleOut()
        {
            int firstNumber = input();
            int secondNumber = input();
            workWithNumber(firstNumber,secondNumber);
        }
    }

    class  task_4_6
    {
        public  void resultWork(int firstNumber, int secondNumber)
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
        public  void consoleOut()
        {
            //int firstNumber = twoNumbers.input();
            //int secondNumber = twoNumbers.input();
           // resultWork(firstNumber,secondNumber);

        }
    }

    class task_4_7
    {
        public  bool resultWork(float firstNumber, float secondNumber)
        {   
            bool someNumber = true; 
            if ((firstNumber%secondNumber != 0) || (secondNumber%firstNumber != 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public  void console(bool someNumber, float firstNumber, float secondNumber)
        {
            
            if (someNumber == true)
            {
                float result;
                if (firstNumber%secondNumber == 0) 
                {
                    result = firstNumber/secondNumber;
                    Console.WriteLine("the number of divided without a remainder: " + Math.Round(result,3));
                }
                if (secondNumber%firstNumber == 0)
                {
                    result = secondNumber/firstNumber;
                    Console.WriteLine("the number of divided without a remainder: " + Math.Round(result, 3));
                }
             else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine("the number of divided with a remainder: " + Math.Round(result, 3));
                    float result1 = secondNumber/firstNumber;
                    Console.WriteLine("the number of divided with a remainder: " + Math.Round(result1, 3));
                }
                
            }
            Console.ReadKey();
        }

        public  void consoleOut()
        {
            
            //float firstNumber = twoNumbers.input();
            //float secondNumber = twoNumbers.input();
            //bool someNumber = resultWork(firstNumber, secondNumber);
            //console(someNumber, firstNumber, secondNumber);

        }
    }

    class Task_4_8
    {
        public bool isLastEqual(int firstNumber, int secondNumber)
        {
            var a = (firstNumber%10);
            var b = (secondNumber%10);
            return a == b;
        }
    }


    class MyTestClass
        {
        public static int input(string consoleMsg = "Enter numder")
        {
            Console.WriteLine(consoleMsg);
            var time = Convert.ToInt32(Console.ReadLine());
            return time;
        }

        public static void test_4_8()
        {
            Task_4_8 testObject = new Task_4_8();
            //var a = input("Enter firstNumber");
            var a = input();
            var b = input("Enter secondNumber");
            var result = testObject.isLastEqual(a, b);
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }

        //Static methods only here!!!!!
        public static void Main(string[] args)
            {
            test_4_8();


            /*
                int time = worktime.input();
            worktime.processing(time);


            worktime.processing(134);
                int[] imputtime = {-1, 1, 2, 3, 4, 5, 6, 12, 18, 23, 24, 25};

                for (int i = 0; i < imputtime.Length; i++)
                {
                        worktime.processing(imputtime[i]);
            }
                int timew = worktime.input();
                int teimt42 = worktime.input("castom msg");
            worktime.result();

            biggestNumber.consoleOut();
                twiceNumber.consoleOut();
                consoleNumber.consoleOut();
                twoNumbers.consoleOut();
                task_4_6.consoleOut();
                task_4_7.consoleOut();*/
            }
        }

    }

