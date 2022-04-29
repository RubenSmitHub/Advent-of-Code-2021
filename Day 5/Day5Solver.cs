using Day_5.Models;
using Generics;

namespace Day_5
{
  internal class Day5Solver : DayBase
  {
    public Day5Solver(LineReader reader)
    {
      Reader = reader;
    }

    public LineReader Reader { get; }

    public override void SolvePart1()
    {
      Map map = new Map(Reader.MinX, Reader.MinY, Reader.MaxX, Reader.MaxY);

      foreach (var Line in Reader.Lines)
      {
        if (Line.IsHorizontal | Line.IsVertical)
        {
          map.DrawLine(Line);
        }

        int Result = map.GetNumberOverlappingPoints(2);
      }
    }
  }
}