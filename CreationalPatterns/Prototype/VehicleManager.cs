namespace C_Sharp_Patterns.CreationalPatterns.Prototype;

// The prototype manager class that stores and retrieves prototypes
public class VehicleManager
{
  // A dictionary to store prototypes by key
  private readonly Dictionary<string, Vehicle> _vehicles = new Dictionary<string, Vehicle>();

  // A method to add a prototype by key
  public void AddVehicle(string key, Vehicle vehicle)
  {
    _vehicles.Add(key, vehicle);
  }

  // A method to get a prototype by key
  public Vehicle GetVehicle(string key)
  {
    return _vehicles[key];
  }
}
