using Day_1;
using System;
using System.Collections.Generic;
using System.Text;

  class AdvancedIncreasedAnalyzer : IAnalyzer
{
  private int prevAvg = 0;
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
    int[] averageData = new int[_data.Count];
    _data.CopyTo(averageData);
    prevAvg = 0;

    for (int i = 0; i < _data.Count - 2; i++)
    {
      int avg = Sum(averageData[i], averageData[i+1], averageData[i+2]);


      if (i > 0)
      {
        if (prevAvg < avg)
        {
          Result += 1;
        }
      }

      prevAvg = avg;
    }

  }

    public int Result { get; set; }

    public int Sum(int value1 = 0, int value2 = 0, int value3 = 0)
    {
      return value1 + value2 + value3;
    }

  }
