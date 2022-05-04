using System;
using System.Collections.Generic;

namespace Day_5.Models
{
  // Algorithm used:
  // Bresenham's_line_algorithm
  // link: https://en.wikipedia.org/wiki/Bresenham's_line_algorithm

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
        List<Point> list = PlotPointsOfLine(StartPoint, EndPoint);

        return list;
      }
    }

    #region Bresenham's_line_algorithm

    private List<Point> PlotPointsOfLine(Point startPoint, Point endPoint)
    {
      if (Math.Abs(endPoint.Y - startPoint.Y) < Math.Abs(endPoint.X - startPoint.X))
      {
        if (startPoint.X > endPoint.X)
        {
          return PlotLineLow(endPoint, startPoint);
        }
        else
        {
          return PlotLineLow(startPoint, endPoint);
        }
      }
      else
      {
        if (startPoint.Y > endPoint.Y)
        {
          return PlotLineHigh(endPoint, startPoint);
        }
        else
        {
          return PlotLineHigh(startPoint, endPoint);
        }
      }
    }

    private List<Point> PlotLineHigh(Point startPoint, Point endPoint)
    {
      List<Point> result = new List<Point>();

      int dx = endPoint.X - startPoint.X;
      int dy = endPoint.Y - startPoint.Y;
      int xi = 1;

      if (dx < 0)
      {
        xi = -1;
        dx = -dx;
      }
      int D = (2 * dx) - dy;

      int x = startPoint.X;

      for (int y = startPoint.Y; y < endPoint.Y; y++)
      {
        result.Add(new Point(x, y));

        if (D > 0)
        {
          x = x + xi;
          D = D + (2 * (dx - dy));
        }
        else
        {
          D = D + 2 * dx;
        }
      }

      return result;
    }

    private List<Point> PlotLineLow(Point startPoint, Point endPoint)
    {
      List<Point> result = new List<Point>();

      int dx = endPoint.X - startPoint.X;
      int dy = endPoint.Y - startPoint.Y;
      int yi = 1;

      if (dy < 0)
      {
        yi = -1;
        dy = -dy;
      }

      int D = (2 * dy) - dx;
      int y = startPoint.Y;

      for (int x = startPoint.X; x < endPoint.X; x++)
      {
        result.Add(new Point(x, y));

        if (D > 0)
        {
          y = y + yi;
          D = D + (2 * (dy - dx));
        }
        else
        {
          D = D + 2 * dy;
        }
      }

      return result;
    }

    #endregion Bresenham's_line_algorithm
  }
}