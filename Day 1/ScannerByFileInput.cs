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

      IEnumerable<string> lines = File.ReadLines(_filepath);
      foreach(string line in lines)
      {
        ScanResults.Add(int.Parse(line));
      }
    }
  }
}
