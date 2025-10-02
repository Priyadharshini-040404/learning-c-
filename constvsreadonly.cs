using System;
class Student
{
    public const string SchoolName = "ABC School";
    public readonly string StudentName;
    public readonly int RollNumber;
    public Student(string name, int roll)
    {
        StudentName = name; 
        RollNumber = roll;  
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("School Name: " + Student.SchoolName);
        Student s1 = new Student("Indira", 101);
        Student s2 = new Student("Priya", 102);
        Console.WriteLine($"Student1: {s1.StudentName}, Roll: {s1.RollNumber}");
        Console.WriteLine($"Student2: {s2.StudentName}, Roll: {s2.RollNumber}");
    }
}
