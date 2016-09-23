using System;

class oper
{
	int n1;
	public oper(int a)
	{
		n1=a;
	}

	public void disp()
	{
		Console.WriteLine(n1);
	}

	public static oper operator --(oper op)
	{
		op.n1--;

		return op;
	}

	public static void Main()
	{
		oper opr1=new oper(5);
		oper opr2=new oper(10);
		opr1.disp();
		opr2.disp();
		Console.WriteLine("=================================");
		opr1=--opr2;
		opr1.disp();
		opr2.disp();
		Console.WriteLine("=================================");
		opr1=opr2--;
		opr1.disp();
		opr2.disp();
	}
}