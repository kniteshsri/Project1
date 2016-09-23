using System;
class construct
{
	public static void Main()
	{
		int x;
		Console.WriteLine("Enter the number:");
		x=Convert.ToInt32(Console.ReadLine());
		if(x==1)
		{
			Console.WriteLine("Sunday");	
		}
		else if(x==2)
		{
			Console.WriteLine("Monday");	
		}
		else if(x==3)
		{
			Console.WriteLine("Tuesday");	
		}
		else if(x==4)
		{
			Console.WriteLine("Wednesday");	
		}
		else if(x==5)
		{
			Console.WriteLine("Thursday");	
		}
		else if(x==6)
		{
			Console.WriteLine("Friday");	
		}
		else if(x==7)
		{
			Console.WriteLine("Saturday");	
		}
		else 
		{
			Console.WriteLine("Invalid day number");	
		}
	}
}
		