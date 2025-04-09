using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
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
      handler.ChangeVehicleWeight([0], 1300);
      handler.ChangeVehicleWeight([1], 2000);
      Console.WriteLine("\nAfter changing the weight of the first car:");
      handler.ListOfVehicles();

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




    // Part 2: System Error
    Console.WriteLine("\n--- System Errors Demonstration ---");

    // Create a list of system errors (Part 2.3)
    List<SystemError> errors = new List<SystemError>
      {
        new EngineFailureError(),
        new TransmissionError(),
        new BrakeFailureError(),
      };

    // Display error messages (polymorphism)
    foreach (var error in errors)
    {
        Console.WriteLine(error.ErrorMessage());
    }
  }
}
