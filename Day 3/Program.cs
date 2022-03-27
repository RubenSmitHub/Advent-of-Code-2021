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
      // SolvePart1(Filepath);
      SolvePart2(Filepath);

    }

    private static void SolvePart2(string filepath)
    {

      int BitIndex = 0;

      string[] Oxygenlines = File.ReadAllLines(filepath);
      
      bool BitValue = true;


      do
      {
        Oxygenlines = ExtractMostCommonBitLines(Oxygenlines, BitIndex, BitValue, true);
        BitIndex += 1;

      } while (Oxygenlines.Length > 1);

      int oxygenRate = Convert.ToInt32(Oxygenlines[0], 2);


      BitIndex = 0;

      string[] CO2lines = File.ReadAllLines(filepath);

      BitValue = true;

      do
      {
        CO2lines = ExtractLeastCommonBitLines(CO2lines, BitIndex, BitValue, false);
        BitIndex += 1;

      } while (CO2lines.Length > 1);

      int CO2rate = Convert.ToInt32(CO2lines[0], 2);




      Console.WriteLine($"Oxygen generation rate is {oxygenRate}");
      Console.WriteLine($"CO2 scrubber rate is {CO2rate}");
      Console.WriteLine($"Answer {oxygenRate * CO2rate}");
    }


    private static string[] ExtractLeastCommonBitLines(string[] lines, int bitIndex, bool BitValue, bool RoundUp)
    {
      List<string> HighBitValues = new List<string>();
      List<string> LowBitValues = new List<string>();


      foreach (string line in lines)
      {
        if (line.Substring(bitIndex, 1) == "1")
        {
          HighBitValues.Add(line);
        }
        else
        {
          LowBitValues.Add(line);
        }
      }

      if (HighBitValues.Count == LowBitValues.Count)
      {
        Console.WriteLine($"Equal common bit used");
        if (RoundUp)
        {
          return HighBitValues.ToArray();
        }
        else
        {
          return LowBitValues.ToArray();
        }
      }
      else if (HighBitValues.Count > LowBitValues.Count)
      {
        Console.WriteLine($"Most common is 1 at pos {bitIndex} length={HighBitValues.Count}");
        return LowBitValues.ToArray();
      }
      else
      {
        Console.WriteLine($"Most common is 0 at pos {bitIndex} length={LowBitValues.Count}");
        return HighBitValues.ToArray();
      }

    }

    private static string[] ExtractMostCommonBitLines(string[] lines, int bitIndex,bool BitValue, bool RoundUp)
    {
      List<string> HighBitValues = new List<string>();
      List<string> LowBitValues = new List<string>();


      foreach (string line in lines)
      {
        if (line.Substring(bitIndex,1) == "1")
        {
          HighBitValues.Add(line);
        }
        else
        {
          LowBitValues.Add(line);
        }
      }

      if (HighBitValues.Count == LowBitValues.Count)
      {
        Console.WriteLine($"Equal common bit used");
        if (RoundUp)
        {
          return HighBitValues.ToArray();
        }
        else
        {
          return LowBitValues.ToArray();
        }
      }
      else if (HighBitValues.Count > LowBitValues.Count)
      {
        Console.WriteLine($"Most common is 1 at pos {bitIndex} length={HighBitValues.Count}");
        return HighBitValues.ToArray();
      }
      else
      {
        Console.WriteLine($"Most common is 0 at pos {bitIndex} length={LowBitValues.Count}");
        return LowBitValues.ToArray();
      }

    }

    private static void SolvePart1(string Filepath)
    {
      int[] answers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
      int count = 0;

      foreach (string line in File.ReadAllLines(Filepath))
      {
        count++;
        Console.WriteLine($"line: {line}");

        for (int i = 0; i < 12; i++)
        {
          string character = line.Substring(11 - i, 1);
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
