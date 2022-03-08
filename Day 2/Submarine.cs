using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
  public class Submarine
  {
    private int locationVertical = 0;

    public int LocationHorizontal { get; set; } = 0;

    public int LocationVertical { 
      get => locationVertical; 
      set { 
        locationVertical = value;

        // A submarine can't fly
        if (locationVertical < 0) 
        { 
          locationVertical = 0; 
        } 
      }  
    }

    public void MoveHorizontal(int distance)
    {
      LocationHorizontal += distance;
    }

  }
}
