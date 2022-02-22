using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
  public class Submarine
  {
    private readonly IScanner _scanner;

    public Submarine(IScanner scanner)
    {
      _scanner = scanner;
    }
    public void ScanArea()
    {
      _scanner.PerformScan();
    }

    public void AnalyzeMeasurements()
    {

    }
  }
}
