using System.IO;
using System;

class Program
{
    static void Main()
    {
        int start=1;
        int range=5;
        int sum=0;
        for(int i=start;i<=range;i++)
        {
            sum=sum+i;
        }
        System.Console.WriteLine(sum);
    }
}