using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PokemonDontGo
{
    class StartUp
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            int sum = 0;

            while (true)
            {
                if (sequence.Count == 0) break;
                int index = int.Parse(Console.ReadLine());
                int removedElement;

                if (index < 0)
                {
                    removedElement = sequence.First();
                    sum += removedElement;
                    sequence.RemoveAt(0);
                    int lastIndex = sequence.Last();
                    sequence.Insert(0, lastIndex);
                    IncreaseAndDecreaseElements(sequence, removedElement);
                }
                else if (index >= sequence.Count)
                {
                    removedElement = sequence.Last();
                    sum += removedElement;
                    sequence.RemoveAt(sequence.Count - 1);
                    int firstIndex = sequence.First();
                    sequence.Insert(sequence.Count, firstIndex);
                    IncreaseAndDecreaseElements(sequence, removedElement);
                }
                else
                {
                    removedElement = sequence[index];
                    sum += removedElement;
                    sequence.RemoveAt(index);
                    IncreaseAndDecreaseElements(sequence, removedElement);
                }
            }
            Console.WriteLine(sum);
        }

        private static void IncreaseAndDecreaseElements(List<int> sequence, int removedElement)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] > removedElement)
                {
                    sequence[i] -= removedElement;
                }
                else
                {
                    sequence[i] += removedElement;
                }
            }
        }
    }
}
