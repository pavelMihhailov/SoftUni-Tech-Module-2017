using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var infoData = new Dictionary<string, Dictionary<string, long>>();

            string[] input = Console.ReadLine().Split('|');

            while (input[0] != "report")
            {
                string countryName = input[1];
                string cityName = input[0];
                long population = long.Parse(input[2]);
                if (!infoData.ContainsKey(countryName))
                {
                    infoData.Add(countryName, new Dictionary<string, long>());
                }
                infoData[countryName].Add(cityName, population);

                input = Console.ReadLine().Split('|');
            }

            foreach (var country in infoData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Dictionary<string, long> countryInfo = country.Value;

                Console.WriteLine($"{country.Key} (total population: {countryInfo.Values.Sum()})");

                foreach (var data in countryInfo.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{data.Key}: {data.Value}");
                }
            }
            
        }
    }
}
