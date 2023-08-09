namespace C_Sharp_Patterns.StructuralPatterns.Proxy;

// A concrete class that also implements the interface and
// acts as a proxy for an account object
public class AccountProxy : IAccount
{
  // The reference to the real account object
  private IAccount account;
  // The path of the log file
  private string logFile;

  public AccountProxy(IAccount account, string logFile)
  {
    this.account = account;
    this.logFile = logFile;
  }

  public decimal GetBalance()
  {
    // Logging: write some information before calling the method
    WriteLog($"Getting balance of {account.GetType().Name}");

    // Delegate the work to the real account object
    decimal balance = account.GetBalance();

    // Logging: write some information after calling the method
    WriteLog($"Balance is {balance}");

    return balance;
  }

  public void Deposit(decimal amount)
  {
    // Logging: write some information before calling the method
    WriteLog($"Depositing {amount} to {account.GetType().Name}");

    // Delegate the work to the real account object
    account.Deposit(amount);

    // Logging: write some information after calling the method
    WriteLog($"Deposit successful");
  }

  public void Withdraw(decimal amount)
  {
    // Logging: write some information before calling the method
    WriteLog($"Withdrawing {amount} from {account.GetType().Name}");

    // Delegate the work to the real account object
    account.Withdraw(amount);

    // Logging: write some information after calling the method
    WriteLog($"Withdrawal successful");
  }

  // A helper method to write to the log file
  private void WriteLog(string message)
  {
    using (StreamWriter writer = new StreamWriter(logFile, true))
    {
      writer.WriteLine($"{DateTime.Now}: {message}");
    }
  }
}
