using System;

class usecons
{
	static int n=10;
	static usecons()
	{
		Console.WriteLine("Constroctor called");
		Console.WriteLine("Value of the number is :"+n);
	}
	public static void Main()
	{
		usecons us=new usecons();
	}
}
