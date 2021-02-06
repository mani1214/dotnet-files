using System.IO;
using System;

class Program
{
    static void Main()
    {
         int num = 1238;
            while (num != 0)
            {
                int digit = num % 10;
                Console.WriteLine(digit);
                num = num / 10;
            }
    }
}