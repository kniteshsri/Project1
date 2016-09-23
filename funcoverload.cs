using System;

class funcoverload
{
	double area;
	public void Area(int h,int b)
	{
		area=0.5*h*b;
		Console.WriteLine("The area of the triangle is "+area);
	}

	public void Area(float l,float b)
	{
		float f= l*b;
		area=(double)f;
		Console.WriteLine("The area of the rectangle is "+area);
	}

	public void Area(int r)
	{
		area =(22/7)*r*r;
		Console.WriteLine("The area of the rectangle is "+area);
	}

}

class Mainclass
{
	public static void Main()
	{
		funcoverload fo =new funcoverload();
		
		fo.Area(5,4);
		fo.Area(5f,4f);
		fo.Area(5);
	}
}