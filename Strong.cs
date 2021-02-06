using System.IO;
using System;

class Program
{
   static void Main(string[] args)
        {
            int num = 145;
            int copy = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                int start = 1;
                int fact = 1;
                while (start <= digit)
                {
                    fact = fact * start;
                    start++;
                }
                sum = sum + fact;
                num = num / 10;
            }
            if (copy == sum)
            {
                Console.WriteLine($"{copy} is Strong number");
            }
            else
            {
                Console.WriteLine($"{copy} is not strong number");
            }
}
}