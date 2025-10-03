using System;
using System.Collections.Generic;
using System.Linq;
public interface IEntity
{
    int Id { get; set; }
}
public class Repository<T> where T : IEntity
{
    private List<T> items = new List<T>(); 
    public void Add(T item)
    {
        items.Add(item);
        Console.WriteLine($"Item with Id {item.Id} added successfully!");
    }
    public void Update(int id, T newItem)
    {
        int index = items.FindIndex(x => x.Id == id);
        if (index != -1)
        {
            items[index] = newItem;
            Console.WriteLine($"Item with Id {id} updated successfully!");
        }
        else
        {
            Console.WriteLine($"Item with Id {id} not found!");
        }
    }
    public void Delete(int id)
    {
        T item = items.FirstOrDefault(x => x.Id == id);
        if (item != null)
        {
            items.Remove(item);
            Console.WriteLine($"Item with Id {id} deleted successfully!");
        }
        else
        {
            Console.WriteLine($"Item with Id {id} not found!");
        }
    }
    public List<T> GetAll()
    {
        return items;
    }
    public T GetById(int id)
    {
        return items.FirstOrDefault(x => x.Id == id);
    }
}
public class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}
class Program
{
    static void Main()
    {
        Repository<Product> productRepo = new Repository<Product>();
        Product p1 = new Product { Id = 1, Name = "Laptop" };
        Product p2 = new Product { Id = 2, Name = "Phone" };
        productRepo.Add(p1);
        productRepo.Add(p2);
        Console.WriteLine("\nAll Products:");
        foreach (var item in productRepo.GetAll())
        {
            Console.WriteLine(item);
        }
        Product updatedP1 = new Product { Id = 1, Name = "Gaming Laptop" };
        productRepo.Update(1, updatedP1);
        productRepo.Delete(2);
        Console.WriteLine("\nProducts after update and delete:");
        foreach (var item in productRepo.GetAll())
        {
            Console.WriteLine(item);
        }
        Product getProduct = productRepo.GetById(1);
        Console.WriteLine($"\nGet product by Id 1: {getProduct}");
    }
}
