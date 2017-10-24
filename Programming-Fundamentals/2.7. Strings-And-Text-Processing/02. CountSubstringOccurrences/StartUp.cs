using System;

namespace _02.CountSubstringOccurrences
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string searchedWord = Console.ReadLine().ToLower();
            int cnt = 0;
            int index = -1;

            while (true)
            {
                if (input.IndexOf(searchedWord, index + 1) != -1)
                {
                    cnt++;
                    index = input.IndexOf(searchedWord, index + 1);
                }
                else
                    break;
            }
            Console.WriteLine(cnt);
        }
    }
}
