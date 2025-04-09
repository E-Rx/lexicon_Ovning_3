using System;

namespace lexicon_Ovning_3.Models;

public class Motorcycle : Vehicle
{
  public bool HasSidecar { get; set; }

  // Constructor
  public Motorcycle(string brand, string model, int year, double weight, bool hasSidecar) : base(brand, model, year, weight)
  {
    HasSidecar = hasSidecar;
  }

  public override void StartEngine()
  {
    Console.WriteLine($"The {Brand} {Model}'s engine is starting...");
  }

  public override string Stats()
  {
    string sidecarInfo = HasSidecar ? "with sidecar" : "without sidecar";
    return $"Motorcycle: {Brand} {Model} ({Year}), Weight: {Weight}kg, {sidecarInfo}";
  }

}
