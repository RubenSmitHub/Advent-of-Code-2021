namespace Day_2
{
  public class MoveCommand : IMoveCommand
  {
    public int Distance { get ; set; }

    public Direction Direction { get; set; }

    public static MoveCommand FromString(string Text)
    {
      MoveCommand cmd = new MoveCommand();
      string textDirection = Text.Trim().Split(" ")[0].ToUpper();
      string textDistance = Text.Trim().Split(" ")[1];

      cmd.Distance = int.Parse(textDistance);

      switch (textDirection)
      {
        case "FORWARD":
          cmd.Direction = Direction.Forward;
          break;
        case "BACKWARD":
          cmd.Direction = Direction.Backward;
          break;
        case "UP":
          cmd.Direction = Direction.Up;
          break;
        case "DOWN":
          cmd.Direction = Direction.Down;
          break;
      }

      return cmd;
    }

    public void Execute(ref Submarine sm)
    {
      switch (Direction)
      {
        case Direction.Forward:
          sm.LocationHorizontal += Distance;
          break;
        case Direction.Backward:
          sm.LocationHorizontal -= Distance;
          break;
        case Direction.Up:
          sm.LocationVertical -= Distance;
          break;
        case Direction.Down:
          sm.LocationVertical += Distance;
          break;
      }

    }
  }


}