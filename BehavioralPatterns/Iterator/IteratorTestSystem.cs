namespace C_Sharp_Patterns.BehavioralPatterns.Iterator;

public class IteratorTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Iterator pattern");
    Console.WriteLine();

    await Task.Delay(1000);



    // Create a stock collection from the array
    StockCollection stockCollection = new StockCollection();

    // Add an array of stocks
    stockCollection.Add(new Stock { Symbol = "MSFT", Price = 300.25m });
    stockCollection.Add(new Stock { Symbol = "AAPL", Price = 150.50m });
    stockCollection.Add(new Stock { Symbol = "AMZN", Price = 3500.00m });

    // Create an iterator for the collection
    IIterator<Stock> iterator = stockCollection.CreateIterator();

    // Iterate over the stocks using the iterator
    while (iterator.MoveNext())
    {
      // Get the current stock and print its details
      Stock stock = iterator.Current;
      Console.WriteLine($"{stock.Symbol}: {stock.Price}");
    }
  }
}
