using System;

class Myclass
{
	char s;
	string n;
	int a,b;

	public Myclass()
	{
		a=b=0;
	}
	public Myclass(int m,int n)
	{
		a=m;
		b=n;
	}
	public Myclass(char sex,string name)
	{
		s=sex;
		n=name;
	}
	
	public static void Main()
	{	char sex;
		string name;
		Console.WriteLine("Enter the name and sex :");
		name=Console.ReadLine();
		sex=Convert.ToChar(Console.ReadLine());
		
		Myclass m1=new Myclass(sex,name);
		Myclass m2=new Myclass();
		Myclass m3=new Myclass(20,10);

		Console.WriteLine("For m2 \n a={0}\n b={1}",m2.a,m2.b);
		Console.WriteLine("For m3 \n a={0}\n b={1}",m3.a,m3.b);
		Console.WriteLine("For m1 \n name={0}\n sex={1}",m1.n,m1.s);
	}
}