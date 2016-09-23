using System;

class Myclass
{
	bool res;
	public bool result(string n,string o)
	{
		char []ch1= n.ToCharArray(); 
		char []ch2= o.ToCharArray();

		int k=o.Length-1;
		for(int i=0;i<k;i++)
		{
			if(ch1[i]==ch2[i])
			{res=true;}
			else
			{res=false;}
		}
		return res;
	}

	public bool result(int a,int b)
	{
		if(a/b==0)
		{res=true;}
		return res;
	}
	
	public void result(int a,int b,int c)
	{
		if(a>b)
		{
			if(a>c)
			{
				Console.WriteLine(a+"is greatest");
			}	
			else
			{
				Console.WriteLine(c+"is greatest");
			}	
		}
		else
		{
			if(b>c)
			{
				Console.WriteLine(b+"is greatest");
			}	
			else
			{
				Console.WriteLine(c+"is greatest");
			}	
		
		}
	}
	
	public static void Main()
	{
		Myclass r1=new Myclass();
		
		bool val;
		val = r1.result("Nitesh","Nitesh");
		Console.WriteLine(val);
		val = r1.result(20,10);
		Console.WriteLine(val);
		r1.result(55,17,62);
	}
}