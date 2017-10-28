using System;
using System.Linq;

namespace _01.SinoTheWalker
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long[] time = Console.ReadLine().Split(':').Select(long.Parse).ToArray();
            long hoursLeave = time[0];
            long minutesLeave = time[1];
            long secondsLeave = time[2];
            long steps = long.Parse(Console.ReadLine());
            long secondsPerStep = long.Parse(Console.ReadLine());
            
            long secondsWalking = steps * secondsPerStep;

            long totalSecondsAll = secondsLeave + minutesLeave * 60 + hoursLeave * 3600 + secondsWalking;
            long seconds = totalSecondsAll % 60;
            long minutes = (totalSecondsAll / 60) % 60;
            long hours = (totalSecondsAll / 3600) % 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
