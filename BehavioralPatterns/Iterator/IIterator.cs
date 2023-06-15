namespace C_Sharp_Patterns.BehavioralPatterns.Iterator;

// The iterator interface
public interface IIterator<out T>
{
  // Returns the current element
  T Current { get; }

  // Moves to the next element and returns true if successful
  bool MoveNext();
}
