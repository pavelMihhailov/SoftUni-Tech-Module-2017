using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string cuttedWord1 = word.Substring(word.Length - 1);
            string cuttedWord2 = word.Substring(word.Length - 2);
            string worddddd = word.Remove(word.Length - 1);

            if (word.EndsWith("y"))
            {
                Console.WriteLine($"{worddddd}ies");
            }
            else if (word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z"))
            {
                Console.WriteLine($"{word}es");
            }
            else if (word.EndsWith("ch") || word.EndsWith("sh"))
            {
                Console.WriteLine($"{word}es");
            }
            else
            {
                Console.WriteLine($"{word}s");
            }
        }
    }
}
