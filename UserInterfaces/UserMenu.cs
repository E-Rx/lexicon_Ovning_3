/* using System;
using System.Collections.Generic;
using lexicon_Ovning_3.Handlers;
using lexicon_Ovning_3.Helpers;
using lexicon_Ovning_3.ErrorSystem;
using lexicon_Ovning_3.Seeds;

namespace lexicon_Ovning_3.UserInterfaces
{
  public class UserMenu
  {
   static void RunApplication()
    {
      VehicleHandler handler = new VehicleHandler();
      VehicleInitializer.CreateInitialVehicles(handler);

      var updater = new UpdateVehicle(handler);
      var adder = new AddVehicle(handler);

      bool running = true;

      while (running)
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("");
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║            **  BIENVENUE  **               ║");
        Console.WriteLine("║        Vehicle Management System           ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine("");
        Console.ResetColor();


        Console.WriteLine("1. Show all vehicles");
        Console.WriteLine("2. Add a vehicle");
        Console.WriteLine("3. Update a vehicle");
        Console.WriteLine("4. Possible Error messages");
        Console.WriteLine("5. Demo vehicle actions");
        Console.WriteLine("0. ❌ Exit");
        Console.Write("\nSelect an option: ");

        string input = (string)InputHelper.GetValidInput("", typeof(string));

        switch (input)
        {
          case "1":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n=== All Vehicles in the System ===");
            Console.WriteLine("");
            Console.ResetColor();
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

      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("\nMERCI 🙂 À BIENTÔT 👋 ");
      Console.ResetColor();
    }
  }
}
 */
