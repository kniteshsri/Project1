using System;
class compare
{
	public static void Main()
	{
		int x,y,sum;
		Console.WriteLine("Enter two number:");
		x=Convert.ToInt32(Console.ReadLine());
		y=Convert.ToInt32(Console.ReadLine());
		
		sum=x+y;

		if(sum>100)
		{
			Console.WriteLine(sum+"is greater than 100");	
		}
		else if(sum<100)
		{
			Console.WriteLine(sum+"is less than 100");	
		}
	}
}