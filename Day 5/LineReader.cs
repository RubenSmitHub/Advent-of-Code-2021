using Day_5.Models;
using System.Collections.Generic;
using System.IO;

namespace Day_5
{
  public class LineReader
  {
    private const string PointSeparetor = " -> ";
    public int MinX { get; set; } = int.MaxValue;

    public int MinY { get; set; } = int.MaxValue;

    public int MaxX { get; set; } = int.MinValue;

    public int MaxY { get; set; } = int.MinValue;

    public List<Line> Lines { get; set; } = new List<Line>();

    public void ReadLinesFromFile(string filename)
    {
      Lines.Clear();

      foreach (string Line in File.ReadAllLines(filename))
      {
        Line NewLine = new Line
        {
          StartPoint = Point.Parse(Line[..Line.IndexOf(PointSeparetor)]),
          EndPoint = Point.Parse(Line[(Line.IndexOf(PointSeparetor) + PointSeparetor.Length)..])
        };

        if (NewLine.MinX < MinX) MinX = NewLine.MinX;

        if (NewLine.MinY < MinY) MinY = NewLine.MinY;

        if (NewLine.MaxX > MaxX) MaxX = NewLine.MaxX;

        if (NewLine.MaxY > MaxY) MaxY = NewLine.MaxY;

        Lines.Add(NewLine);
      }
    }
  }
}