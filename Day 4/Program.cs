using Day_4.Models;
using System;
using System.Collections.Generic;

namespace Day_4
{
  class Program
  {
    static void Main(string[] args)
    {
      string Filepath = $@"{Environment.CurrentDirectory}\Data\input.txt";

      BingoInputReader reader = new BingoInputReader();
      reader.ReadFromFile(Filepath);

      List<BingoCard> cards = reader.BingoCards;
      List<int> drawn = reader.DrawnNumbers;

      Console.WriteLine($"Number of BingoCards {cards.Count}");
      Console.WriteLine($"Number of drawns {drawn.Count}");

      BingoGame game = new BingoGame(cards);

      int TurnIndex = 0;
      while (game.BingoInTheRoom() == false)
      {
        game.DrawnNumber(drawn[TurnIndex]);
        TurnIndex++;
      }
      Console.WriteLine("BINGO!");
      Console.WriteLine($"Answer = {drawn[TurnIndex - 1] * game.GetWinner().SumOfUnmarkedNumbers()}");
      
    }
  }
}
