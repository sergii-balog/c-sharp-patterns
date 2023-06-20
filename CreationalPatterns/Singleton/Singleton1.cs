namespace C_Sharp_Patterns.CreationalPatterns.Singleton;

//No Thread-Safe Singleton
public sealed class Singleton1
{
  private Singleton1() {} // private constructor

  private static Singleton1 _instance = null; // private static field

  public static Singleton1 Instance // public static property
  {
    get
    {
      if (_instance == null) // check if instance is created
      {
        _instance = new Singleton1(); // create instance if not
      }
      return _instance; // return instance
    }
  }
}
