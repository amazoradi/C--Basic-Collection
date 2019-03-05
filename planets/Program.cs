using System;
using System.Collections.Generic;

namespace planets
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Saturn", "Jupiter", "Uranus", "Neptune" };

      List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
      probes.Add(new Dictionary<string, string>() { { "Mercury", "The Hackman" } });
      probes.Add(new Dictionary<string, string>() { { "Venus", "JFlop" } });
      probes.Add(new Dictionary<string, string>() { { "Venus", "BarnDog" } });
      probes.Add(new Dictionary<string, string>() { { "Earth", "Lazy Jones" } });
      probes.Add(new Dictionary<string, string>() { { "Mars", "Planet Express" } });
      probes.Add(new Dictionary<string, string>() { { "Saturn", "Big Boi" } });
      probes.Add(new Dictionary<string, string>() { { "Jupiter", "Purrfect" } });
      probes.Add(new Dictionary<string, string>() { { "Uranus", "Dillon2" } });
      probes.Add(new Dictionary<string, string>() { { "Uranus", "Zacky Sack" } });
      probes.Add(new Dictionary<string, string>() { { "Uranus", "Brondon" } });
      probes.Add(new Dictionary<string, string>() { { "Neptune", "The Brenda Roger" } });

      foreach (string planet in planetList) // iterate planets
      {
        List<string> matchingProbes = new List<string>();

        foreach (Dictionary<string, string> probe in probes) // iterate probes
        {
          if (probe.ContainsKey(planet))
          {
            foreach (KeyValuePair<string, string> p in probe)
            {
              matchingProbes.Add(p.Value);
            }

          }
        
        }
        Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
      }
    }
  }
}
