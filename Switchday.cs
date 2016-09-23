using System;
class Weekdays
{
	public static void Main()
	{
		int X;
		Console.Write("Enter the day no:");
		X=Convert.ToInt32(Console.ReadLine());

		switch(X)
		{
			case 1 :
			Console.WriteLine("Sunday");
			break;
			case 2 :
			Console.WriteLine("Monday");
			break;
			case 3 :
			Console.WriteLine("Tuesday");
			break;
			case 4 :
			Console.WriteLine("Wednesday");
			break;
			case 5 :
			Console.WriteLine("Thursday");
			break;
			case 6 :
			Console.WriteLine("Friday");
			break;
			case 7 :
			Console.WriteLine("Saturday");
			break;
			default :
			Console.WriteLine("INVALID day no.");
			break;

		}
	}
}