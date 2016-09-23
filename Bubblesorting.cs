using System;

class sorting
{
	int[]arr=new int[5];
	int temp;

	public void accept()
	{
		Console.WriteLine("\nEnter the numbers");
		for(int i=0;i<5;i++)
		{
			arr[i]=Int32.Parse(Console.ReadLine());
		}
	}

	public void sort()
	{
		for(int i=0;i<5-1;i++)
		{
			if(arr[i]>arr[i+1])
			{
				temp=arr[i]; 
				arr[i]=arr[i+1]; 
				arr[i+1]=temp;
			}
		}
	}

	public void disp()
	{
		Console.WriteLine("\nAfter sorting the value in ascending order is: ");
		for(int i=0;i<5;i++)
		{
			Console.Write(arr[i]+"\t");
		}
		Console.WriteLine();
	}

	public static void Main()
	{
		sorting srt = new sorting();
		srt.accept();
		srt.sort();
		srt.disp();
	}
}