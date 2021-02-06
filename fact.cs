using System.IO;
using System;

class Program
{
    static void Main()
    {
         int fact=1;
         int num =5;
         for(int i=1;i<=num;i++)
         {
             fact=i*fact;
         }
         System.Console.WriteLine(fact);
    }
}