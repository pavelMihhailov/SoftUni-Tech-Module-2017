using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint distance = uint.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            float timeSeconds = hours * 3600 + minutes * 60 + seconds;

            float metersPerSecs = distance / timeSeconds;
            
            float metersToKm = distance / 1000;

            float timeHours = timeSeconds / 3600;
            float killometersPerHour = metersToKm / timeHours;
            float milesPerHour = (metersToKm / 1.609f) / timeHours;

            Console.WriteLine(metersPerSecs);
            Console.WriteLine(killometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
