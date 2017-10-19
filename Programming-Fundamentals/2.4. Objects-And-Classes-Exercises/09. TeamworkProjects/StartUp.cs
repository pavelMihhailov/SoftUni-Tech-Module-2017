using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string CreatorName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teamList = new List<Team>();
            AddingTeams(n, teamList);
            JoiningTeams(teamList);

            List<Team> listToDisband = new List<Team>();

            CheckFor0members(teamList, listToDisband);

            Print(teamList, listToDisband);
        }

        private static void Print(List<Team> teamList, List<Team> listToDisband)
        {
            var resultTeamList = teamList.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName);
            foreach (var team in resultTeamList)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- " + team.CreatorName);
                foreach (var members in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine("-- " + members);
                }
            }
            Console.WriteLine("Teams to disband:");
            if (listToDisband.Count > 0)
            {
                foreach (var teams in listToDisband)
                {
                    Console.WriteLine(string.Join("\r\n", teams.TeamName));
                }
            }
        }

        private static void CheckFor0members(List<Team> teamList, List<Team> listToDisband)
        {
            for (int i = 0; i < teamList.Count; i++)
            {
                if (teamList[i].Members.Count == 0)
                {
                    listToDisband.Add(teamList[i]);
                    teamList.Remove(teamList[i]);
                }
            }
        }

        private static void JoiningTeams(List<Team> teamList)
        {
            while (true)
            {
                var secondaryInput = Console.ReadLine();
                if (secondaryInput == "end of assignment") break;
                bool existsTeamName = false;
                bool existsMember = false;
                var mainInput = secondaryInput.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < teamList.Count; i++)
                {
                    if (teamList[i].Members.Contains(mainInput[0]))
                    {
                        existsMember = true;
                    }
                    if (!teamList[i].TeamName.Contains(mainInput[1]))
                    {
                        continue;
                    }
                    else
                    {
                        existsTeamName = true;
                    }
                }
                if (existsTeamName == false)
                {
                    Console.WriteLine("Team {0} does not exist!", mainInput[1]);
                }
                if (existsMember == true)
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", mainInput[0], mainInput[1]);
                }
                else if (existsMember == false)
                {
                    bool checkForCreator = false;
                    for (int i = 0; i < teamList.Count; i++)
                    {
                        for (int j = 0; j < teamList.Count; j++)
                        {
                            if (teamList[i].CreatorName == mainInput[0])
                            {
                                checkForCreator = true;
                            }
                        }
                        if (checkForCreator == false)
                        {
                            if (teamList[i].TeamName == mainInput[1])
                            {
                                teamList[i].Members.Add(mainInput[0]);

                            }
                        }
                    }
                }
            }
        }

        private static void AddingTeams(int n, List<Team> teamList)
        {
            for (int i = 0; i < n; i++)
            {
                bool created = true;
                var team = new Team();
                var input = Console.ReadLine().Split('-').ToArray();
                team.Members = new List<string>();
                team.TeamName = input[1];
                team.CreatorName = input[0];

                for (int j = 0; j < teamList.Count; j++)
                {
                    if (team.TeamName == teamList[j].TeamName)
                    {
                        Console.WriteLine("Team {0} was already created!", team.TeamName);
                        created = false;
                    }
                    if (team.CreatorName == teamList[j].CreatorName)
                    {
                        Console.WriteLine("{0} cannot create another team!", team.CreatorName);
                        created = false;
                    }
                }
                if (created)
                {
                    teamList.Add(team);
                    Console.WriteLine("Team {0} has been created by {1}!", input[1], input[0]);
                }
            }
        }
    }
}
