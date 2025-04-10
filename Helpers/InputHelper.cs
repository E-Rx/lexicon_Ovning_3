using System;

namespace lexicon_Ovning_3.Helpers
{
    public static class InputHelper
    {
        public static object GetValidInput(string prompt, Type type)
        {
            while (true)
            {
                Console.Write(prompt);
                string inputString = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
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
                    Console.WriteLine("Invalid number format. Please enter a valid integer.");
                }
                else if (type == typeof(double))
                {
                    if (double.TryParse(inputString, out double doubleInput))
                    {
                        return doubleInput;
                    }
                    Console.WriteLine("Invalid number format. Please enter a valid double.");
                }
                else if (type == typeof(bool))
                {
                    if (bool.TryParse(inputString, out bool boolInput))
                    {
                        return boolInput;
                    }
                    Console.WriteLine("Invalid boolean format. Please enter true or false.");
                }
                else
                {
                    throw new ArgumentException($"Unsupported type: {type.Name}");
                }
            }
        }
    }
}


/* using System;

namespace lexicon_Ovning_3.Helpers
{
    public static class InputHelper
    {
        public static object GetValidInput(string prompt, Type type)
        {
            object? input = null;
            string inputString;
            bool isValid = false;

            do
            {
                Console.Write(prompt);
                inputString = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }

                if (type == typeof(string))
                {
                    // String validation (non-empty)
                    if (inputString == null)
                    {
                        Console.WriteLine("Input cannot be null. Please try again.");
                        continue;
                    }
                    else
                    {
                        isValid = true;
                        input = inputString;
                    }
                }
                else if (type == typeof(int))
                {
                    // Int validation
                    if (!int.TryParse(inputString, out int intInput))
                    {
                        Console.WriteLine("Invalid number format. Please enter a valid integer.");
                    }
                    else
                    {
                        isValid = true;
                        input = intInput;
                    }
                }
                else if (type == typeof(double))
                {
                    // Double validation
                    if (!double.TryParse(inputString, out double doubleInput))
                    {
                        Console.WriteLine("Invalid number format. Please enter a valid double.");
                    }
                    else
                    {
                        isValid = true;
                        input = doubleInput;
                    }
                }
                else if (type == typeof(bool))
                {
                    // Bool validation
                    if (!bool.TryParse(inputString, out bool boolInput))
                    {
                        Console.WriteLine("Invalid boolean format. Please enter true or false.");
                    }
                    else
                    {
                        isValid = true;
                        input = boolInput;
                    }
                }
                else
                {
                    Console.WriteLine("Unsupported type.");
                    break;
                }
            } while (!isValid);

            if (input == null)
            {
                throw new InvalidOperationException("No valid input was provided.");
            }

            return input;
        }
    }
}
 */
