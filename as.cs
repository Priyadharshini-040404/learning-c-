using System;
class Animal
{
    public string Name = "Dog";
}
class Program
{
    static void Main()
    {
        object obj1 = "Hello World";
        string str1 = obj1 as string;  
        Console.WriteLine(str1 ?? "Conversion failed"); 
        object obj2 = 123;
        string str2 = obj2 as string; 
        Console.WriteLine(str2 ?? "Conversion failed"); 
        object obj3 = new Animal();
        Animal a = obj3 as Animal; 
        Console.WriteLine(a != null ? a.Name : "Conversion failed"); 
    }
}
