using System;

namespace _01.CharityMarathon
{
    class StartUp
    {
        static void Main()
        {
            long marathonLengthInDays = long.Parse(Console.ReadLine());
            long participants = long.Parse(Console.ReadLine());
            long avgNumberOfLaps = long.Parse(Console.ReadLine());
            long lenghtOfTrack = long.Parse(Console.ReadLine());
            long capacityOfTrack = long.Parse(Console.ReadLine());
            double moneyDonatedPerKm = double.Parse(Console.ReadLine());

            long totalCapacityOfTrack = marathonLengthInDays * capacityOfTrack;

            long runners = 0;

            if (totalCapacityOfTrack >= participants)
            {
                runners = participants;
            }
            else
            {
                runners = totalCapacityOfTrack;
            }
            long totalMeters = runners * avgNumberOfLaps * lenghtOfTrack;
            long totalKm = totalMeters / 1000;
            double totalMoneyDonated = totalKm * moneyDonatedPerKm;

            Console.WriteLine("Money raised: {0:f2}", totalMoneyDonated);
        }
    }
}
