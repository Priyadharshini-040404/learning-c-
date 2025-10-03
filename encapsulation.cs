using System;
public class bankaccount
{
    private double balance;
    public double Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value >= 0)
                balance = value;
            else
                balance = 0;
        }
        
    }
    public void deposit (double amount)
    {
        balance += amount;
    }
    public void withdraw(double amount)
    {
        balance -= amount;
    }
}
class progrm
{
    static void Main (string[] args)
    {
        bankaccount account=new bankaccount();
        Console.WriteLine("Current Balance:" + account.Balance);
        account.deposit(500);
        Console.WriteLine("Deposited Balance:" + account.Balance);
        account.withdraw(100);
        Console.WriteLine("Withdrawn Balance:" +account.Balance);
    }
}