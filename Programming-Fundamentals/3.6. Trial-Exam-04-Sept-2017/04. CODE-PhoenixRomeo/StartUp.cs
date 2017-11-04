using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CODE_PhoenixRomeo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> creatureSquadMate = new Dictionary<string, List<string>>();
            Dictionary<string, int> creatureAndCountOfMates = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Blaze it!") break;

                string[] mainInput = input.Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string creature = mainInput[0];
                string squadMate = mainInput[1];

                if (squadMate != creature)
                {
                    if (creatureSquadMate.ContainsKey(creature))
                    {
                        if (!creatureSquadMate[creature].Contains(squadMate))
                        {
                            creatureSquadMate[creature].Add(squadMate);
                        }
                    }
                    else
                    {
                        creatureSquadMate.Add(creature, new List<string>());
                        creatureSquadMate[creature].Add(squadMate);
                    }
                }
            }

            CalculatingCreaturesCount(creatureSquadMate, creatureAndCountOfMates);

            foreach (var creature in creatureAndCountOfMates.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{creature.Key} : {creature.Value}");
            }
        }

        private static void CalculatingCreaturesCount(Dictionary<string, List<string>> creatureSquadMate, Dictionary<string, int> creatureAndCountOfMates)
        {
            foreach (var creature in creatureSquadMate)
            {
                int count = 0;
                for (int i = 0; i < creature.Value.Count; i++)
                {
                    bool hasThatName = false;
                    if (creatureSquadMate.ContainsKey(creature.Value[i]))
                    {
                        if (creatureSquadMate[creature.Value[i]].Contains(creature.Key)) hasThatName = true;
                    }
                    if (hasThatName == false) count++;
                }
                creatureAndCountOfMates.Add(creature.Key, count);
            }
        }
    }
}
