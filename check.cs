using System;

class check
{
	public static void Main()
	{
		int i,j;
		Console.WriteLine("Enter two numbers ");
		i=Convert.ToInt32(Console.ReadLine());
		j=Convert.ToInt32(Console.ReadLine());

		if(i==j)
		{
			Console.WriteLine("Both the numbers are equal");
		}
		else if(i>j)
		     {
			Console.WriteLine(i+"is greater");
		     }
		else
		{
			Console.WriteLine(j+"is greater");
		}
	}
}