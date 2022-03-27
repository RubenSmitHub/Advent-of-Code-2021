using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4.Models
{
  public class BingoCardField
  {
    public int Number { get; set; }

    public bool IsDrawn { get; set; }

    public BingoCardField(int number)
    {
      Number = number;
      IsDrawn = false;
    }
  }
}
