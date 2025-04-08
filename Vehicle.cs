using System;

namespace lexicon_Ovning_3;

public class Vehicle
{
  private string brand;
  private string model;
  private int year;
  private double weight;

  public string Brand // Validation: Brand must be between 2 and 20 characters
  {
    get { return brand; }
    set
    {
      if (value.Length < 2 || value.Length > 20)
      {
        throw new ArgumentException("Brand must be between 2 and 20 characters.");
      }
      brand = value;
    }
  }
  public string Model // Validation: Model must be between 2 and 20 characters
  {
    get { return model; }
    set
    {
      if (value.Length < 2 || value.Length > 20)
      {
        throw new ArgumentException("Model must be between 2 and 20 characters.");
      }
      model = value;
    }
  }

  public int Year // Validation: Year must be between 1886 and the current year
  {
    get { return year; }
    set {
    if year < 1886 || year > DateTime.Now.Year)
      {
        throw new ArgumentException("Year must be between 1886 and the current year.");
      }
      year = value;
    }
  }
  public double Weight // Validation: Weight must be a positive value
  {
    get { return weight; }
    set {
    if (value <= 0)
      {
        throw new ArgumentException("Weight must be a positive number.");
      }
      weight = value;
    }
  }
}
