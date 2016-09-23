using System;
class construct
{
	public static void Main()
	{
		int num1,num2,num3;
		Console.WriteLine("Enter the first number:");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the second number:");
		num2=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the third number:");
		num3=Convert.ToInt32(Console.ReadLine());
		
		if(num1>num2)
		{
			if(num1>num3)
			{
				Console.WriteLine(num1+"is greatest");
			}	
			else
			{
				Console.WriteLine(num3+"is greatest");
			}	
		}
		else
		{
			if(num2>num3)
			{
				Console.WriteLine(num2+"is greatest");
			}	
			else
			{
				Console.WriteLine(num3+"is greatest");
			}	
		
		}
	}
}