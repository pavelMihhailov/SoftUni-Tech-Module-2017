using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoSecs
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong centuries = ulong.Parse(Console.ReadLine());
            ulong years = centuries * 100;
            ulong days = (ulong)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            decimal miliSeconds = seconds * 1000;
            decimal microSeconds = miliSeconds * 1000;
            decimal nanoSeconds = microSeconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = " +
                $"{miliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");
        }
    }
}
