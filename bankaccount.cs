using System;

class BankAccount{

  private string accountNumber;
  protected double balance;
  private DateTime dateCreated;

  private string AccountNumber{
    get{return accountNumber;}
    set{
      if (value.Length == 6)
        accountNumber = value;
      else
        Console.WriteLine("Account number must be 6 digits in length.");
    }
  }

  private string Name {get; set;}
  private double Balance {
    get{return balance;}
    set{
      if (value >= 0)
        balance = value;
      else
        Console.WriteLine("Starting account balance cannot be negative.");
    }
  }
  private DateTime DateCreated{
    get{return dateCreated;}
    set{
      if(value < DateTime.Now)
        dateCreated = value;
      else
        Console.WriteLine("Account creation date cannot be in the future.");
    }
  }

  public BankAccount()
  {
    DateCreated = DateTime.Now;
  }

  public BankAccount(string accnbr, string nme, double bal)
  {
    AccountNumber = accnbr;
    Name = nme;
    Balance = bal;
    DateCreated = DateTime.Now;
  }

  public void DisplayAccountInfo()
  {
    Console.WriteLine("Account number: {0}", AccountNumber);
    Console.WriteLine("Name: {0}", Name);
    Console.WriteLine("Balance: {0}", Balance);
  }

  public void Deposit(double amount)
  {
    Balance += amount;
    Console.WriteLine("Balance: {0}", Balance);
  }

  public virtual void Withdraw(double amount)
  {
    if (Balance > amount)
      Balance -= amount;
    else
      Console.WriteLine("Error, withdrawal amount cannot be greater than balance");
    Console.WriteLine("Balance: {0}", Balance);
  }

  public virtual void CalculateInterest(int years)
  {
    Console.WriteLine("This method will calculate interest.");
  }
}