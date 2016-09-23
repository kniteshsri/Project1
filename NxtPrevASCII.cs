using System;

class Adjacent
{
	public static void Main()
	{
		int n;
		char ch,ch1;

		Console.Write("Enter a character whose ascii code is to be generated:");
		Console.Write("\t");
		ch=Convert.ToChar(Console.ReadLine());
		n=ch;

		Console.Write("\n The ASCII code for {0} is {1}",ch,n);

		ch1=Convert.ToChar(n-1);
		Console.Write("\n The Previous ASCII code for {0} is {1}",ch,n-1);
		Console.Write(" which stands for {0}",ch1);

		ch1=Convert.ToChar(n+1);
		Console.Write("\n The Next ASCII code for {0} is {1}",ch,n+1);
		Console.Write(" which stands for {0}",ch1);
	}
}