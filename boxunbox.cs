using System;

class Boxunbox
{
	public static void Main()
	{
		int a,c;
		a=10;

		object b=a;
		Console.WriteLine(b);

		c=(int)b;	
		Console.WriteLine(c);
	}
}