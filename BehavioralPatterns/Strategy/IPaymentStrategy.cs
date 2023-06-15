namespace C_Sharp_Patterns.BehavioralPatterns.Strategy;

public interface IPaymentStrategy
{
  void Pay(Order order);
}
