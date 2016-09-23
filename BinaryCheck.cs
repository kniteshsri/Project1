using System;
class Binarygen
{
	public static void Main()
	{
		int []arr=new int[20];
		int r,n,k;
		n=r=k=0;
		Console.Write("Enter a number to find its binary code:\t");
		n=Int32.Parse(Console.ReadLine());

		for(int i=0;n!=0||n!=1;i++)
		{
			r=n%2;
			n=n/2;
			arr[i]=r;
			k++;
		}
		arr[k]=n;

		Console.Write("\n The Binary code for {0} is:",n);
		for(int j=k;j>=0;j--)
			Console.Write(arr[j]);
	}
}