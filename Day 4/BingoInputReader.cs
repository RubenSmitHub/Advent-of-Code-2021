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
          // Read bingo cards
        }
      }
    }

  }
}
