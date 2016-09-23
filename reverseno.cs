using System;
class Usewhile
{
	public static void Main()
	{
		int num,rev;
		Console.Write("Enter a number");
		num=Convert.ToInt32(Console.ReadLine());
		while(num>0)
		{
			rev=num%10;
			Console.Write(rev);
			num=num/10;	
		}
	}
}