using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
  public interface IScanner
  {

    public List<int> ScanResults { get; set; }

    void PerformScan();

    void Clear();

  }
}
