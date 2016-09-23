using System;
class Myclass
{
	
	public static void Main()
	{	int sum=0;
		int a;
		Console.WriteLine("Enter the Limit : ");
		a=Int32.Parse(Console.ReadLine());

		for(int i=1;i<=a;i++)
		{
			sum+=i;
		}
		Console.WriteLine("The total sum is "+sum);
	}
}