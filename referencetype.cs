using System;
class person
{
    public int age = 15;
}
class changeage
{
    static void Main()
    {
        person a = new person();
        a.age++;
        Console.WriteLine("updated age is:" + a.age);
     }
}
