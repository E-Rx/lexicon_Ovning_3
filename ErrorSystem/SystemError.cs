using System;
using System.Security.Cryptography.X509Certificates;

namespace lexicon_Ovning_3.ErrorSystem;

public abstract class SystemError
{
    public abstract string ErrorMessage();
}


public class ErrorDemo
{
    public static void DemoErrorHandling()
    {
        Console.WriteLine("\n--- System Errors ---");
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
