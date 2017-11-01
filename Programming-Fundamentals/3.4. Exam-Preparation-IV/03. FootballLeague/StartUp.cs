using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.FootballLeague
{
    internal class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Goals { get; set; }
    }

    internal class StartUp
    {
        private static void Main()
        {
            var key = Console.ReadLine();
            var pattern = $@"{Regex.Escape(key)}(?<team>.*?){Regex.Escape(key)}";
            var leagueStandings = new List<Team>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "final") break;

                var match = Regex.Matches(input, pattern).Cast<Match>().Select(t => t.Value).ToArray();

                var team1 = match[0];
                var team2 = match[1];

                team1 = ReverseTeams(team1, key);
                team2 = ReverseTeams(team2, key);

                var resultTeam1 =
                    int.Parse(Regex.Match(input, @"(?<teamA>[0-9]+):(?<teamB>[0-9]+)").Groups["teamA"].Value);
                var resultTeam2 =
                    int.Parse(Regex.Match(input, @"(?<teamA>[0-9]+):(?<teamB>[0-9]+)").Groups["teamB"].Value);
                int teamAPoints;
                int teamBPoints;

                CalculatePoints(resultTeam1, resultTeam2, out teamAPoints, out teamBPoints);
                LeagueStandingTeam(leagueStandings, team1, resultTeam1, teamAPoints);
                LeagueStandingTeam(leagueStandings, team2, resultTeam2, teamBPoints);
            }
            Print(leagueStandings);
        }

        private static void Print(List<Team> leagueStandings)
        {
            Console.WriteLine("League standings:");
            var place = 1;
            foreach (var team in leagueStandings.OrderByDescending(team => team.Points).ThenBy(team => team.Name))
            {
                Console.WriteLine($"{place}. {team.Name} {team.Points}");
                place++;
            }
            Console.WriteLine("Top 3 scored goals:");
            var teams = 1;
            foreach (var team in leagueStandings.OrderByDescending(team => team.Goals).ThenBy(t => t.Name))
            {
                if (teams == 4) break;
                Console.WriteLine($"- {team.Name} -> {team.Goals}");
                teams++;
            }
        }

        private static void LeagueStandingTeam(List<Team> leagueStandings, string team1, int resultTeam1,
            int teamAPoints)
        {
            var foundTeam = false;

            foreach (var team in leagueStandings)
                if (team.Name == team1)
                {
                    foundTeam = true;
                    team.Points += teamAPoints;
                    team.Goals += resultTeam1;
                    break;
                }
            if (!foundTeam)
                leagueStandings.Add(new Team {Name = team1, Goals = resultTeam1, Points = teamAPoints});
        }

        private static void CalculatePoints(int resultTeam1, int resultTeam2, out int teamA, out int teamB)
        {
            if (resultTeam1 > resultTeam2)
            {
                teamA = 3;
                teamB = 0;
            }
            else if (resultTeam2 > resultTeam1)
            {
                teamB = 3;
                teamA = 0;
            }
            else
            {
                teamA = 1;
                teamB = 1;
            }
        }

        private static string ReverseTeams(string team, string key)
        {
            team = team.Substring(key.Length, team.Length - 2 * key.Length).ToUpper();
            var newTeam = new StringBuilder();
            var result = new StringBuilder();
            for (var i = team.Length - 1; i >= 0; i--)
                newTeam.Append(team[i]);
            return newTeam.ToString();
        }
    }
}