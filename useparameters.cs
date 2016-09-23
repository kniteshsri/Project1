using System;
class Mymethod
{
	public int accept(int x,int y)
	{
		int a;
		a=x+y;
		return a;
	}

	public static void Main()
	{
		Mymethod mc=new Mymethod();
		int str,c,d;
		Console.Write("Enter two numbers ");
		c=Convert.ToInt32(Console.ReadLine());
		d=Convert.ToInt32(Console.ReadLine());

		str=mc.accept(c,d);
		Console.WriteLine("The total value is"+str);
	}
}