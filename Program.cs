using System.Xml.Linq;

public class BankAccount
{
    string name;
    public double Balance;

    public BankAccount(string Name, double _Balance)
    {
        name = Name;
       _Balance = Balance;
    }

    public double Deposit(double deposit)
    {
        return Balance += deposit;
    }

    public double Withdraw(double withdraw)
    {
        if (withdraw > Balance) 
        {
            throw new InvalidOperationException();
        }
        return Balance =+ withdraw;
    }
}