using System;
using lexicon_Ovning_3.ErrorSystem;
using lexicon_Ovning_3.Handlers;
using lexicon_Ovning_3.Seeds;
using lexicon_Ovning_3.Helpers;

namespace lexicon_Ovning_3.Vehicles.Handlers
{
  static class Program
  {
    static void Main(string[] args)
    {
      try
      {
        RunApplication();
      }

      catch (ArgumentException ex)
      {
        Console.WriteLine($"Validation error: {ex.Message}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Unexpected error: {ex.Message}");
      }
    }


  // Method to run the application(initializes the vehicle handler and creates initial vehicles)
    static void RunApplication()
    {
      VehicleHandler handler = new VehicleHandler();
      VehicleInitializer.CreateInitialVehicles(handler);

      var updater = new UpdateVehicle(handler);
      var adder = new AddVehicle(handler);

      bool running = true;

      while (running)
      {
        Console.WriteLine("\n=== Vehicle Management System ===");
        Console.WriteLine("");
        Console.WriteLine("1. Show all vehicles");
        Console.WriteLine("2. Add a vehicle");
        Console.WriteLine("3. Update a vehicle");
        Console.WriteLine("4. Possible Error messages");
        Console.WriteLine("5. Demo vehicle actions");
        Console.WriteLine("0. Exit");
        Console.Write("Select an option: ");

        string input = (string)InputHelper.GetValidInput("", typeof(string));

        switch (input)
        {
          case "1":
            Console.WriteLine("\n=== All Vehicles in the System ===");
            Console.WriteLine("");
            handler.ListOfVehicles();
            break;
          case "2":
              adder.AddNewVehicle();
              break;
          case "3":
              updater.Run();
              break;
          case "4":
              ErrorDemo.DemoErrorHandling();
              break;
          case "5":
              DemoVehicleActions(handler);
              break;
          case "0":
              running = false;
              break;
          default:
              Console.WriteLine("Invalid option.");
              break;
        }
      }

      Console.WriteLine("MERCI! À BIENTÔT!");
    }


    // Part 4: polymorphism - this method demonstrates Vehicle actions
    public static void DemoVehicleActions(VehicleHandler handler)
    {
      Console.WriteLine("\n--- Demo Vehicle Actions ---");
      Console.WriteLine("");
      foreach (var vehicle in handler.GetVehicles())
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
}
