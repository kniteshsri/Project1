using System;

class Usestatic
{
	static int num=10;
	static char choice='y';

	public static void Mymethod()
	{
		Console.WriteLine("Num="+num);
		Console.WriteLine("Choice="+choice);
	}

	public static void Main()
	{
		Usestatic.Mymethod();
	}
}