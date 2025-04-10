using System;
using lexicon_Ovning_3.Handlers;
using lexicon_Ovning_3.Vehicles;

namespace lexicon_Ovning_3.Seeds;

public class VehicleInitializer
{
  private readonly VehicleHandler handler;

  // constructor
  public VehicleInitializer(VehicleHandler handler)
    {
      this.handler = handler;
    }

  // Method to create initial vehicles
  public static void CreateInitialVehicles(VehicleHandler handler)
    {
      try
      {
        handler.AddVehicle(new Car("Lotus", "Elise", 2020, 996, "Petrol" ));
        handler.AddVehicle(new Car("Renault", "Clio", 2021, 1400, "Diesel"));

        handler.AddVehicle(new Truck("Volvo", "F-150", 2018, 2500, 1000));

        handler.AddVehicle(new Motorcycle("Harley-Davidson", "Street 750", 2019, 200, false));
        handler.AddVehicle(new Motorcycle("Honda", "CBR500R", 2022, 190, true));

        handler.AddVehicle(new ElectricScooter("Xiaomi", "M365", 2021, 12.5, 25));
      }

      catch (Exception ex)
      {
          Console.WriteLine($"Error creating initial vehicles: {ex.Message}");
      }
    }
}
