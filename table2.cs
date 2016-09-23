using System;

class Myclass
{
	public static void Main()	
	{
		int num1,val;
		Console.Write("Enter a number:");
		num1=Convert.ToInt32(Console.ReadLine());

		for(int i=1;i<=10;i++)
		{
			val=num1*i;
			Console.WriteLine(num1+"*"+i+"="+val);
		}
	}
}