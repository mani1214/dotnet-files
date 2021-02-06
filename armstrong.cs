
using System;

public class Program
{
  public static void Main()
    {
     int num=153; 
     int copy=num;
     int count=0;
     while(num >0)
     {
         int digit=num%10;
         count++;
         num=num/10;
     }
     int sum=0;
     num=copy;
     while(num >0)
     {
         int digit=num%10;
         int pvalue=1;
         for(int i=1;i<=count;i++)
         {
          pvalue= pvalue*digit;
        
         }
          sum=sum+pvalue;
          num=num/10;
     }
      if(sum == copy)
      {
          Console.WriteLine("its is armstrong number");
      }
      else
      {
          Console.WriteLine("its is not a armstrong number");
      }
    }
}