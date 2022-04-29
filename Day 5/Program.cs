using System;

namespace Day_5
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      LineReader Reader = new LineReader();
      Day5Solver Solver = new Day5Solver(Reader);

      Reader.ReadLinesFromFile(Solver.FilePath);

      Console.WriteLine($"MinX: {Reader.MinX}");
      Console.WriteLine($"MinY: {Reader.MinY}");
      Console.WriteLine($"MaxX: {Reader.MaxX}");
      Console.WriteLine($"MaxY: {Reader.MaxY}");

      Solver.SolvePuzzles();

      Console.WriteLine("End");
    }
  }
}