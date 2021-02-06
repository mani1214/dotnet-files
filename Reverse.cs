using System.IO;
using System;

class Program
{
    static void Main()
    {
         int num = 122;
         int rev=0;
         while (num !=0)
{
         int digit = num%10;
         rev = rev * 10 + digit;
         num = num/10;
}
    System.Console.WriteLine(rev);
}
}