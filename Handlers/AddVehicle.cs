using System;
using lexicon_Ovning_3.Vehicles;
using lexicon_Ovning_3.Helpers;

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

      string typeChoice = (string)InputHelper.GetValidInput("", typeof(string));

      // Vérification immédiate du type de véhicule
      if (typeChoice != "1" && typeChoice != "2" && typeChoice != "3" && typeChoice != "4")
      {
        Console.WriteLine("Invalid vehicle type selection.");
        return;  // Quitte la méthode si le type est invalide
      }

      // base properties for all vehicles
      Console.Write("Brand: ");
      string brand = (string)InputHelper.GetValidInput("", typeof(string));

      Console.Write("Model: ");
      string model = (string)InputHelper.GetValidInput("", typeof(string));

      Console.Write("Year: ");
      int year = (int)InputHelper.GetValidInput("", typeof(int));

      Console.Write("Weight (kg): ");
      double weight = (double)InputHelper.GetValidInput("", typeof(double));

      try
      {
        Vehicle newVehicle;

          switch (typeChoice)
          {
              case "1": // Car
                  Console.Write("Fuel Type (e.g., Diesel, Gasoline, Hybrid): ");
                  string fuelType = (string)InputHelper.GetValidInput("", typeof(string));
                  newVehicle = new Car(brand, model, year, weight, fuelType);
                  break;

              case "2": // Truck
                  Console.Write("Cargo Capacity (kg): ");
                  double cargoCapacity = (double)InputHelper.GetValidInput("", typeof(double));
                  newVehicle = new Truck(brand, model, year, weight, cargoCapacity);
                  break;

              case "3": // Motorcycle
                  Console.Write("Has Sidecar (true/false): ");
                  bool hasSidecar = (bool)InputHelper.GetValidInput("", typeof(bool));
                  newVehicle = new Motorcycle(brand, model, year, weight, hasSidecar);
                  break;

              case "4": // Electric Scooter
                  Console.Write("Battery Range (km): ");
                  double batteryRange = (double)InputHelper.GetValidInput("", typeof(double));
                  newVehicle = new ElectricScooter(brand, model, year, weight, batteryRange);
                  break;

              default:
                  Console.WriteLine("Invalid vehicle type selection.");
                  return;
          }

          vehicleHandler.AddVehicle(newVehicle);
          Console.WriteLine("Vehicle added successfully!");
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
