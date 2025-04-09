using System;
using lexicon_Ovning_3.Vehicles;

namespace lexicon_Ovning_3.Handlers;

public class AddVehicle
{

  private VehicleHandler vehicleHandler;

    public AddVehicle(VehicleHandler handler)
    {
        vehicleHandler = handler;
    }

  public void AddNewVehicle()
    {
      Console.WriteLine("\n=== Add a New Vehicle ===");
      Console.WriteLine("1. Car");
      Console.WriteLine("2. Truck");
      Console.WriteLine("3. Motorcycle");
      Console.WriteLine("4. Electric Scooter");
      Console.Write("\n Enter the number to select vehicle type: ");

      string typeChoice = Console.ReadLine();

      // Vérification immédiate du type de véhicule
      if (typeChoice != "1" && typeChoice != "2" && typeChoice != "3" && typeChoice != "4")
      {
          Console.WriteLine("Invalid vehicle type selection.");
          return;  // Quitte la méthode si le type est invalide
      }

      // base properties for all vehicles
      Console.Write("Brand: ");
      string brand = Console.ReadLine();

      Console.Write("Model: ");
      string model = Console.ReadLine();

      Console.Write("Year: ");
      if (!int.TryParse(Console.ReadLine(), out int year))
      {
        Console.WriteLine("Invalid year format.");
        return;
      }
      Console.Write("Weight (kg): ");
      if (!double.TryParse(Console.ReadLine(), out double weight))
      {
        Console.WriteLine("Invalid weight format.");
        return;
      }

      try
      {
        Vehicle newVehicle = null;

        switch (typeChoice)
        {
          case "1": // Car
            Console.Write("Fuel Type (e.g., Diesel, Gasoline, Hybrid): ");
            string fuelType = Console.ReadLine();
            newVehicle = new Car(brand, model, year, weight, fuelType);
            break;

          case "2": // Truck
            Console.Write("Cargo Capacity (kg): ");
            if (!double.TryParse(Console.ReadLine(), out double cargoCapacity))
            {
                Console.WriteLine("Invalid cargo capacity format.");
                return;
            }
            newVehicle = new Truck(brand, model, year, weight, cargoCapacity);
            break;

          case "3": // Motorcycle
            Console.Write("Has Sidecar (true/false): ");
            if (!bool.TryParse(Console.ReadLine(), out bool hasSidecar))
            {
                Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
                return;
            }
            newVehicle = new Motorcycle(brand, model, year, weight, hasSidecar);
            break;

          case "4": // Electric Scooter
            Console.Write("Battery Range (km): ");
            if (!double.TryParse(Console.ReadLine(), out double batteryRange))
            {
              Console.WriteLine("Invalid battery range format.");
              return;
            }
            newVehicle = new ElectricScooter(brand, model, year, weight, batteryRange);
            break;

          default:
              Console.WriteLine("Invalid vehicle type selection.");
              return;
        }

        if (newVehicle != null)
        {
          vehicleHandler.AddVehicle(newVehicle);
          Console.WriteLine("Vehicle added successfully!");
        }
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine($"Validation error: {ex.Message}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error adding vehicle: {ex.Message}");
      }
    }
}
