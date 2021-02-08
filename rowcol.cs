using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

 

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                    sum += arr[i, j];
                }
                Console.Write("======>" + sum);
                Console.WriteLine();
            }
            for (int i = 0; i <3; i++)
            {
                int sum = 0;
                for (int j = 0; j <3; j++)
                {
                    sum += arr[j, i];
                }
                Console.Write( sum  + "\t");
            }
    
      }
}