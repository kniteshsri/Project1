using System;

class conspara
{
	int n1,n2;
	public conspara(int a,int b)
	{
		n1=a;
		n2=b;
	}
	public void disp()
	{
		Console.WriteLine("The first value is : "+n1);
		Console.WriteLine("The second value is : "+n2);
	}
	public static void Main()
	{
		conspara cp=new conspara(5,8);
		cp.disp();
	}
}