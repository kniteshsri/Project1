using System;

class factorial
{
	int f=1;
	public int factor(int s)
	{
		for(int i=s;i>0;i--)
		{
			f *= i;
			if(i<1)
			{
				break;
			}
		}
		return f;
	}

	public static void Main()
	{
		int x,y;
		factorial fac=new factorial();
		Console.Write("Enter the value for factorial= ");
		x=Convert.ToInt32(Console.ReadLine());
		y=fac.factor(x);
		Console.WriteLine("The Factorial of"+x+"is="+y);
	}
}