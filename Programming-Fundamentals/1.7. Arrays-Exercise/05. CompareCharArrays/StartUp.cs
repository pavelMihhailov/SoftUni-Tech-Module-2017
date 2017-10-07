using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (array1.Length < array2.Length)
            {
                Console.WriteLine(string.Join("", array1));
                Console.WriteLine(string.Join("", array2));
            }
            else if (array2.Length < array1.Length)
            {
                Console.WriteLine(string.Join("", array2));
                Console.WriteLine(string.Join("", array1));
            }

            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == array2[i])
                    {
                        continue;
                    }

                    if (array1[i] < array2[i])
                    {
                        Console.WriteLine(string.Join("", array1));
                        Console.WriteLine(string.Join("", array2));
                        return;
                    }
                    else if (array2[i] < array1[i])
                    {
                        Console.WriteLine(string.Join("", array2));
                        Console.WriteLine(string.Join("", array1));
                        return;
                    }
                }
                Console.WriteLine(string.Join("", array1));
                Console.WriteLine(string.Join("", array2));
            }
        }
    }
}
