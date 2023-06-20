namespace C_Sharp_Patterns.CreationalPatterns.Singleton;

//Thread-Safe Singleton using Lock
public sealed class Singleton2
{
  private Singleton2() {} // private constructor

  private static readonly object Padlock = new object(); // lock object

  private static Singleton2 _instance = null; // private static field

  public static Singleton2 Instance // public static property
  {
    get
    {
      lock (Padlock) // lock critical section
      {
        if (_instance == null) // check if instance is created
        {
          _instance = new Singleton2(); // create instance if not
        }
        return _instance; // return instance
      }
    }
  }
}
