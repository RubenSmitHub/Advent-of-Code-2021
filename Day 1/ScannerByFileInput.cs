using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day_1
{
  class ScannerByFileInput : IScanner
  {

    private readonly string _filepath;
    public ScannerByFileInput(string Filepath)
    {
      _filepath = Filepath;
    }

    public List<int> ScanResults { get; set; } = new List<int>();

    public void Clear()
    {
      ScanResults.Clear();
    }

    public void PerformScan()
    {
      ScanResults.Clear();

      foreach(string line in File.ReadLines(_filepath))
      {
        ScanResults.Add(int.Parse(line));
      }
    }
  }
}
