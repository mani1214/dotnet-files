
using System;

public class Program
{
    public static void Main()
    {
        int[,] a= new int[3,3];
        Console.WriteLine("enter the array element");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                a[i,j]= int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Array elements are");
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