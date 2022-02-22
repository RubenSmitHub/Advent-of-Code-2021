using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
  public interface IAnalyzer
  {
    void SetData(List<int> Data);
    void Analyze();

    public int Result { get; set; }
  }
}
