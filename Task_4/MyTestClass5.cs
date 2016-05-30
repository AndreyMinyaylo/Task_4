using System;

public class MyClass
{
    public static void convertToBin(int number)
    {
        if (number == 1)
        {
            Console.Write(number);
            return;
        }
        
        convertToBin(number/2);
        
        
    }


    public static void Main()
    {
        convertToBin(13);
    }
	}
