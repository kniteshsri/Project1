using System;
class Myclass
{
	public int add(int n)
	{
		int res=0;
		if(n==1)
		{
			res=1;
			return res;
		}
		else
		{
			res=add(n-1)+n;
			return res;
		}
	}

	public static void Main()
	{	
		Myclass m=new Myclass();
		int a;
		Console.WriteLine("Enter the Limit : ");
		a=Int32.Parse(Console.ReadLine());

		Console.WriteLine("The total sum is "+m.add(a));
	}
}