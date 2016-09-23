//Program to check whether a number is prime or not.

using System;

class Primecheck
{
	public static void Main()
	{
		bool prime=true;
		int num;

		Console.WriteLine("Enter a number to check it for prime:=>");
		num=Int32.Parse(Console.ReadLine());

		for(int i=2;i<=num;i++)
		{
			if(num%i==0)
			{
				prime=false;
				break;
			}
		}

		if(prime==false)
		Console.WriteLine("The number is Prime.");
		else
		Console.WriteLine("The number is not Prime.");

		Console.ReadLine();
	}
}