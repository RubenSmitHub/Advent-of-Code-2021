using System;

namespace Day_4
{
  class Program
  {
    static void Main(string[] args)
    {
      string Filepath = $@"{Environment.CurrentDirectory}\Data\input.txt";

      BingoInputReader reader = new BingoInputReader();
      reader.ReadFromFile(Filepath);

      Console.WriteLine("Hello World!");
    }
  }
}
