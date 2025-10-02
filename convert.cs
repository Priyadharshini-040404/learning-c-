using System;
class Program
{
    static void Main()
    {
        string strNumber = "123";
        int num = Convert.ToInt32(strNumber);
        Console.WriteLine("String to int: " + num); 
        double d = 45.67;
        int i = Convert.ToInt32(d);
        Console.WriteLine("Double to int: " + i);  
        bool flag = true;
        string strFlag = Convert.ToString(flag);
        Console.WriteLine("Bool to string: " + strFlag); 
        object obj = 999;
        string strObj = Convert.ToString(obj);
        Console.WriteLine("Object to string: " + strObj);
    }
}
