using System;
using System.Security.Cryptography.X509Certificates;

namespace lexicon_Ovning_3;

public abstract class SystemError
{
    public abstract string ErrorMessage();
}

public class EngineFailureError : SystemError
{
  public override string ErrorMessage()
  {
    return "Engine Error: Check engine status!";
  }
}

public class BrakeFailureError : SystemError
{
  public override string ErrorMessage()
  {
    return "Brake Error: Vehicle is unsafe to drive!";
  }
}
public class TransmissionError : SystemError
{
  public override string ErrorMessage()
  {
    return "Transmission Problem: Repair required!";
  }
}
