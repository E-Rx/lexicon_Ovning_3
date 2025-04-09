using System;

namespace lexicon_Ovning_3.ErrorSystem;

public class BrakeFailureError : SystemError
{
  public override string ErrorMessage()
  {
    return "Brake Error: Vehicle is unsafe to drive!";
  }
}
