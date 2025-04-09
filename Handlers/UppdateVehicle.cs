using System;
using lexicon_Ovning_3.Vehicles;

namespace lexicon_Ovning_3.Handlers
{
  public class UpdateVehicle
  {
    private VehicleHandler vehicleHandler;

    // Constructor
    public UpdateVehicle(VehicleHandler handler)
    {
      vehicleHandler = handler;
    }

    public void Run()
    {
      Console.WriteLine("\n=== Update a Vehicle ===");
      Console.WriteLine("");
      vehicleHandler.ListOfVehicles();

      var vehicles = vehicleHandler.GetVehicles();
      if (vehicles.Count == 0)
      {
        Console.WriteLine("No vehicles to update.");
        return;
      }

      Console.Write("\nEnter the brand of the vehicle to update: ");
      string brand = Console.ReadLine();

      Console.Write("Enter the model of the vehicle to update: ");
      string model = Console.ReadLine();

        try
        {
          Vehicle vehicle = vehicleHandler.FindVehicleByBrandAndModel(brand, model);

          Console.WriteLine("\nWhat would you like to update?");
          Console.WriteLine("1. Brand");
          Console.WriteLine("2. Model");
          Console.WriteLine("3. Year");
          Console.WriteLine("4. Weight");
          Console.WriteLine("5. Specific property");
          Console.Write("Your choice: ");

          string choice = Console.ReadLine();

          switch (choice)
          {
            case "1":
              Console.Write("New brand: ");
              string newBrand = Console.ReadLine();
              VehicleHandler.ChangeVehicleBrand(vehicle, newBrand);
              break;

            case "2":
              Console.Write("New model: ");
              string newModel = Console.ReadLine();
              VehicleHandler.ChangeVehicleModel(vehicle, newModel);
              break;

            case "3":
              Console.Write("New year: ");
              int newYear = int.Parse(Console.ReadLine());
              VehicleHandler.ChangeVehicleYear(vehicle, newYear);
              break;

            case "4":
              Console.Write("New weight: ");
              double newWeight = double.Parse(Console.ReadLine());
              VehicleHandler.ChangeVehicleWeight(vehicle, newWeight);
              break;

            case "5":
              UpdateSpecificProperty(vehicle);
              break;

            default:
              Console.WriteLine("Invalid option.");
              return;
          }

            Console.WriteLine("Vehicle updated successfully!");
        }
        catch (InvalidOperationException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
          Console.WriteLine("Invalid input format.");
        }
    }

    private static void UpdateSpecificProperty(Vehicle vehicle)
    {
      if (vehicle is Car car)
      {
        Console.Write($"New fuel type (current: {car.FuelType}): ");
        string newFuelType = Console.ReadLine();
        car.FuelType = newFuelType;
      }
      else if (vehicle is Truck truck)
      {
        Console.Write($"New cargo capacity (current: {truck.CargoCapacity}): ");
        double newCapacity = double.Parse(Console.ReadLine());
        truck.CargoCapacity = newCapacity;
      }
      else if (vehicle is Motorcycle motorcycle)
      {
        Console.Write($"Has sidecar (current: {motorcycle.HasSidecar}): ");
        bool newHasSidecar = bool.Parse(Console.ReadLine());
        motorcycle.HasSidecar = newHasSidecar;
      }
      else if (vehicle is ElectricScooter scooter)
      {
        Console.Write($"New battery range (current: {scooter.BatteryRange}): ");
        double newRange = double.Parse(Console.ReadLine());
        scooter.BatteryRange = newRange;
      }
    }
  }
}
