// int age = 23;
// string name = "Andrew";
// float temp = 89.6f;

// Console.WriteLine("Hello, World! " + name + $" {age} temp is {temp}");

// CheckingAccount myAccount = new();
try
{
  CheckingAccount myAccount = new CheckingAccount(20);

  Console.WriteLine($"Your balance is {myAccount.GetBalance()}");

  myAccount.Deposit(10);

  Console.WriteLine($"Your balance is {myAccount.GetBalance()}");
} 
catch (Exception e)
{
  Console.WriteLine(e.Message);
}