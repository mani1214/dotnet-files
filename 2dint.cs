using System.IO;
using System;

class Program
{
    static void Main()
    {
       int[,] a={ {1,2,3},{4,5,6},{7,8,9}};
       for(int i=0;i<3;i++)
       {
        for(int j=0;j<3;j++)
        {
            Console.Write("{0}\t",a[i,j]);
        }
             Console.WriteLine();
       }
    }
}