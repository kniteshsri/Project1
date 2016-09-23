using System;
class UseUnary
{
	public static void Main()
	{
		int x,y;
		x=10;
		y=0;
		Console.WriteLine("X="+x);
		Console.WriteLine("Y="+y);
		
		y=x++;
		Console.WriteLine("X="+x);
		Console.WriteLine("Y="+y);
		y=++x;
		Console.WriteLine("X="+x);
		Console.WriteLine("Y="+y);
		y=x--;
		Console.WriteLine("X="+x);
		Console.WriteLine("Y="+y);
		y=--x;
		Console.WriteLine("X="+x);
		Console.WriteLine("Y="+y);
	}
}