using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5.Models
{
  public class Line
  {
    public LinePoint[] Points { get; set; }

    public Line(LinePoint Start, LinePoint End)
    {
      Points = new LinePoint[] {Start, End};
    }


  }
}
