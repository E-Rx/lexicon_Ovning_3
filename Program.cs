using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace lexicon_Ovning_3;

static class Program
{
  static void Main(string[] args)
  {
    VehicleHandler handler = new VehicleHandler();

    try
    {
      // Part 1: Create a new Car object

    Vehicle car = new Vehicle("Lotus", "Elise", 2020, 996);
    handler.AddVehicle(car);
    Vehicle car2 = new Vehicle("Toyota", "Corolla", 2021, 1300);
    handler.AddVehicle(car2);
    //handler.AddVehicle(new Car("Renault", "Clio", 2021, 1400));

    // Create a new Truck object
    //handler.AddVehicle(new Truck("Ford", "F-150", 2018, 2500, 1000));

    // Create a new Motorcycle object
    //handler.AddVehicle(new Motorcycle("Harley-Davidson", "Street 750", 2019, 200, 750));

    // Create a new ElectricScooter object
    //handler.AddVehicle(new ElectricScooter("Xiaomi", "M365", 2021, 12.5, 25));

    // Display the list of vehicles

    handler.ListVehicles();

    // Change the weight of the first vehicle
    handler.ChangeVehicleWeight(car, 1300);
    handler.ChangeVehicleWeight(car2, 2000);
    Console.WriteLine("\nAfter changing the weight of the first car:");
    handler.ListVehicles();

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
