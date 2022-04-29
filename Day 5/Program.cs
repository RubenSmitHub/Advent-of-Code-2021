using System;

namespace Day_5
{
  class Program
  {
    static void Main(string[] args)
    {
      Day5Solver Solver = new Day5Solver();
      LineReader Reader = new LineReader();

      Reader.ReadLinesFromFile(Solver.FilePath);

      Solver.SolvePuzzles();
      
      Console.WriteLine("End");
    }
  }
}
