using System;

namespace Day_6 // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      
      Day6Solver solver = new Day6Solver();
      FileReader reader = new FileReader(solver.FilePath);

      solver.InputValues = reader.ListFromFile;

      solver.SolvePuzzles();

    }
  }
}