using System;

namespace Day_1
{
  class Program
  {

    static void Main(string[] args)
    {

      Submarine sm = new Submarine(new ScannerByFileInput(""));

      sm.ScanArea();
      sm.AnalyzeMeasurements();


      Console.WriteLine("Hello World!");      
      Console.ReadLine();

    }
  }
}
