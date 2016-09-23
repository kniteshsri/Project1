using System;

class Myclass
{
	public void disp(int num)
	{
		num++;
	}

	public static void Main()
	{
		Myclass mc=new Myclass();
		int a;
		Console.Write("Enter a value:");
		a=Int32.Parse(Console.ReadLine());
		mc.disp(a);
		Console.WriteLine("Value of "+a+"is "+a);
	}	
}