using System;

namespace Generics
{
  /// <summary>
  /// Base class for reading input provided by AOC and Creating uniform method names for solving the solutions.
  /// </summary>
  public abstract class DayBase
  {
    private string _filepath = $@"{Environment.CurrentDirectory}\Data\input.txt";

    /// <summary>
    /// Filepath to the input data.
    /// </summary>
    /// <value>
    /// {CurrentDirectory}\Data\input.txt
    /// </value>
    /// <remarks>
    /// Make sure to set the Property 'Copy to Output Directory' to Copy Always.
    /// </remarks>
    public string FilePath
    {
      get { return _filepath; }
      set { _filepath = value; }
    }

    /// <summary>
    /// Call this method to Run the SolvePart1 and SolvePart2 sub methods
    /// </summary>
    public virtual void SolvePuzzles()
    {
      SolvePart1();
      SolvePart2();
    }

    public virtual void SolvePart1()
    {
    }

    public virtual void SolvePart2()
    {
    }
  }
}