using System;

class CLA
{
	public static void Main()
	{
		int n;
		Console.WriteLine("How many numbers do u want to enter");
		n=Int32.Parse(Console.ReadLine());
		int [] arr=new int[n];

		Console.WriteLine("Enter {0} value in the array",n);
		for(int i=0;i<n;i++)
		{
			arr[i]=Int32.Parse(Console.ReadLine());
		}
		
		for(int i=0;i<n;i++)
		{
			Console.WriteLine("The array is")
			Console.WriteLine("\n"+arr[i]);
		}
	}
}