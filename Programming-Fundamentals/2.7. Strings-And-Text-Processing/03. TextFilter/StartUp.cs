using System;
using System.Linq;

namespace _03.TextFilter
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                string stars = new string('*', banWord.Length);
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, stars);
                }
            }
            Console.WriteLine(text);
        }
    }
}
