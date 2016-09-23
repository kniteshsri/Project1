//    INSTANT CONSTRUCTOR.
using System;

class usecons
{
	int n=10;
	public usecons()
	{
		Console.WriteLine("Constroctor called");
		Console.WriteLine("Value of the number is :"+n);
	}
	public static void Main()
	{
		usecons us=new usecons();
	}
}
