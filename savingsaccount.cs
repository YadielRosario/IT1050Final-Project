using System;

class SavingsAccount : BankAccount
{
  

  private double Balance{
    get {return balance;}
    set {
      if (value < 2500)
        Console.WriteLine("Balance cannot be below 2500.");
      else
        balance = value;
    }
  } 

  public SavingsAccount() : base()
  {

  }

  public SavingsAccount(string accnbr, string nme, double bal) : base(accnbr, nme, bal)
  {

  }

  public override void CalculateInterest(int years)
  {
    /*A= P(1+rt)
    P is principal so balance
    r is rate so APR
    time is years
    A is amount after interest so write that to new Balance
    */
    base.CalculateInterest(years);
    double interest;
    interest = (Balance * (1 + (0.05 * years)));
    Balance = interest;
    Console.WriteLine("Added interest and updated Balance.");
    Console.WriteLine("Balance: {0}", Balance);

  }

  public override void Withdraw(double amount)
  {
    if (Balance < 2500)
      Console.WriteLine("Insufficient balance.");
    else
      Console.WriteLine("Withdrawal: {0}", amount); 
      base.Withdraw(amount);

  }
}
