using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
  public class FileReader
  {
    private List<int> _results;

    public FileReader(string Filename)
    {
      var content = File.ReadAllText(Filename).Split(",");

      _results = new List<int>();

      foreach (string s in content)
      {
        _results.Add(int.Parse(s));
      }
    }

    public List<int> ListFromFile { get => _results; }
  }
}
