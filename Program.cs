using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;


namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, int> cohortCount = 
           new Dictionary<string, int>();

           cohortCount.Add("Cohort 34", 20);
           cohortCount.Add("Cohort 35", 14);
           cohortCount.Add("Cohort 36", 28);
           cohortCount.Add("Cohort 37", 28);
           foreach(KeyValuePair <string, int> item in cohortCount)
           {
              Console.WriteLine($"{item.Key} has {item.Value} students");
           }
              

              Dictionary<string, double> productListing = new Dictionary<string, double>()
              {
                  {"Deoderant", 4.50},
                  {"Hair Brush", 4.50},
                  {"Deoderant", 4.50},
                  {"Tooth Brush", 45.50},
                  {"hairspray", 4.50},
              };


              foreach(KeyValuePair<string, double> product in productListing)
              {
                  Console.WriteLine($"{product.Key} costs ${product.Value}");
              }



        }
    }
}
