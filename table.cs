using System;
class Table
{
	public static void Main()
	{
		int num,ctr=1;
		Console.Write("Enter a number:");
		num=Convert.ToInt32(Console.ReadLine());

		while(ctr<=10)
		{
			Console.WriteLine(num*ctr);
			ctr++; 	
		}
	}
}