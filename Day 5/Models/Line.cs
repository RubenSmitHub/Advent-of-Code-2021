using System;

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

  }
}