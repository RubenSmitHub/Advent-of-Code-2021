using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
  public class Submarine
  {
    private readonly IScanner _scanner;
    private readonly IAnalyzer _analyzer;

    public Submarine(IScanner scanner, IAnalyzer analyzer)
    {
      _scanner = scanner;
      _analyzer = analyzer;
    }
    public void ScanArea()
    {
      _scanner.PerformScan();
    }

    public int AnalyzeMeasurements()
    {
      _analyzer.SetData(_scanner.ScanResults);
      _analyzer.Analyze();

      return _analyzer.Result;
    }
  }
}
