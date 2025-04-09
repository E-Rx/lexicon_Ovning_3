using System;

namespace lexicon_Ovning_3.UserInterfaces;

public class VehicleManagementSystem
{


 private void DisplayMenu()
    {
        Console.WriteLine("***** Vehicle Management System *****");
        Console.WriteLine("");
        Console.WriteLine("1. List all vehicles");
        Console.WriteLine("2. Add a new vehicle");
        Console.WriteLine("3. Update a vehicle");
        Console.WriteLine("4. View error messages");
        Console.WriteLine("5. Demonstrate vehicle actions");
        Console.WriteLine("0. Exit");
        Console.Write("\nEnter your choice: ");
    }

   private void CreateInitialVehicles() // Method to create initial vehicles
    {
      VehicleHandler handler = new VehicleHandler();

      try
      {
        handler.AddVehicle(new Car("Lotus", "Elise", 2020, 996, "Petrol" ));
        handler.AddVehicle(new Car("Renault", "Clio", 2021, 1400, "Petrol"));

        handler.AddVehicle(new Truck("Ford", "F-150", 2018, 2500, 1000));

        handler.AddVehicle(new Motorcycle("Harley-Davidson", "Street 750", 2019, 200, false));
        handler.AddVehicle(new Motorcycle("Honda", "CBR500R", 2022, 190, true));

        handler.AddVehicle(new ElectricScooter("Xiaomi", "M365", 2021, 12.5, 25));

      }

      catch (Exception ex)
      {
          Console.WriteLine($"Error creating initial vehicles: {ex.Message}");
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
