using Day_5.Models;
using System;

namespace Day_5
{
  public class Map
  {
    private readonly int minX;
    private readonly int minY;
    private readonly int maxX;
    private readonly int maxY;

    public int[,] Points { get; set; }

    public Map(int minX, int minY, int maxX, int maxY)
    {
      this.minX = minX;
      this.minY = minY;
      this.maxX = maxX;
      this.maxY = maxY;

      Points = new int[maxX - minX, maxY - minY];
    }

    public void DrawLine(Line line)
    {
      foreach (Point point in line.Points)
      {
        PlotPoint(point.X, point.Y);
      }
    }

    private void PlotPoint(int x, int y)
    {
      if (x < minX | x > maxX | y < minY | y > maxY)
      {
        throw new ArgumentException("Point out of range of Map!");
      }

      Points[x, y] += 1;

    }

    public int GetNumberOverlappingPoints(int v)
    {
      int result = 0;

      for (int i = 0; i < maxX - minX; i++)
      {
        for (int j = 0; j < maxY - minY; j++)
        {
          if (Points[i,j] >= v)
          {
            result++;
          }
        }
      }

      return result;
    }
  }
}