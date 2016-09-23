using System;
class construct
{
	public static void Main()
	{
		int num;
		Console.WriteLine("Enter the number:");
		num=Convert.ToInt32(Console.ReadLine());
		if(num%2==0)
		{
			Console.WriteLine(num+" is even.");
		}
		else
		{
			Console.WriteLine(num+" is odd.");			
		}
	}
}