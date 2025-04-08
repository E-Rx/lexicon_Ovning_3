using System;

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
  public void DisplayVehicles()
    {
    Console.WriteLine("List of Vehicles:");
    foreach (Vehicle vehicle in vehicles)
    {
      Console.WriteLine(vehicle.GetInfo());
    }
    }
}
