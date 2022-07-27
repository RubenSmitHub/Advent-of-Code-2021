using Generics;

namespace Day_6
{
  public class Day6Solver : DayBase
  {
    public override void SolvePart1()
    {
      // How many lanternfish would there be after 80 days?
      List<int> fishList = new List<int>(InputValues);

      for (int day = 0; day < 80; day++)
      {
        fishList = SimulateDay(fishList);
        Console.WriteLine($"Day {day + 1}: {fishList.Count} fishes");
      }

      Console.WriteLine($"Final answer: {fishList.Count}");
    }

    private List<int> SimulateDay(List<int> input)
    {
      int newFishes = 0;

      for (int i = 0; i < input.Count; i++)
      {
        int current = input[i];
        if (current > 0)
        {
          current--;
        }
        else
        {
          newFishes++;
          current = 6;
        }

        input[i] = current;
      }

      List<int> result = new List<int>(input);
      while (newFishes > 0)
      {
        result.Add(8);
        newFishes--;
      }

      return result;
    }

    public List<int> InputValues { get; set; } = new List<int>();
  }
}