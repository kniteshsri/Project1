using System;

public class shellsort
{
	public static void Main()
	{
		int[] num=new int[10];
		int i,j,increment,temp;
		increment=3;

		//for inserting values.
		for(i=0;i<10;i++)
		{
			Console.WriteLine("Enter the value:");
			num[i]=Int32.Parse(Console.ReadLine());
		}

		//for displaying values. 
		Console.WriteLine("\nNumbers in array before sorting are");
		for(i=0;i<10;i++)
		Console.WriteLine("{0}\t",num[i]);
		
		//for sorting of values
		while(increment>0)
		{
			for(i=0;i<10;i++)	
			{
				j=1;
				temp=num[i];
				while((j>=increment)&&(num[j-increment]>temp))
				{
					num[j]=num[j-increment];
					j=j-increment;
				}
				num[j]=temp;
			}
			increment--;
		}

		//for displaying values. 
		Console.WriteLine("\nNumbers in array before sorting are");
		for(i=0;i<10;i++)
		Console.WriteLine("{0}\t",num[i]);
	}
}