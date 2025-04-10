using System;
using System.Collections.Generic;


namespace lexicon_Ovning_3.Handlers
{
  public class VehicleHandler
  {
    private List<Vehicle> vehicles = new List<Vehicle>();

    // Add a vehicle to the list
    public void AddVehicle(Vehicle vehicle)
    {
      vehicles.Add(vehicle);
    }

    // Change vehicle's properties
    public static void ChangeVehicleWeight(Vehicle vehicle, double newWeight)
    {
      vehicle.Weight = newWeight;
    }
    public static void ChangeVehicleYear(Vehicle vehicle, int newYear)
    {
      vehicle.Year = newYear;
    }
    public static void ChangeVehicleModel(Vehicle vehicle, string newModel)
    {
      vehicle.Model = newModel;
    }
    public static void ChangeVehicleBrand(Vehicle vehicle, string newBrand)
    {
      vehicle.Brand = newBrand;
    }

    // Display the list of vehicles
    public void ListOfVehicles()
    {
      if (vehicles.Count == 0)
      {
        Console.WriteLine("No vehicles available.");
        return;
      }

      foreach (Vehicle vehicle in vehicles)
      {
        Console.WriteLine(vehicle.Stats());
      }
    }

    // Method to get the list of vehicles
    public List<Vehicle> GetVehicles()
    {
      return vehicles;
    }

    // Method to find a vehicle by brand and model
    public Vehicle FindVehicleByBrandAndModel(string brand, string model)
    {
      return vehicles.Find(v => v.Brand == brand && v.Model == model)
      ?? throw new InvalidOperationException("Vehicle not found.");

    /* Vehicle foundVehicle = null;

    foreach (Vehicle vehicle in vehicles)
    {
      if (vehicle.Brand == brand && vehicle.Model == model)
      {
        foundVehicle = vehicle;
        break;
      }
    }
    if (foundVehicle == null)
    {
      throw new InvalidOperationException("Vehicle not found.");
    }
    return foundVehicle; */
    }
  }
}
