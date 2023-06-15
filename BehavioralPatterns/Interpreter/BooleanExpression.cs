namespace C_Sharp_Patterns.BehavioralPatterns.Interpreter;

// Define an abstract expression that represents a boolean expression
public abstract class BooleanExpression
{
  // Define an abstract method for interpreting a context
  public abstract bool Interpret(Context context);
}
