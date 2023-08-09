namespace C_Sharp_Patterns.StructuralPatterns.Proxy;

public class ProxyTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Proxy pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create a checking account with 1000 initial balance
    IAccount checking = new CheckingAccount(1000);

    // Create a saving account with 500 initial balance and 0.01 interest rate
    IAccount saving = new SavingAccount(500, 0.01m);

    // Create proxies for both accounts and specify the log file path
    IAccount checkingProxy = new AccountProxy(checking, "checking.log");
    IAccount savingProxy = new AccountProxy(saving, "saving.log");

    // Use the proxies to perform some operations on the accounts
    Console.WriteLine($"Checking balance: {checkingProxy.GetBalance()}");
    Console.WriteLine($"Saving balance: {savingProxy.GetBalance()}");

    checkingProxy.Deposit(200);
    savingProxy.Deposit(100);

    Console.WriteLine($"Checking balance: {checkingProxy.GetBalance()}");
    Console.WriteLine($"Saving balance: {savingProxy.GetBalance()}");

    checkingProxy.Withdraw(500);
    savingProxy.Withdraw(200);

    Console.WriteLine($"Checking balance: {checkingProxy.GetBalance()}");
    Console.WriteLine($"Saving balance: {savingProxy.GetBalance()}");
  }
}
