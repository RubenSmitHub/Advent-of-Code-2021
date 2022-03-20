using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Day_3
{
  class Program
  {
    static void Main(string[] args)
    {
      string Filepath = $@"{Environment.CurrentDirectory}\Data\input.txt";
      
      int[] answers = { 0,0,0,0,0,0,0,0,0,0,0,0};
      int count = 0;

      foreach (string line in File.ReadAllLines(Filepath))
      {
        count++;
        Console.WriteLine($"line: {line}");

        for (int i = 0; i < 12; i++)
        {
          string character = line.Substring(11- i, 1);
          Console.WriteLine($" {character}");
          int value = int.Parse(character);
          answers[i] += value;

        }
      }

      Console.WriteLine($"answer {answers.ToString()}");

      BitArray gammaRateBuilder = new BitArray(12);
      BitArray epsilonRateBuilder = new BitArray(12);


      for (int i = 0; i < 12; i++)
      {
        gammaRateBuilder.Set(i, answers[i] >= (count / 2));
        epsilonRateBuilder.Set(i, answers[i] <= (count / 2));

        
      }


      int[] epsilonRate = new int[1];
      epsilonRateBuilder.CopyTo(epsilonRate, 0);

      int[] gammaRate = new int[1];
      gammaRateBuilder.CopyTo(gammaRate, 0);

      Console.WriteLine($"epsilon rate: {epsilonRate[0]}");
      Console.WriteLine($"gamma rate: {gammaRate[0]}");

      Console.WriteLine($"Final answer: {epsilonRate[0] * gammaRate[0]}");

      
    }
  }
}
