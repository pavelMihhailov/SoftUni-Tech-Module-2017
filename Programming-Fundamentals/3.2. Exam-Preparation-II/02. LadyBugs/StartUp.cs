using System;
using System.Linq;

namespace _02.LadyBugs
{
    class StartUp
    {
        static void Main()
        {
            long[] field = new long[long.Parse(Console.ReadLine())];
            var bugsIndexes = Console.ReadLine().Split().Select(long.Parse).ToList();
            for (int i = 0; i < field.Length; i++)
            {
                if (bugsIndexes.Contains(i)) field[i] = 1;
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "end") break;

                long index = long.Parse(command[0]);
                string direction = command[1];
                long distance = long.Parse(command[2]);
                if (index >= 0 && index < field.Length && field[index] == 1)
                {
                    field[index] = 0;
                    while (true)
                    {
                        if (direction.Equals("right"))
                        {
                            if (index + distance > field.Length - 1) break;
                            if (field[index + distance] == 1)
                            {
                                index += distance;
                                if (index > field.Length - 1) break;
                            }
                            else
                            {
                                field[index + distance] = 1;
                                break;
                            }
                        }
                        else if (direction.Equals("left"))
                        {
                            if (index - distance < 0) break;
                            if (field[index - distance] == 1)
                            {
                                index -= distance;
                                if (index < 0) break;
                            }
                            else
                            {
                                field[index - distance] = 1;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
