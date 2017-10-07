using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.currentPriceChange
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            decimal tresHold = decimal.Parse(Console.ReadLine());
            decimal lastPrice = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                decimal currentPrice = decimal.Parse(Console.ReadLine());
                decimal diff = percentDiff(lastPrice, currentPrice); bool isSignificantDiff = isDiff(diff, tresHold);
                
                string message = GetOutput(currentPrice, lastPrice, diff, isSignificantDiff);
                Console.WriteLine(message);
                lastPrice = currentPrice;
            }
        }

        private static string GetOutput(decimal currentPrice, decimal lastPrice, decimal procentDiff, bool etherTrueOrFalse)
        {
            string print = "";
            if (procentDiff == 0)
            {
                print = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!etherTrueOrFalse)
            {
                print = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, procentDiff * 100);
            }
            else if (etherTrueOrFalse && (procentDiff > 0))
            {
                print = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, procentDiff * 100);
            }
            else if (etherTrueOrFalse && (procentDiff < 0))
                print = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, procentDiff * 100);
            return print;
        }
        private static bool isDiff(decimal Diff, decimal tresHold)
        {
            if (Math.Abs(Diff) >= tresHold)
            {
                return true;
            }
            return false;
        }

        private static decimal percentDiff(decimal lastPrice, decimal currentPrice)
        {
            decimal diff = (currentPrice - lastPrice) / lastPrice;
            return diff;
        }
    }
}
