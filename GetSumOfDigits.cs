using System;
					
public class Program
{ 
	public static int GetSumOfDigits(int num){
	  if(num>99)
	  {
		  return -2;
	  }
	   if(num<0)
	   {
		   return -3;
	   }
	   if(num==0 && num <=9)
	   {
		   return -1;
	   }
		return num%10+num/10;
	} 
		public static void Main()
	{
	   Console.WriteLine(GetSumOfDigits(99));
	   Console.WriteLine(GetSumOfDigits(-1));
	   Console.WriteLine(GetSumOfDigits(9));
	   Console.WriteLine(GetSumOfDigits(991));
	}
}