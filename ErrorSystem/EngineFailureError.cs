using System;

namespace lexicon_Ovning_3.ErrorSystem;

public class EngineFailureError : SystemError
{
  public override string ErrorMessage()
  {
    return "Engine Error: Check engine status!";
  }
}
