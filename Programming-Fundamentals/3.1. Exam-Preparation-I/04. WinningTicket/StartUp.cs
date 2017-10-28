using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.WinningTicket
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim()).ToArray();

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length == 20)
                {
                    string leftHalf = tickets[i].Substring(0, 10);
                    string rightHalf = tickets[i].Substring(10, 10);
                    CheckTicket(tickets, i, leftHalf, rightHalf);
                }
                else
                    Console.WriteLine("invalid ticket");
            }
        }

        private static void CheckTicket(string[] tickets, int i, string leftHalf, string rightHalf)
        {
            if (Regex.IsMatch(leftHalf, @"\${6,10}") && Regex.IsMatch(rightHalf, @"\${6,10}"))
            {
                int matchLength = Math.Min(
                    Regex.Match(leftHalf, @"\${6,10}").ToString().Length,
                    Regex.Match(rightHalf, @"\${6,10}").ToString().Length);
                if (matchLength < 10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}$");
                }
                else if (matchLength == 10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}$ Jackpot!");
                }
            }
            else if (Regex.IsMatch(leftHalf, @"\@{6,10}") && Regex.IsMatch(rightHalf, @"\@{6,10}"))
            {
                int matchLength = Math.Min(
                    Regex.Match(leftHalf, @"\@{6,10}").ToString().Length,
                    Regex.Match(rightHalf, @"\@{6,10}").ToString().Length);
                if (matchLength < 10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}@");
                }
                else if (matchLength == 10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}@ Jackpot!");
                }
            }
            else if (Regex.IsMatch(leftHalf, @"\#{6,10}") && Regex.IsMatch(rightHalf, @"\#{6,10}"))
            {
                int matchLength = Math.Min(
                    Regex.Match(leftHalf, @"\#{6,10}").ToString().Length,
                    Regex.Match(rightHalf, @"\#{6,10}").ToString().Length);
                if (matchLength < 10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}#");
                }
                else if (matchLength == 10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}# Jackpot!");
                }
            }
            else if (Regex.IsMatch(leftHalf, @"\^{6,10}") && Regex.IsMatch(rightHalf, @"\^{6,10}"))
            {
                int matchLength = Math.Min(
                    Regex.Match(leftHalf, @"\^{6,10}").ToString().Length,
                    Regex.Match(rightHalf, @"\^{6,10}").ToString().Length);
                if (matchLength < 10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}^");
                }
                else if (matchLength == 10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}^ Jackpot!");
                }
            }
            else
            {
                Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
            }
        }
    }
}
