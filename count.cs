using System.IO;
using System;

class Program
{
    static void Main()
    {
        int num=121;
        int count=0;
        while(num !=0)
        {
            num=num/10;
            count++;
        }
        System.Console.WriteLine(count);
    }
}