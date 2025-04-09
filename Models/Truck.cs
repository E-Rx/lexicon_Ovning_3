using System;

namespace lexicon_Ovning_3.Models;

public class Truck : Vehicle, ICleanable
{
  public double CargoCapacity { get; set; }

  // Constructor
  public Truck(string brand, string model, int year, double weight, double cargoCapacity) : base(brand, model, year, weight)
  {
   CargoCapacity = cargoCapacity;
  }

  
 public override void StartEngine()
 {
  Console.WriteLine($"The {Brand} {Model}'s engine is starting...");
 }

 public override string Stats()
 {
  return $"Truck: {Brand} {Model} ({Year}), Weight: {Weight}kg, Cargo Capacity: {CargoCapacity}kg";
 }

 public void Clean()
 {
  Console.WriteLine($"The {Brand} {Model} truck is washed and cleaned!");
 }
}
