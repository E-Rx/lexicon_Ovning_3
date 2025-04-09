namespace lexicon_Ovning_3;

public abstract class Vehicle
{
  private string brand = string.Empty; // Default value
  private string model = string.Empty;
  private int year = 0;
  private double weight = 0.0;

  public string Brand // Validation: Brand must be between 2 and 20 characters
  {
    get { return brand; }
    set
    {
      if (value.Length <= 2 || value.Length >= 20)
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
      if (value.Length <= 2 || value.Length >= 20)
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
    int currentYear = DateTime.Now.Year;
    if (value < 1886 || value > currentYear)
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

  // Constructor
  public Vehicle(string brand, string model, int year, double weight)
  {
    Brand = brand;
    Model = model;
    Year = year;
    Weight = weight;

  }

  // Abstract method to be implemented by derived classes
  public abstract void StartEngine();
  public abstract string Stats();

}
