using System;

/* namespace lexicon_Ovning_3.Helpers
{
  public static class InputHelper
  {
    public const string InvalidInputMessage = "Sorry, invalid input. Please try again.";
    // Method to show error message and exit
    private static void ShowErrorAndExit()
    {
        Console.WriteLine(InvalidInputMessage);
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    // Method to get valid input from the user
    public static object GetValidInput(string prompt, Type type)
    {

        while (true)
        {
            Console.Write(prompt);
            string inputString = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(inputString))
            {
              ShowErrorAndExit();
              continue;
            }

            if (type == typeof(string))
            {
              return inputString;
            }
            else if (type == typeof(int))
            {
              if (int.TryParse(inputString, out int intInput))
              {
                return intInput;
              }
              ShowErrorAndExit();
            }
            else if (type == typeof(double))
            {
              if (double.TryParse(inputString, out double doubleInput))
              {
                return doubleInput;
              }
              ShowErrorAndExit();
            }
            else if (type == typeof(bool))
            {
              if (bool.TryParse(inputString, out bool boolInput))
              {
                return boolInput;
              }
              ShowErrorAndExit();
            }
            else
            {
              throw new ArgumentException($"Unsupported type: {type.Name}");
            }
        }

      }
  }
}
*/


namespace lexicon_Ovning_3.Helpers
{
    public static class InputHelper
    {
      public const string InvalidInputMessage = "Sorry, invalid input. Please try again.";

        // Method to get valid input from the user
        public static object GetValidInput(string prompt, Type type)
        {
          while (true)
          {
            Console.Write(prompt);
            string inputString = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(inputString))
            {
              Console.WriteLine(InvalidInputMessage);
              continue;
            }

            if (type == typeof(string))
            {
              return inputString;
            }
            else if (type == typeof(int))
            {
              if (int.TryParse(inputString, out int intInput))
              {
                return intInput;
              }
              Console.WriteLine(InvalidInputMessage);

            }
            else if (type == typeof(double))
            {
              if (double.TryParse(inputString, out double doubleInput))
              {
                return doubleInput;
              }
              Console.WriteLine(InvalidInputMessage);

            }
            else if (type == typeof(bool))
            {
              if (bool.TryParse(inputString, out bool boolInput))
              {
                return boolInput;
              }
              Console.WriteLine(InvalidInputMessage);
            }
            else
            {
              throw new ArgumentException($"Unsupported type: {type.Name}");
            }
          }
        }
    }
}
