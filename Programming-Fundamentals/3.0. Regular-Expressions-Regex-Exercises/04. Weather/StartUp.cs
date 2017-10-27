using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class City
    {
        public string CityName { get; set; }
        public double AvgTemperature { get; set; }
        public string Weather { get; set; }
    }
    class StartUp
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            string input = Console.ReadLine();

            List<City> listOfCities = new List<City>();

            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    City newCity = new City();
                    string cityCollection = Regex.Match(input, pattern).ToString();
                    newCity.CityName = Regex.Match(cityCollection, @"([A-Z]{2})").ToString();
                    newCity.AvgTemperature = double.Parse(Regex.Match(cityCollection, @"\d+\.\d+").ToString());
                    newCity.Weather = Regex.Match(cityCollection, @"[A-Za-z]+\|").ToString().TrimEnd('|');
                    listOfCities = CityNameCheck(listOfCities, newCity);
                    listOfCities.Add(newCity);
                }
                input = Console.ReadLine();
            }

            PrintCities(listOfCities);
        }

        private static void PrintCities(List<City> listOfCities)
        {
            foreach (var city in listOfCities.OrderBy(x => x.AvgTemperature))
            {
                Console.WriteLine($"{city.CityName} => {city.AvgTemperature:f2} => {city.Weather}");
            }
        }

        private static List<City> CityNameCheck(List<City> listOfCities, City newCity)
        {
            for (int i = 0; i < listOfCities.Count; i++)
            {
                if (listOfCities[i].CityName == newCity.CityName)
                {
                    listOfCities.RemoveAt(i);
                    break;
                }
            }
            return listOfCities;
        }
    }
}
