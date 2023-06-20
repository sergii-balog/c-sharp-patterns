namespace C_Sharp_Patterns.CreationalPatterns.Singleton;

//Thread-Safe Singleton using Lazy<T>
public class Singleton5
{
  private static readonly Lazy<Singleton5> _lazy = new Lazy<Singleton5>(() => new Singleton5()); // private static field initialized lazily

  private Singleton5() {} // private constructor

  public static Singleton5 Instance // public static property
  {
    get
    {
      return _lazy.Value; // return lazy-initialized value
    }
  }
}
