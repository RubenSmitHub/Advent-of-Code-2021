using Day_4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
  public class BingoGame
  {
    public BingoGame(List<BingoCard> cards)
    {
      Cards = cards;
    }

    public List<BingoCard> Cards { get; set; }

    public void DrawnNumber(int number)
    {
      Console.WriteLine($"Number {number} is drawn.");
      foreach (BingoCard card in Cards)
      {
        card.DrawNumber(number);
      }
    }

    public bool BingoInTheRoom()
    {
      foreach (BingoCard card in Cards)
      {
        if (card.HasBingo())
        {
          return true;
        }
      }
      return false;
    }

    public BingoCard GetWinner()
    {
      foreach (BingoCard card in Cards)
      {
        if (card.HasBingo())
        {
          return card;
        }
      }
      return null;
    }
  }
}
