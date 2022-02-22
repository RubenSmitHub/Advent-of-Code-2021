using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
  public class DepthIncreasedAnalyzer : IAnalyzer
  {
    private List<int> _data;

    public void SetData(List<int> Data)
    {
      _data = Data;
    }

    public void Analyze()
    {
      Result = 0;
      if (_data == null) return;

      // init variables
      int previousValue = 0;
      int index = 0;
      string message;

      // loop through data
      foreach (int value in _data)
      {
        if (index > 0)
        {
          if (previousValue < value)
          {
            message = "increased";
            Result += 1;
          }
          else if (previousValue > value)
          {
            message = "decreased";
          }
          else
          {
            message = "-";
          }
        }
        else
        {
          message = "initial";
        }

        Console.WriteLine($"{index} value:{value} ({message})");
        index++;
        previousValue = value;
      }
    }

    public int Result { get; set; }


  }
}
