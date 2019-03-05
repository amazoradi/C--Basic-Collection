using System;
using System.Collections.Generic;

namespace hashSet
{
  class Program
  {
    static void Main(string[] args)
    {
      HashSet<string> Showroom = new HashSet<string>();
      Showroom.Add("Malcaron F1");
      Showroom.Add("Aston Martin V12 Vanquish");
      Showroom.Add("Dodge Challenger");
      Showroom.Add("Tesla Model X");
      Console.WriteLine($"Number of cars in my showroom: {Showroom.Count}");
      Showroom.Add("Tesla Model X");
      Console.WriteLine($"Number of cars in my showroom: {Showroom.Count}");

      HashSet<string> UsedLot = new HashSet<string>();
      UsedLot.Add("Mini Van Halen");
      UsedLot.Add("Dillon 2 Mobile");

      Showroom.UnionWith(UsedLot);

      

      

      HashSet<string> Junkyard = new HashSet<string>();
      Junkyard.Add("Nissan Sentra");
      Junkyard.Add("Jess mobile");
      Junkyard.Add("Dodge Challenger");
      Junkyard.Add("Tesla Model X");
      Junkyard.Add("Mini Van Halen");
      Junkyard.Add("Dillon 2 Mobile");

      HashSet<string> clone = new HashSet<string>(Showroom);

      clone.IntersectWith(Junkyard);

      Showroom.UnionWith(Junkyard);
      Showroom.Remove("Nissan Sentra"); 

      foreach (string car in Showroom)
      {
        Console.WriteLine(car);
      }

      
    }
  }
}
