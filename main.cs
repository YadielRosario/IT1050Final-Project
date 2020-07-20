using System;

class MainClass {
  public static void Main (string[] args) {

    BankAccount account1 = new BankAccount("000001", "SpongeBob Squarepants", 10000);

    account1.DisplayAccountInfo();
    account1.Deposit(50);
    account1.Withdraw(500);
    account1.CalculateInterest(2);

    SavingsAccount account2 = new SavingsAccount("000002", "Patrick Star", 25000);
    account2.DisplayAccountInfo();
    account2.Deposit(40);
    account2.Withdraw(2500);
    account2.CalculateInterest(3);
    
    CheckingAccount account3 = new CheckingAccount("000003", "Squidward Tentacles", 42981);
    account3.DisplayAccountInfo();
    account3.Deposit(100000);
    account3.Withdraw(45000);
    account3.CalculateInterest(10);
  }
}