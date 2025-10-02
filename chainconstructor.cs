using System;
class Student
{
    private string name;
    private int age;
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
            else age = 0; 
        }
    }
    public Student() : this("Unknown", 0)
    {
        Console.WriteLine("Default constructor executed");
    }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Parameterized constructor executed");
    }
    public void DisplayInfo()
    {
        Console.WriteLine("No student info provided");
    }
    public void DisplayInfo(string name)
    {
        Console.WriteLine("Student Name: " + name);
    }
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
        Student s1 = new Student();          
        s1.DisplayInfo();                     
        s1.DisplayInfo("Unknown Student");
        s1.DisplayInfo("Unknown Student", 0);

        Console.WriteLine("\n-----Student 2-----");
        Student s2 = new Student("Indira", 20); 
        s2.DisplayInfo();
        s2.DisplayInfo("Indira");
        s2.DisplayInfo("Indira", 20);
    }
}
