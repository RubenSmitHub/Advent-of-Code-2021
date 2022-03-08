namespace Day_2
{
  public interface IMoveCommand
  {
    Direction Direction { get; set; }
    int Distance { get; set; }

    void Execute(ref Submarine sm);
  }
  public enum Direction
  {
    Forward,
    Backward,
    Up,
    Down
  }
}