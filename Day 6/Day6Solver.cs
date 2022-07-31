using Generics;

namespace Day_6
{
  public class Day6Solver : DayBase
  {
    public List<int> InputValues { get; set; } = new List<int>();

    public override void SolvePart1()
    {
      // How many lanternfish would there be after 80 days?
      int result = SimulateNumberOfDays(80);

      Console.WriteLine($"Final answer: {result}");
      Console.WriteLine("End of part 1");
    }

    public override void SolvePart2()
    {
      // How many lanternfish would there be after 256 days?
      int result = SimulateNumberOfDaysAlt(256);

      Console.WriteLine($"Final answer: {result}");
      Console.WriteLine("End of part 2");
    }

    private int SimulateNumberOfDaysAlt(int days)
    {
      List<List<int>> fishes = new List<List<int>>();
      fishes.Add(new List<int>());
      
      throw new NotImplementedException();

    }
    private int SimulateNumberOfDays(int days)
    {
      // How many lanternfish would there be after x days?
      List<int> fishList = new List<int>(InputValues);

      for (int day = 0; day < days; day++)
      {
        fishList = SimulateDay(fishList);
        Console.WriteLine($"Day {day + 1}: {fishList.Count} fishes");
      }

      return fishList.Count;
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



  }
}