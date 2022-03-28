using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4.Models
{
  public class BingoCard
  {
    public BingoCard()
    {

    }

    public BingoCard(int[,] values)
    {
      
      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < 5; j++)
        {
          BingoCardField field = new BingoCardField(values[i,j]);
          Fields[i,j] = field;
        }
      }
    }

    /// <summary>
    /// Fields [row,column]
    /// </summary>
    public BingoCardField[,] Fields { get; set; } = new BingoCardField[5, 5];


    public BingoCardField[] GetRow(int index)
    {
      return new BingoCardField[5] {
        Fields[index,0],
        Fields[index,1],
        Fields[index,2],
        Fields[index,3],
        Fields[index,4]
      };

    }
    #region "Row methods"

    public BingoCardField[] GetColumn(int index)
    {
      return new BingoCardField[5] {
        Fields[0,index],
        Fields[1,index],
        Fields[2,index],
        Fields[3,index],
        Fields[4,index]
      };

    }

    public BingoCardField[] GetTopLeftButtomRightDiagonal()
    {
      return new BingoCardField[5] {
        Fields[0,0],
        Fields[1,1],
        Fields[2,2],
        Fields[3,3],
        Fields[4,4]
      };
    }

    public BingoCardField[] GetButtomLeftTopRightDiagonal()
    {
      return new BingoCardField[5] {
        Fields[4,0],
        Fields[3,1],
        Fields[2,2],
        Fields[1,3],
        Fields[0,4]
      };
    }

    #endregion

    private bool BingoInRange(BingoCardField[] selection)
    {
      bool result = true;

      foreach (BingoCardField item in selection)
      {
        result &= item.IsDrawn;
      }

      return result;
    }

    public bool HasBingo
    {
      get
      {
        for (int i = 0; i < 5; i++)
        {
          if (BingoInRange(GetRow(i)) | BingoInRange(GetColumn(i)))
          {
            return true;
          }
        }

        if (BingoInRange(GetTopLeftButtomRightDiagonal()) |
            BingoInRange(GetButtomLeftTopRightDiagonal()))
        {
          return true;
        }

        return false;
      }
    }

    public void DrawNumber(int number)
    {
      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < 5; j++)
        {
          if (Fields[i,j].Number == number)
          {
            Fields[i,j].IsDrawn = true;
          }
        }
      }
    }


    public int SumOfUnmarkedNumbers()
    {
      int calc = 0;

      foreach (BingoCardField field in Fields)
      {
        if (field.IsDrawn == false)
        {
          calc += field.Number;
        }
      }

      return calc;
    }
  }
}
