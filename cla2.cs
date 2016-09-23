using System;
class Myclass
{
	public static void Main(string []args)
	{
		int a=0;
		string b;
		a=Int32.Parse(args[0]);
		b=(args[1]);

		Console.WriteLine("The number is "+a);
		Console.WriteLine("The name is "+b);
	}
}