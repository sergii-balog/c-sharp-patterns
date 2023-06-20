namespace C_Sharp_Patterns.CreationalPatterns.Singleton;

//Thread-Safe Singleton without a Lock
public class Singleton4
{
  private static readonly Singleton4 _instance = new Singleton4(); // private static field initialized eagerly

  static Singleton4()
  { } // static constructor

  private Singleton4()
  { } // private constructor

  public static Singleton4 Instance // public static property
  {
    get
    {
      return _instance; // return instance
    }
  }
}
