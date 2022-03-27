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

      string[] lines = File.ReadAllLines(filepath);

      do
      {
        lines = ExtractMostCommonBitLines(lines, BitIndex);
        BitIndex += 1;

      } while (lines.Length > 1 | BitIndex >= 12);

      Console.WriteLine($"Final answer is {lines[0]}");

    }

    private static string[] ExtractMostCommonBitLines(string[] lines, int bitIndex)
    {
      List<string> HighBitValues = new List<string>();
      List<string> LowBitValues = new List<string>();

      BitArray bitarray;

      foreach (string line in lines)
      {
        PopulateBitArray(out bitarray, line);
        if (bitarray.Get(bitIndex))
        {
          HighBitValues.Add(line);
        }
        else
        {
          LowBitValues.Add(line);
        }
      }

      if (HighBitValues.Count > LowBitValues.Count)
      {
        Console.WriteLine($"Most common is 1 at pos {bitIndex}");
        return HighBitValues.ToArray();
      }
      else
      {
        Console.WriteLine($"Most common is 0 at pos {bitIndex}");
        return LowBitValues.ToArray();
      }

    }

    private static void PopulateBitArray(out BitArray bitarray, string line)
    {
      int[] intArray = new int[12];
      for (int i = 0; i < 12; i++)
      {
        intArray[i] = int.Parse(line.Substring(11 - i, 1));
      }

      bitarray = new BitArray(intArray);
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
