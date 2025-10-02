using System;
class Program
{
	static void Main()
	{
		var x = 10; 
		Console.WriteLine("var x = " + x);
		dynamic y = 10;
		Console.WriteLine("dynamic y = " + y);
		y = "Hello";    
		Console.WriteLine("dynamic y = " + y);
		Console.WriteLine(y.Length);
	}
}
