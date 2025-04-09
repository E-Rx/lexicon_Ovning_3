using lexicon_Ovning_3.Models;



namespace lexicon_Ovning_3;

static class Program
{
  static void Main(string[] args)
  {
    VehicleHandler handler = new VehicleHandler();

    try
    {
      Console.WriteLine("--- Vehicle Creation and Management ---");

      handler.AddVehicle(new Car("Lotus", "Elise", 2020, 996, "Petrol" ));
      handler.AddVehicle(new Car("Renault", "Clio", 2021, 1400, "Petrol"));

      handler.AddVehicle(new Truck("Ford", "F-150", 2018, 2500, 1000));

      handler.AddVehicle(new Motorcycle("Harley-Davidson", "Street 750", 2019, 200, false));
      handler.AddVehicle(new Motorcycle("Honda", "CBR500R", 2022, 190, true));

      handler.AddVehicle(new ElectricScooter("Xiaomi", "M365", 2021, 12.5, 25));

    // Display the list of vehicles
      handler.ListOfVehicles();

      // Change the weight of the first vehicle
      Vehicle carToModify = handler.FindVehicleByBrandAndModel("Lotus", "Elise");
        {
            handler.ChangeVehicleWeight(carToModify, 1300);
            Console.WriteLine("\nAfter changing the car's weight:");
            handler.ListOfVehicles();
        }

      DemoErrorHandling();
      DemoPolymorphism(handler);

    }
     catch (ArgumentException ex)
    {
        // Handle validation exceptions
        Console.WriteLine($"Validation error: {ex.Message}");
    }
    catch (Exception ex)
    {
        // Handle other exceptions
        Console.WriteLine($"Unexpected error: {ex.Message}");
    }
  }


  private static void DemoErrorHandling()
  {
      Console.WriteLine("\n--- System Errors ---");
      List<SystemError> errors = new List<SystemError>
      {
          new EngineFailureError(),
          new BrakeFailureError(),
          new TransmissionError()
      };

      foreach (var error in errors)
      {
          Console.WriteLine(error.ErrorMessage());
      }
  }

  private static void DemoPolymorphism(VehicleHandler handler)
  {
      // Part 4: polymorphism

    Console.WriteLine("\n--- Starting Engines and Vehicle Stats ---");
    List<Vehicle> vehicles = handler.GetVehicles();

    foreach (var vehicle in vehicles)
    {
        Console.WriteLine(vehicle.Stats());
        vehicle.StartEngine();

        if (vehicle is ICleanable cleanable)
        {
            cleanable.Clean();
        }
        Console.WriteLine();
    }
  }
}
