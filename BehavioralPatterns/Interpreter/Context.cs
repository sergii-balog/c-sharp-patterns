namespace C_Sharp_Patterns.BehavioralPatterns.Interpreter;

// Define a context class that contains information that is global to the interpreter, such as the values of the variables
public class Context
{
  // Declare a private dictionary to store the variables and their values
  private readonly Dictionary<string, bool> _variables;

  // Define a constructor that initializes the dictionary
  public Context()
  {
    _variables = new Dictionary<string, bool>();
  }

  // Define a method that sets the value of a variable in the dictionary
  public void SetVariable(string name, bool value)
  {
    _variables[name] = value;
  }

  // Define a method that gets the value of a variable from the dictionary
  public bool GetVariable(string name)
  {
    return _variables[name];
  }
}
