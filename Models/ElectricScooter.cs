namespace lexicon_Ovning_3.Vehicles;

public class ElectricScooter : Vehicle
{
 public double BatteryRange { get; set; }

 // Constructor
  public ElectricScooter(string brand, string model, int year, double weight, double batteryRange) : base(brand, model, year, weight)
  {
    BatteryRange = batteryRange;
  }

  public override void StartEngine()
  {
    Console.WriteLine($"The {Brand} {Model} electric scooter turns on silently.");
  }

  public override string Stats()
  {
    return $"Electric Scooter: {Brand} {Model} ({Year}), Weight: {Weight}kg, Battery Range: {BatteryRange}";
  }
}
