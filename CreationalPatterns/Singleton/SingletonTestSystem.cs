namespace C_Sharp_Patterns.CreationalPatterns.Singleton;

public class SingletonTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Singleton pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    Singleton1 s1 = Singleton1.Instance; // get singleton instance
    Singleton1 s2 = Singleton1.Instance; // get singleton instance again
    Console.WriteLine($"Singleton 1: {s1 == s2}"); // true - same instance
    Console.WriteLine();

    Singleton2 s3 = Singleton2.Instance; // get singleton instance
    Singleton2 s4 = Singleton2.Instance; // get singleton instance again
    Console.WriteLine($"Singleton 2: {s3 == s4}"); // true - same instance
    Console.WriteLine();

    Singleton3 s5 = Singleton3.Instance; // get singleton instance
    Singleton3 s6 = Singleton3.Instance; // get singleton instance again
    Console.WriteLine($"Singleton 3: {s5 == s6}"); // true - same instance
    Console.WriteLine();

    Singleton4 s7 = Singleton4.Instance; // get singleton instance
    Singleton4 s8 = Singleton4.Instance; // get singleton instance again
    Console.WriteLine($"Singleton 4: {s7 == s8}"); // true - same instance
    Console.WriteLine();

    Singleton5 s9 = Singleton5.Instance; // get singleton instance
    Singleton5 s10 = Singleton5.Instance; // get singleton instance again
    Console.WriteLine($"Singleton 5: {s9 == s10}"); // true - same instance
    Console.WriteLine();

  }
}
