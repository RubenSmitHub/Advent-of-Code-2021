using System;
using System.Collections.Generic;
using System.IO;


namespace Day_2
{
  class Program
  {
    static void Main(string[] args)
    {
      Submarine sm = new Submarine();

      string Filepath = $@"{Environment.CurrentDirectory}\Data\Input.txt";

      foreach(string line in File.ReadAllLines(Filepath))
      {
        MoveCommand cmd = MoveCommand.FromString(line);
        cmd.Execute(ref sm);
      }

      Console.WriteLine($"The final answer is {sm.LocationHorizontal * sm.LocationVertical}");
      
    }
  }
}
