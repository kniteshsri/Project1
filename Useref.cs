using System;

class Addition
{
	public void add(ref int n1,ref int n2,out int res)
	{
		res=n1+n2;
	}

	public static void Main()
	{
		Addition aa=new Addition();
		int a,b,c;
		Console.WriteLine("Enter 1st value : ");
		a=Int32.Parse(Console.ReadLine());
		Console.WriteLine("Enter 2st value : ");
		b=Int32.Parse(Console.ReadLine());
		
		aa.add(ref a,ref b,out c);
		Console.WriteLine("The added value is :"+c);
	}
}