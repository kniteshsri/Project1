using System;

class oper
{
	int n1,n2,n3;
	public oper(int a,int b,int c)
	{
		n1=a;
		n2=b;
		n3=c;
	}

	public void disp()
	{
		Console.WriteLine(n1);
		Console.WriteLine(n2);
		Console.WriteLine(n3);
	}

	public static oper operator -(oper op)
	{
		op.n1=-op.n1;
		op.n2=-op.n2;
		op.n3=-op.n3;

		return op;
	}

	public static void Main()
	{
		oper opr=new oper(5,10,-15);
		opr.disp();
		Console.WriteLine("=================================");
		opr=-opr;
		opr.disp();
	}
}