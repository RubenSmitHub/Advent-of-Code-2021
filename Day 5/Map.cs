using Day_5.Models;
using System;

namespace Day_5
{
  public class Map
  {
    private int minX;
    private int minY;
    private int maxX;
    private int maxY;

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
      throw new NotImplementedException();
    }

    public int GetNumberOverlappingPoints(int v)
    {
      throw new NotImplementedException();
    }
  }
}