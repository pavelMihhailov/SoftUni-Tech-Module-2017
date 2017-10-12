using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    nums.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "addMany")
                {
                    for (int i = command.Length - 1; i >= 2; i--)
                    {
                        nums.Insert(int.Parse(command[1]), int.Parse(command[i]));
                    }
                }
                else if (command[0] == "contains")
                {
                    if (nums.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine(nums.FindIndex(x => x == int.Parse(command[1])));
                    }
                    else Console.WriteLine("-1");
                }
                else if (command[0] == "remove") nums.RemoveAt(int.Parse(command[1]));
                else if (command[0] == "shift")
                {
                    List<int> list = new List<int>();
                    int amount = int.Parse(command[1]);
                    amount = amount % nums.Count;
                    for (int i = 0; i < amount; i++)
                    {
                        list.Add(nums[0]);
                        nums.Remove(nums[0]);
                    }
                    nums.AddRange(list);
                }
                else if (command[0] == "sumPairs")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (i + 1 != nums.Count)
                        {
                            nums[i] += nums[i + 1];
                            nums.RemoveAt(i + 1);
                        }
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine("[" + string.Join(", ", nums) + "]");

        }
    }
}
