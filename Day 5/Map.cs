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

    public int Width 
    { get
      {
        return maxX - minX;
      } 

    }

    public int Height
    {
      get
      {
        return maxY - minY;
      }
    }

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
        PlotPoint(point.X - minX, point.Y - minY);
      }
    }

    private void PlotPoint(int x, int y)
    {
      Points[x, y] += 1;
    }

    public int GetNumberOverlappingPoints(int minimalNumberOfCrossings)
    {
      int result = 0;

      for (int i = 0; i < maxX - minX; i++)
      {
        for (int j = 0; j < maxY - minY; j++)
        {
          if (Points[i,j] >= minimalNumberOfCrossings)
          {
            result++;
          }
        }
      }

      return result;
    }
  }
}