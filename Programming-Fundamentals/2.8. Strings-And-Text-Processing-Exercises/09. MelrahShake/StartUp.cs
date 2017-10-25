using System;

namespace _09.MelrahShake
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);
                int shakes = 0;

                if (firstIndex >= 0) shakes++;
                if (lastIndex >= 0) shakes++;

                if (shakes == 2 && firstIndex != lastIndex && pattern.Length > 0)
                {
                    input = input.Remove(firstIndex, pattern.Length);
                    lastIndex = input.LastIndexOf(pattern);
                    input = input.Remove(lastIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                    break;
                pattern = pattern.Remove(pattern.Length / 2, 1);
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
