namespace C_Sharp_Patterns.BehavioralPatterns.Iterator;

// A class that represents a stock collection
public class StockCollection : ICollection<Stock>
{
  // An list of stocks as the internal representation
  private readonly List<Stock> _stocks = new List<Stock>();

  // A method to add a stock to the collection
  public void Add(Stock stock)
  {
    _stocks.Add(stock);
  }

  // A method to create an iterator for the collection
  public IIterator<Stock> CreateIterator()
  {
    return new StockIterator(this);
  }

  // A nested class that implements the iterator interface
  private class StockIterator : IIterator<Stock>
  {
    // A reference to the outer collection
    private readonly StockCollection _collection;

    // An index to keep track of the current position
    private int _index = -1;

    // A constructor that takes the collection as a parameter
    public StockIterator(StockCollection collection)
    {
      this._collection = collection;
    }

    // A property that returns the current element
    public Stock Current
    {
      get
      {
        // Check if the index is valid
        if (_index < 0 || _index >= _collection._stocks.Count)
        {
          throw new InvalidOperationException();
        }

        // Return the stock at the current index
        return _collection._stocks[_index];
      }
    }

    // A method that moves to the next element and returns true if successful
    public bool MoveNext()
    {
      // Increment the index and check if it is within bounds
      _index++;
      return _index < _collection._stocks.Count;
    }
  }
}
