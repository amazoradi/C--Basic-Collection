using System.Collections.Generic;
using System;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Mars" };
      planetList.Add("Jupiter");
      planetList.Add("Saturn");
      List<string> lastPlanet = new List<string>() {"Neptune", "Uranus"};
      planetList.AddRange(lastPlanet);
      planetList.Insert(1,"Venus");
      planetList.Insert(2, "Earth");
      planetList.Add("Pluto");
      List<string> rockyPlanets = new List<string>();
      rockyPlanets = planetList.GetRange(0,4);
      rockyPlanets.ForEach(rock => Console.WriteLine(rock));
      planetList.Remove("Pluto");
      planetList.ForEach(planet => Console.WriteLine(planet));
      
    }
  }
}
