namespace C_Sharp_Patterns.CreationalPatterns.Singleton;

//Thread-Safe Singleton using Double-Check Locking
public class Singleton3
{
  private Singleton3() {} // private constructor

  private static readonly object Padlock = new object(); // lock object

  private static Singleton3 _instance = null; // private static field

  public static Singleton3 Instance // public static property
  {
    get
    {
      if (_instance == null) // check if instance is created (first check)
      {
        lock (Padlock) // lock critical section
        {
          if (_instance == null) // check if instance is created (second check)
          {
            _instance = new Singleton3(); // create instance if not
          }
        }
      }
      return _instance; // return instance
    }
  }
}
