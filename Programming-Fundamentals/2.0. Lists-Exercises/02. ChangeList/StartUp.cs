using System;
using System.Linq;

namespace _02.ChangeList
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    for (var i = 0; i < nums.Count; i++)
                        if (nums[i] == int.Parse(command[1]))
                        {
                            nums.Remove(nums[i]);
                            i--;
                        }
                }
                else if (command[0] == "Insert")
                {
                    var element = int.Parse(command[1]);
                    var position = int.Parse(command[2]);
                    nums.Insert(position, element);
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            if (command[0] == "Odd")
            {
                for (var i = 0; i < nums.Count; i++)
                    if (nums[i] % 2 != 0)
                        Console.Write(nums[i] + " ");
                Console.WriteLine();
            }
            else
            {
                for (var i = 0; i < nums.Count; i++)
                    if (nums[i] % 2 == 0)
                        Console.Write(nums[i] + " ");
                Console.WriteLine();
            }
        }
    }
}