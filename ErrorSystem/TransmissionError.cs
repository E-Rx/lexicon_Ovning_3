using System;

namespace lexicon_Ovning_3.ErrorSystem;

public class TransmissionError : SystemError
{
  public override string ErrorMessage()
  {
    return "Transmission Problem: Repair required!";
  }
}
