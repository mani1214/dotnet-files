using System.IO;
using System;

class Program
{
    static void Main()
    {
       int num=10;
       bool flag=false;
       for(int i=2;i<=num/2;i++)
       {
           
        if(num % i ==0){
            flag=true;
            break;
        }
       }
       if(!flag){
            System.Console.WriteLine("its a prime number");
        }
        else
        {
            System.Console.WriteLine("its not a prime number");
        }
}
}