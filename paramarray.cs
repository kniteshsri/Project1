using System;

class param
{

	public int accept(params int[]list)
	{
		int result=0;
		foreach(int i in list)
		{
			result+=1;
		}
		Console.WriteLine(result);
		return result;
	}
	
	public static void Main()
	{
		param arr=new param();
		arr.accept(1,2,3,4,5,7,34,42,98,75,985,1,342,74,67743,46);
	}	
}