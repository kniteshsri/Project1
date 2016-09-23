using System;
class UseOpr
{
	public static void Main()
	{
		int x,y;
		Console.Write("Enter first value:");
		x=Convert.ToInt32(Console.ReadLine());			

		Console.Write("Enter second value:");
		y=Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Before using operator:");
		Console.WriteLine("X="+x);
		Console.WriteLine("Y="+y);
		x+=y;                   //x=x+y
		Console.WriteLine("After Operation");
		Console.WriteLine("X="+x);
		Console.WriteLine("Y="+y);
	}
}