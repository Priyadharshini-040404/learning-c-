using System;
using System.Collections;
using System.Collections.Generic;
class Company : IEnumerable<string>
{
    public List<string> Employees = new List<string> { "Alice", "Bob" };
    public List<string> Departments = new List<string> { "HR", "IT" };
    public IEnumerator<string> GetEnumerator()
    {
        foreach (var e in Employees) 
            yield return e;
        foreach (var d in Departments) 
            yield return d;
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
class Program
{
    static void Main()
    {
        Company company = new Company();
        foreach (var item in company)
        {
            Console.WriteLine(item);
        }
    }
}
