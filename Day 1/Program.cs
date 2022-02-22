using System;

namespace Day_1
{
  class Program
  {

    static void Main(string[] args)
    {
      string Filepath = $@"{Environment.CurrentDirectory}\Data\Input.txt";


      Console.WriteLine(Filepath);
        
      Submarine sm = new Submarine(
        new ScannerByFileInput(Filepath),
        new DepthIncreasedAnalyzer());

      sm.ScanArea();

      int answer;
      answer = sm.AnalyzeMeasurements();

      Console.WriteLine($"The result is {answer}");
  
      Console.ReadLine();

    }
  }
}
