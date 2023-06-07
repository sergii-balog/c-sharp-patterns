namespace C_Sharp_Patterns.Iterator;

// The collection interface
public interface ICollection<out T>
{
  // Returns an iterator for the collection
  IIterator<T> CreateIterator();
}
