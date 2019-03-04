using System;
using System.Collections.Generic;

namespace dictionaries
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> stocks = new Dictionary<string, string>();
      stocks.Add("GM", "General Motors");
      stocks.Add("CAT", "Caterpillar");
      stocks.Add("APP", "Apple");
      stocks.Add("BROC", "JoeShep");
      stocks.Add("Barn", "JCash");
      foreach (KeyValuePair<string, string> s in stocks)
      {
        Console.WriteLine($"{s.Key}, {s.Value}");
      }
      string GM = stocks["GM"];
      Console.WriteLine($"{GM} is the name");
      List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
      purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
      purchases.Add(new Dictionary<string, double>() { { "GM", 580.98 } });
      purchases.Add(new Dictionary<string, double>() { { "GM", 406.34 } });
      purchases.Add(new Dictionary<string, double>() { { "CAT", 999.21 } });
      purchases.Add(new Dictionary<string, double>() { { "Barn", 101010.12 } });
      purchases.Add(new Dictionary<string, double>() { { "BROC", 22.34 } });


      Dictionary<string, double> aggregated = new Dictionary<string,double>();
      aggregated.Add("GM", 1247.43);
      aggregated.Add("CAT", 999.21);
      aggregated.Add("Barn", 101010.12);
      aggregated.Add("BROC", 22.34);
    
      Dictionary<string, int> stockReport = new Dictionary<string, int>();
      foreach (Dictionary<string, double> purchase in purchases)
      {
        {
          foreach (KeyValuePair<string, double> stock in purchase)
          {
            foreach (KeyValuePair<string, string> s in stocks)
            {
              if (stock.Key == s.Key)
              
              Console.WriteLine($"{s.Value} {stock.Value}");
            }

          }
        }
      }
    }
  }
}
