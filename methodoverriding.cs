using System;
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}
class Program
{
    static void Main()
    {
        Animal animal;
        animal = new Dog();
        animal.Speak();   
        animal = new Cat();
        animal.Speak();   
    }
}
