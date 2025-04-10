using System;

namespace lexicon_Ovning_3.ErrorSystem;

// This class demonstrates the error handling system
public class ErrorDemo
{
  public static void DemoErrorHandling() //
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("\n=== System Errors ===");
      Console.WriteLine("");
      Console.ResetColor();
      List<SystemError> errors = new List<SystemError>
      {
        new EngineFailureError(),
        new BrakeFailureError(),
        new TransmissionError()
      };

      foreach (var error in errors)
      {
          Console.WriteLine(error.ErrorMessage());
      }
    }
}
