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

      Solver.SolvePart1();
      Console.WriteLine($"Answer part1: {Solver.AnswerPart1}");

      Solver.SolvePart2();
      Console.WriteLine($"Answer part2: {Solver.AnswerPart2}");

      Solver.ExportMap($@"{Environment.CurrentDirectory}\output.txt");
      Console.WriteLine("End");
    }
  }
}