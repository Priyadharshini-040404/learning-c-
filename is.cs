using System;

class Animal { }
class Dog : Animal { }

class Program
{
    static void Main()
    {
        object obj1 = "Hello World";
        object obj2 = 123;
        object obj3 = new Dog();
        Console.WriteLine(obj1 is string); 
        Console.WriteLine(obj2 is string); 
        Console.WriteLine(obj3 is Animal);
        Console.WriteLine(obj3 is Dog);  
    }
}
