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
      //SolvePart1(cards, drawn);
      SolvePart2(cards, drawn);

    }

    private static void SolvePart2(List<BingoCard> cards, List<int> drawn)
    {
      Console.WriteLine($"Number of BingoCards {cards.Count}");
      Console.WriteLine($"Number of drawns {drawn.Count}");

      BingoGame game = new BingoGame(cards);

      int TurnIndex = 0;
      while (game.Cards.FindAll(s => s.HasBingo== false).Count > 1)
      {
        game.DrawnNumber(drawn[TurnIndex]);
        TurnIndex++;
      }

      Console.WriteLine("1 card left!");
      BingoCard WorstCard = game.Cards.Find(s => s.HasBingo== false);

      //continue run until last bingo is reached
      while (game.Cards.FindAll(s => s.HasBingo == false).Count > 0)
      {
        game.DrawnNumber(drawn[TurnIndex]);
        TurnIndex++;
      }

      Console.WriteLine($"Answer = {drawn[TurnIndex - 1] * WorstCard.SumOfUnmarkedNumbers()}");

    }

    private static void SolvePart1(List<BingoCard> cards, List<int> drawn)
    {
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
