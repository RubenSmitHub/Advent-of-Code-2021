using Day_5.Models;
using Generics;
using System;
using System.IO;
using System.Text;

namespace Day_5
{
  internal class Day5Solver : DayBase
  {
    public Day5Solver(LineReader reader)
    {
      Reader = reader;
    }

    public int AnswerPart1 { get; set; } = 0;
    public LineReader Reader { get; }

    public Map map { get; set; }
    public override void SolvePart1()
    {
      map = new Map(Reader.MinX, Reader.MinY, Reader.MaxX, Reader.MaxY);

      foreach (var Line in Reader.Lines)
      {
        if (Line.IsHorizontal | Line.IsVertical)
        {
          map.DrawLine(Line);
        }

        int Result = map.GetNumberOverlappingPoints(2);

        AnswerPart1 = Result;
      }
    }

    public void ExportMap(string filename)
    {
      StringBuilder sb = new StringBuilder();
      for (int y = 0; y <= map.Height; y++)
      {
        for (int x = 0; x <= map.Width; x++)
        {
          if (map.Points[x,y] == 0)
          {
            sb.Append(".");
          }
          else
          {
            sb.Append(map.Points[x, y]);
          }
        }
        sb.AppendLine();
      }

      File.WriteAllText(filename, sb.ToString());
    }
  }
}