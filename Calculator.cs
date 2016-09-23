using System;
class Calculator
{
	public static void Main()
	{
		int n1,n2,n3;
		char opr;

		Console.WriteLine("Press + for Addition");
		Console.WriteLine("Press - for Addition");
		Console.WriteLine("Press * for Addition");
		Console.WriteLine("Press / for Addition");
		Console.WriteLine("Enter your choice");
		opr=Convert.ToChar(Console.ReadLine());

		switch(opr)
		{
			case '+':
			Console.WriteLine("Enter the values for Addition:");
			n1=Convert.ToInt32(Console.ReadLine());
			n2=Convert.ToInt32(Console.ReadLine());
			n3=n1+n2;
			Console.WriteLine("The added value is:"+n3);
			break;

			case '-':
			Console.WriteLine("Enter the values for Substraction:");
			n1=Convert.ToInt32(Console.ReadLine());
			n2=Convert.ToInt32(Console.ReadLine());
			n3=n1-n2;
			Console.WriteLine("The added value is:"+n3);
			break;

			case '*':
			Console.WriteLine("Enter the values for Multiplication:");
			n1=Convert.ToInt32(Console.ReadLine());
			n2=Convert.ToInt32(Console.ReadLine());
			n3=n1*n2;
			Console.WriteLine("The added value is:"+n3);
			break;

			case '/':
			Console.WriteLine("Enter the values for Division:");
			n1=Convert.ToInt32(Console.ReadLine());
			n2=Convert.ToInt32(Console.ReadLine());
			n3=n1/n2;
			Console.WriteLine("The added value is:"+n3);
			break;

			default:
			Console.WriteLine("Wrong choioce");
			break;
		}
	}
}