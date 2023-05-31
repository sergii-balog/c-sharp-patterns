namespace C_Sharp_Patterns.Strategy;

public interface IPaymentStrategy
{
  void Pay(Order order);
}
