using System;

class Method
{
	int a;
	public int accept(int x,int y)	
	{
		a=x+y;
		return a;
	}

	public static void Main()
	{
		Method mc=new Method();
		int str,c,d;
		Console.WriteLine("Enter two values");
		c=Int32.Parse(Console.ReadLine());
		d=Int32.Parse(Console.ReadLine());
		str=mc.accept(c,d);
		Console.WriteLine("Total value is "+str);
	}
}