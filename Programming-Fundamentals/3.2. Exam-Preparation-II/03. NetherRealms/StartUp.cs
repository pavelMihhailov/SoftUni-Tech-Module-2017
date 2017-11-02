using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.NetherRealms
{
    class Demon
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
    }

    class StartUp
    {
        static void Main()
        {
            string patternForNumbers = @"([-+]?(\d+\.)?\d+)";
            string patternForLetters = @"[^\d+\-*/.]";

            List<Demon> resultList = new List<Demon>();

            string[] input = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();
                double damage = 0;
                double health = 0;
                CalculateHealthAndDamage(patternForNumbers, patternForLetters, input, i, ref damage, ref health);
                Demon newDemon = new Demon() { Name = input[i], Health = health, Damage = damage };
                resultList.Add(newDemon);
            }
            foreach (var demon in resultList.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        private static void CalculateHealthAndDamage(string patternForNumbers, string patternForLetters, string[] input, int i, ref double damage, ref double health)
        {
            MatchCollection numberCollection = Regex.Matches(input[i], patternForNumbers);
            foreach (Match numberMatch in numberCollection)
            {
                damage += double.Parse(numberMatch.Value);
            }
            MatchCollection lettersCollection = Regex.Matches(input[i], patternForLetters);

            foreach (Match match in lettersCollection)
            {
                health += char.Parse(match.ToString());
            }
            foreach (var symbol in input[i])
            {
                if (symbol == '*') damage *= 2;
                if (symbol == '/') damage /= 2;
            }
        }
    }
}
