using System;

// Part 1 of Student class
public partial class Student
{
	public string Name { get; set; }
	public int Age { get; set; }

	// Partial method declaration (no public/private)
	partial void ShowDetails();
}

// Part 2 of Student class
public partial class Student
{
	// Implementation of partial method
	partial void ShowDetails()
	{
		Console.WriteLine($"Name: {Name}, Age: {Age}");
	}

	// Public method that calls partial method
	public void Print()
	{
		ShowDetails();
	}
}

// Main Program
class Program
{
	static void Main()
	{
		Student s1 = new Student { Name = "Indira", Age = 21 };
		s1.Print();
	}
}
