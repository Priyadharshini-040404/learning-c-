using System;

class Student
{
	// Fields
	private string name;
	private int age;

	// Properties
	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public int Age
	{
		get { return age; }
		set
		{
			if (value >= 0) age = value;
			else age = 0; // prevent negative age
		}
	}

	// Constructor 1: Default
	public Student() : this("Unknown", 0)
	{
		Console.WriteLine("Default constructor executed");
	}

	// Constructor 2: Parameterized
	public Student(string name, int age)
	{
		Name = name;
		Age = age;
		Console.WriteLine("Parameterized constructor executed");
	}

	// Method Overloading

	// 1. No parameter
	public void DisplayInfo()
	{
		Console.WriteLine("No student info provided");
	}

	// 2. One parameter
	public void DisplayInfo(string name)
	{
		Console.WriteLine("Student Name: " + name);
	}

	// 3. Two parameters
	public void DisplayInfo(string name, int age)
	{
		Console.WriteLine($"Student Name: {name}, Age: {age}");
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("-----Student 1-----");
		Student s1 = new Student();          // Default constructor → constructor chaining
		s1.DisplayInfo();                     // Method overloading demo
		s1.DisplayInfo("Unknown Student");
		s1.DisplayInfo("Unknown Student", 0);

		Console.WriteLine("\n-----Student 2-----");
		Student s2 = new Student("Indira", 20); // Parameterized constructor
		s2.DisplayInfo();
		s2.DisplayInfo("Indira");
		s2.DisplayInfo("Indira", 20);
	}
}
