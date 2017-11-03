using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PokemonEvolution
{
    class Pokemon
    {
        public string Name { get; set; }
        public List<KeyValuePair<string, long>> EvolutionTypeAndIndex { get; set; }
    }

    class StartUp
    {
        static void Main()
        {
            List<Pokemon> resultList = new List<Pokemon>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0] == "wubbalubbadubdub") break;

                if (input.Length > 1)
                {
                    bool hasThatName = false;

                    for (int i = 0; i < resultList.Count; i++)
                    {
                        if (resultList[i].Name == input[0])
                        {
                            resultList[i].EvolutionTypeAndIndex.Add(new KeyValuePair<string, long>(input[1], long.Parse(input[2])));
                            hasThatName = true;
                        }
                    }

                    if (hasThatName == false)
                    {
                        Pokemon newPokemon = new Pokemon { EvolutionTypeAndIndex = new List<KeyValuePair<string, long>>(), Name = input[0] };
                        newPokemon.EvolutionTypeAndIndex.Add(new KeyValuePair<string, long>(input[1], long.Parse(input[2])));
                        resultList.Add(newPokemon);
                    }
                }
                else
                {
                    PrintPokemon(resultList, input);
                }
            }

            foreach (var pokemon in resultList)
            {
                Console.WriteLine($"# {pokemon.Name}");
                foreach (var type in pokemon.EvolutionTypeAndIndex.OrderByDescending(d => d.Value))
                {
                    Console.WriteLine($"{type.Key} <-> {type.Value}");
                }
            }
        }

        private static void PrintPokemon(List<Pokemon> resultList, string[] input)
        {
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].Name == input[0])
                {
                    Console.WriteLine($"# {input[0]}");
                    foreach (var type in resultList[i].EvolutionTypeAndIndex)
                    {
                        Console.WriteLine($"{type.Key} <-> {type.Value}");
                    }
                }
            }
        }
    }
}
