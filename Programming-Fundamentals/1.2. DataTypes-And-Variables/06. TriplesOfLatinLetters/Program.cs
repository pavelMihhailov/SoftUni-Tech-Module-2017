using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char lastLetter = (char)('a' + n - 1);
            for (char firstLetter = 'a'; firstLetter <= lastLetter; firstLetter++)
            {
                for (char secondLetter = 'a'; secondLetter <= lastLetter; secondLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter <= lastLetter; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
