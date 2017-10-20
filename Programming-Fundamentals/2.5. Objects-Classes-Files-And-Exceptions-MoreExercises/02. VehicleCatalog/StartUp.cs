using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.VehicleCatalog
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; } 
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            List<Vehicle> listVehicles = new List<Vehicle>();
            ReadVehicles(listVehicles);

            ReadCatalogue(listVehicles);
            List<int> carsAvg, trucksAvg;
            CheckFor0Avg(listVehicles, out carsAvg, out trucksAvg);

            Console.WriteLine("Cars have average horsepower of: {0:f2}.", carsAvg.Average());
            Console.WriteLine("Trucks have average horsepower of: {0:f2}.", trucksAvg.Average());
        }

        private static void ReadVehicles(List<Vehicle> listVehicles)
        {
            while (true)
            {
                Vehicle newVehicle = new Vehicle();
                string[] vehicleInfo = Console.ReadLine().Split().ToArray();
                if (vehicleInfo[0] == "End") break;
                newVehicle.Type = vehicleInfo[0].ToLower();
                newVehicle.Model = vehicleInfo[1];
                newVehicle.Color = vehicleInfo[2];
                newVehicle.Horsepower = int.Parse(vehicleInfo[3]);
                listVehicles.Add(newVehicle);
            }
        }

        private static void ReadCatalogue(List<Vehicle> listVehicles)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Close the Catalogue") break;
                foreach (var vehicle in listVehicles)
                {
                    if (vehicle.Model == input && vehicle.Type == "car")
                    {
                        Console.WriteLine($"Type: Car\nModel: {vehicle.Model}\nColor: {vehicle.Color}\nHorsepower: {vehicle.Horsepower}");
                    }
                    else if (vehicle.Model == input && vehicle.Type == "truck")
                    {
                        Console.WriteLine($"Type: Truck\nModel: {vehicle.Model}\nColor: {vehicle.Color}\nHorsepower: {vehicle.Horsepower}");
                    }
                }
            }
        }

        private static void CheckFor0Avg(List<Vehicle> listVehicles, out List<int> carsAvg, out List<int> trucksAvg)
        {
            carsAvg = new List<int>();
            trucksAvg = new List<int>();
            foreach (var vehicle in listVehicles)
            {
                if (vehicle.Type == "car")
                {
                    carsAvg.Add(vehicle.Horsepower);
                }
                else
                {
                    trucksAvg.Add(vehicle.Horsepower);
                }
            }
            if (carsAvg.Count == 0)
            {
                carsAvg.Add(0);
            }
            if (trucksAvg.Count == 0)
            {
                trucksAvg.Add(0);
            }
        }
    }
}
