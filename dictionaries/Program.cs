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
     
      string GM = stocks["GM"];

      List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
      purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
      purchases.Add(new Dictionary<string, double>() { { "GM", 580.98 } });
      purchases.Add(new Dictionary<string, double>() { { "GM", 406.34 } });
      purchases.Add(new Dictionary<string, double>() { { "CAT", 999.21 } });
      purchases.Add(new Dictionary<string, double>() { { "Barn", 101010.12 } });
      purchases.Add(new Dictionary<string, double>() { { "BROC", 22.34 } });

      Dictionary<string, double> stockReport = new Dictionary<string, double>();

      foreach (Dictionary<string, double> purchase in purchases)
      {
        {
          foreach (KeyValuePair<string, double> stock in purchase)
          {

            string companyName = stocks[stock.Key];
            double stockValue = stock.Value;

            if (!stockReport.ContainsKey(companyName))
            {
              stockReport.Add(companyName, stockValue);
            }
            else
            {
              stockReport[companyName] += stockValue;
            }
          }
        }
      }
      foreach (KeyValuePair<string, double> item in stockReport)
      {
        Console.WriteLine($"My stock in {item.Key} is worth {item.Value}");
      }
    }
  }
}
