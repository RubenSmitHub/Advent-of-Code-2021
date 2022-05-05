namespace Day_5.Models
{
  public class Point
  {
    public int X;
    public int Y;

    public Point()
    {
    }

    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }

    public static Point Parse(string v)
    {
      Point pnt = new Point(
        int.Parse(v[..v.IndexOf(",")]),
        int.Parse(v[(v.IndexOf(",") + 1)..])
        );

      return pnt;
    }
  }
}