using System;
class construct
{
	public static void Main()
	{
		int num;
		Console.WriteLine("Enter the number:");
		num=Convert.ToInt32(Console.ReadLine());
		if(num%5==0)
		{
			Console.WriteLine("The number "+num+" is divisible by 5.");
		}
		else
		{
			Console.WriteLine("The number "+num+" is not divisible by 5.");			
		}
	}
}