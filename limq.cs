using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Department { get; set; }
	public int Salary { get; set; }
}
class Program
{
	static void Main()
		var employees = new List<Employee>
		{
			new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
			new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 70000 },
			new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 80000 },
			new Employee { Id = 4, Name = "David", Department = "Finance", Salary = 60000 },
			new Employee { Id = 5, Name = "Eve", Department = "HR", Salary = 55000 }
		};
		Console.WriteLine("Employees in IT Department:");
		var itEmployees = employees.Where(e => e.Department == "IT");
		foreach (var emp in itEmployees)
			Console.WriteLine($"{emp.Name} - {emp.Department}");
		Console.WriteLine();
		Console.WriteLine("Employees ordered by Salary (descending):");
		var ordered = employees.OrderByDescending(e => e.Salary);
		foreach (var emp in ordered)
			Console.WriteLine($"{emp.Name} - {emp.Salary}");
		Console.WriteLine();
		Console.WriteLine("Employee Names and Salaries:");
		var namesAndSalaries = employees.Select(e => new { e.Name, e.Salary });
		foreach (var emp in namesAndSalaries)
			Console.WriteLine($"{emp.Name} - {emp.Salary}");
		Console.WriteLine();
		Console.WriteLine("Employees grouped by Department:");
		var groups = employees.GroupBy(e => e.Department);
		foreach (var group in groups)
		{
			Console.WriteLine($"Department: {group.Key}");
			foreach (var emp in group)
				Console.WriteLine($"   {emp.Name} - {emp.Salary}");
		}
	}
}
