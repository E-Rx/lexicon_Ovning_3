using System;
using System.Collections.Generic;

namespace lexicon_Ovning_3;

public class VehicleHandler
{
  private List<Vehicle> vehicles = new List<Vehicle>();

  // Method to add a vehicle
  public void AddVehicle(Vehicle vehicle)
  {
    vehicles.Add(vehicle);
  }

 // Method to change a vehicle's properties
  public void ChangeVehicleWeight(Vehicle vehicle, double newWeight)
    {
        vehicle.Weight = newWeight;
    }

    // Method to change a vehicle's year
  public void ChangeVehicleYear(Vehicle vehicle, int newYear)
    {
        vehicle.Year = newYear;
    }

    // Method to change a vehicle's model
  public void ChangeVehicleModel(Vehicle vehicle, string newModel)
    {
        vehicle.Model = newModel;
    }

    // Method to change a vehicle's brand
  public void ChangeVehicleBrand(Vehicle vehicle, string newBrand)
    {
        vehicle.Brand = newBrand;
    }
  // Display List of Vehicles
  public void ListOfVehicles()
    {
      foreach (Vehicle vehicle in vehicles)
      {
          Console.WriteLine(vehicle.Stats());
      }
    }

    public List<Vehicle> GetVehicles() // Method to get the list of vehicles
    {
      return vehicles;
    }

    // Method to find a vehicle by brand and model
    public Vehicle FindVehicleByBrandAndModel(string brand, string model)
    {
        return vehicles.Find(v => v.Brand == brand && v.Model == model)
        ?? throw new InvalidOperationException("Vehicle not found.");
    }
}
