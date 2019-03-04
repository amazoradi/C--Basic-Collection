using System;
using System.Collections.Generic;

namespace randomNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      List<int> numbers = new List<int> {
        random.Next(10),
        random.Next(10),
        random.Next(10),
        random.Next(10),
        random.Next(10),
      };

      numbers.ForEach(num => Console.WriteLine(num));

      for (int i = 0; i < (numbers.Count); i++)
      {
       if (numbers.Contains(i))
        {
          Console.WriteLine("Number list contains: {0}", i);
        }
        else
        {
          Console.WriteLine("Number list  does NOT contains: {0}", i);
        }
      }
    }
  }
}
