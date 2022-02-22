using Day_1;
using System;
using System.Collections.Generic;
using System.Text;

  class AdvancedIncreasedAnalyzer : IAnalyzer
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

      int[] averageData = new int[_data.Count];
      _data.CopyTo(averageData);


      // loop through data
      foreach (int value in _data)
      {
        int sum = Sum(averageData[index], averageData[index + 1], averageData[index + 2]);

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

    public int Sum(int value1 = 0, int value2 = 0, int value3 = 0)
    {
      return value1 + value2 + value3;
    }

  }
