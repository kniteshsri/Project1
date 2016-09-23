using System;

class CLA
{
	public static void Main()
	{
		int temp;
		int []arr=new int[10];

		Console.WriteLine("Enter 10 value in the array");
		for(int i=0;i<10;i++)
		{
			arr[i]=Int32.Parse(Console.ReadLine());
		}
		
		temp=arr[0];
		for(int i=0;i<10;i++)		
		{
			if(temp<arr[i])
			{
				temp=arr[i];
			}
		}
		Console.WriteLine("The greatest value among all 10 numbers is "+temp);
	}
}