using System;

class pyramid
{
	public static void Main()
	{
		for(int i=1;i<=5;i++)
		{
			for(int j=5;j>=i;j--)
			{
				Console.Write(" ");
			}
			for(int k=1; k<=i; k++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}