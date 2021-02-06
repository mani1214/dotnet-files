using System.IO;
using System;

class Program
{
    static void Main()
    {
         int num = 121;
         int temp = num;
         int rev=0;
         while (num !=0)
{
         int digit = num%10;
         rev = rev * 10 + digit;
         num = num/10;
}
         if(temp == rev)
         {
             System.Console.WriteLine("it is palindrome");
         }
         else
         {
             System.Console.WriteLine("it is not a palindrome");
         }
    }
}