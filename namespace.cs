using System;
namespace MyNamespace
{
    class MyClass
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from MyNamespace!");
        }
    }
}
class Program
{
    static void Main()
    {
        // Create object of MyClass inside MyNamespace
        MyNamespace.MyClass obj = new MyNamespace.MyClass();
        obj.SayHello();  // Call the method
    }
}
