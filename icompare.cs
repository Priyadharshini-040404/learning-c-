using System;
using System.Collections.Generic;
public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CompareTo(Person other)
    {
        if (other == null) return 1;
        return this.Age.CompareTo(other.Age);
    }
    public override string ToString()
    {
        return $"{Name} - {Age}";
    }
}
class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 20 },
            new Person { Name = "Charlie", Age = 30 },
            new Person { Name = "Diana", Age = 22 }
        };
        Console.WriteLine("Before sorting:");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
        people.Sort();

        Console.WriteLine("\nAfter sorting by Age:");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
}
