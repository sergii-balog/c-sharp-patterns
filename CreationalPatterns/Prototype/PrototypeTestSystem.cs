namespace C_Sharp_Patterns.CreationalPatterns.Prototype;

public class PrototypeTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Prototype pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create a prototype manager instance
    var vehicleManager = new VehicleManager();

    // Create a car prototype and add it to the manager
    var carPrototype = new Car
    {
      Make = "Honda",
      Model = "Civic",
      Color = "Silver",
      Price = 20000,
      Doors = 4
    };
    vehicleManager.AddVehicle("Car", carPrototype);

    // Create a bike prototype and add it to the manager
    var bikePrototype = new Bike
    {
      Make = "Yamaha",
      Model = "FZ",
      Color = "Blue",
      Price = 5000,
      Type = "Sport"
    };
    vehicleManager.AddVehicle("Bike", bikePrototype);

    // Clone the car prototype and create a new car object
    var car1 = (Car)vehicleManager.GetVehicle("Car").Clone();
    // Change the color property
    car1.Color = "Red";

    // Clone the bike prototype and create a new bike object
    var bike1 = (Bike)vehicleManager.GetVehicle("Bike").Clone();
    // Change the type property
    bike1.Type = "Cruiser";

    // Display the details of the original and cloned objects
    Console.WriteLine("Original Car: ");
    Console.WriteLine(carPrototype);
    Console.WriteLine("Cloned Car: ");
    Console.WriteLine(car1);
    Console.WriteLine("Original Bike: ");
    Console.WriteLine(bikePrototype);
    Console.WriteLine("Cloned Bike: ");
    Console.WriteLine(bike1);
  }
}
