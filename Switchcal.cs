using System;
class Calculator
{
	int n1,n2,n3;
	
	public void Add()
	{
			Console.WriteLine("Enter the values for Addition:");
			n1=Convert.ToInt32(Console.ReadLine());
			n2=Convert.ToInt32(Console.ReadLine());
			n3=n1+n2;
			Console.WriteLine("The added value is:"+n3);

	}
	public void Subtract()
	{
			Console.WriteLine("Enter the values for Substraction:");
			n1=Convert.ToInt32(Console.ReadLine());
			n2=Convert.ToInt32(Console.ReadLine());
			n3=n1-n2;
			Console.WriteLine("The added value is:"+n3);

	}
	public void Multiply()
	{
			Console.WriteLine("Enter the values for Multiplication:");
			n1=Convert.ToInt32(Console.ReadLine());
			n2=Convert.ToInt32(Console.ReadLine());
			n3=n1*n2;
			Console.WriteLine("The added value is:"+n3);
	}
	public void Division()
	{
			Console.WriteLine("Enter the values for Division:");
			n1=Convert.ToInt32(Console.ReadLine());
			n2=Convert.ToInt32(Console.ReadLine());
			n3=n1/n2;
			Console.WriteLine("The added value is:"+n3);
	}
	public static void Main()
	{
		char opr;

		Console.WriteLine("Press + for Addition");
		Console.WriteLine("Press - for Addition");
		Console.WriteLine("Press * for Addition");
		Console.WriteLine("Press / for Addition");
		Console.WriteLine("Enter your choice");
		opr=Convert.ToChar(Console.ReadLine());

		Calculator cl=new Calculator();

		switch(opr)
		{
			case '+':
				cl.Add();
				break;
			case '-':
				cl.Add();
				break;			
			case '*':
				cl.Add();
				break;			
			case '/':
				cl.Add();
				break;
			default:
			Console.WriteLine("Wrong choice:");
			break;
		}
	}
}