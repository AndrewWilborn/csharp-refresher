public class BankAccount
{
  private double balance;
  public BankAccount(double amount)
  {
    if (amount < 0)
    {
      throw new Exception("No negative numbers");
    }
    balance = amount;
  }
  public double GetBalance()
  {
    return balance;
  }
  public void Deposit(double amount)
  {
    if (amount < 0)
    {
      throw new Exception("No negative numbers");
    }
    balance += amount;
  }
}

public class CheckingAccount : BankAccount
{
  public CheckingAccount(double amount) : base(amount)
  {
    Deposit(100);
  }
}

public class SavingsAccount : BankAccount
{

  public SavingsAccount(double amount) : base(amount)
  {
    if (amount > 900)
    {
      Deposit(200);
    }
  }
}