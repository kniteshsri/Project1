using System;

class selectionsort1
{
	public void selectionsort(int[] arr1)
	{
		int temp;
		for(int i=0;i<5;i++)
		{
			for(int j=i+1;j<5;j++)
			{
				if(arr1[i]>arr1[j])
				{
					temp=arr1[i];
					arr1[i]=arr1[j];
					arr1[j]=temp;
				}
			}
			Console.WriteLine(arr1[i]);
		}
	}

	public static void main()
	{
		selectionsort1 sr=new selectionsort1();
		int[] arr=new int[10];
		Console.WriteLine("\nEnter 5 values:-");
		for(int i=0;i<5;i++)
		{
			arr[i]=Int32.Parse(Console.ReadLine());
		}
		Console.WriteLine("Sorted List is::");
		sr.selectionsort();
		
	}
}