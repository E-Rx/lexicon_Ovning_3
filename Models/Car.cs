using System;
using System.Collections.Generic;

namespace lexicon_Ovning_3.Models;

public class Car : Vehicle, ICleanable
{
  public string FuelType { get; set; }

/// Constructor
  public Car(string brand, string model, int year, double weight, string fuelType) : base(brand, model, year, weight)
  {
    FuelType = fuelType;
  }
   public override void StartEngine()
  {
    Console.WriteLine($"The {Brand} {Model} car starts with a powerful roar.");
  }

  public override string Stats()
    {
      return $"Car: {Brand} {Model} ({Year}), Weight: {Weight}kg, Fuel: {FuelType}";
    }
  public void Clean()
  {
    Console.WriteLine($"The {Brand} {Model} car is cleaned and shining!");
  }
}
