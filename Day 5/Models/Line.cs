using System;
using System.Collections.Generic;

namespace Day_5.Models
{
  public class Line
  {
    public int MinX
    {
      get
      {
        if (StartPoint.X < EndPoint.X)
        {
          return StartPoint.X;
        }
        else
        {
          return EndPoint.X;
        }
      }
    }

    public int MinY
    {
      get
      {
        if (StartPoint.Y < EndPoint.Y)
        {
          return StartPoint.Y;
        }
        else
        {
          return EndPoint.Y;
        }
      }
    }

    public int MaxX
    {
      get
      {
        if (StartPoint.X < EndPoint.X)
        {
          return EndPoint.X;
        }
        else
        {
          return StartPoint.X;
        }
      }
    }

    public int MaxY
    {
      get
      {
        if (StartPoint.Y < EndPoint.Y)
        {
          return EndPoint.Y;
        }
        else
        {
          return StartPoint.Y;
        }
      }
    }

    public Boolean IsHorizontal
    {
      get
      {
        return (StartPoint.Y == EndPoint.Y);
      }
    }

    public Boolean IsVertical
    {
      get
      {
        return (StartPoint.X == EndPoint.X);
      }
    }

    public Point StartPoint { get; set; } = new Point();
    public Point EndPoint { get; set; } = new Point();

    /// <summary>
    /// Get all points on the line.
    /// </summary>
    public List<Point> Points 
    {
      get
      {
        List<Point> list = new List<Point>();

        // Algorithm used:
        // Bresenham's_line_algorithm
        // link: https://en.wikipedia.org/wiki/Bresenham's_line_algorithm

        int dx = StartPoint.X - EndPoint.X;
        int dy = StartPoint.Y - EndPoint.Y;
        int D = 2 * dy - dx;
        int y = StartPoint.Y;


        for (int x = StartPoint.X; x < EndPoint.X; x++)
        {
          list.Add(new Point(x, y));

          if (D > 0)
          {
            y = y + 1;
            D = D - 2 * dx;
          }
          
          D = D + 2 * dy;

        }


        return list;
      } 
    }
  }
}