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
		int str;
		str=mc.accept(10,12);
		Console.WriteLine("Total value is "+str);
	}
}