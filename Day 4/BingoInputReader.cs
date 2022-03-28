using Day_4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_4
{
  public class BingoInputReader
  {
    public List<BingoCard> BingoCards { get; set; } = new List<BingoCard>();

    public List<int> DrawnNumbers { get; set; } = new List<int>();

    public void ReadFromFile(string filepath)
    {
      DrawnNumbers.Clear();
      BingoCards.Clear();

      using (StreamReader sr = new StreamReader(filepath))
      {
        int[] _drawnNumbers = Array.ConvertAll(sr.ReadLine().Split(","), s => int.Parse(s));

        DrawnNumbers.AddRange(_drawnNumbers);

        while (sr.EndOfStream == false)
        {
          
          sr.ReadLine();  // blank line

          int[] row0values = ReadValuesFromLine(sr.ReadLine());
          int[] row1values = ReadValuesFromLine(sr.ReadLine());
          int[] row2values = ReadValuesFromLine(sr.ReadLine());
          int[] row3values = ReadValuesFromLine(sr.ReadLine());
          int[] row4values = ReadValuesFromLine(sr.ReadLine());

          int[,] bingocardValues = CreateBingoCardFromRows(row0values, row1values, row2values, row3values, row4values);

          BingoCard card = new BingoCard(bingocardValues);
          BingoCards.Add(card);

        }
      }
    }

    private int[,] CreateBingoCardFromRows(int[] row0values, int[] row1values, int[] row2values, int[] row3values, int[] row4values)
    {
      int[,] result = new int[5, 5];

      for (int i = 0; i < 5; i++)
      {
        result[0, i] = row0values[i];
        result[1, i] = row1values[i];
        result[2, i] = row2values[i];
        result[3, i] = row3values[i];
        result[4, i] = row4values[i];

      }

      return result;
    }

    private int[] ReadValuesFromLine(string line)
    {
      string formattedline = line.Trim();
      formattedline = formattedline.Replace("  ", " ");

      string[] strresults = formattedline.Split(" ");

      int[] results = Array.ConvertAll(strresults, s => int.Parse(s));

      return results;
    }
  }
}
