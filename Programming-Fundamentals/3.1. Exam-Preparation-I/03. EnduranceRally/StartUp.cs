using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] driversNames = Console.ReadLine().Split();
            double[] trackLayouts = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<string, double> driverInfo = new Dictionary<string, double>();


            for (int dr = 0; dr < driversNames.Length; dr++)
            {
                int zone = 0;
                if (!driverInfo.ContainsKey(driversNames[dr]))
                {
                    driverInfo.Add(driversNames[dr], driversNames[dr].First());
                }

                for (int i = 0; i < trackLayouts.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        driverInfo[driversNames[dr]] += trackLayouts[i];
                    }
                    else
                    {
                        driverInfo[driversNames[dr]] -= trackLayouts[i];
                        if (driverInfo[driversNames[dr]] <= 0)
                        {
                            zone = i;
                            break;
                        }
                    }
                }
                PrintDriverInfo(driversNames, driverInfo, dr, zone);
                driverInfo.Remove(driversNames[dr]);
            }
        }

        private static void PrintDriverInfo(string[] driversNames, Dictionary<string, double> driverInfo, int dr, int zone)
        {
            foreach (var driver in driverInfo)
            {
                if (driver.Value > 0)
                {
                    Console.WriteLine($"{driver.Key} - fuel left {driver.Value:f2}");
                }
                else
                {
                    Console.WriteLine($"{driversNames[dr]} - reached {zone}");
                }
            }
        }
    }
}
