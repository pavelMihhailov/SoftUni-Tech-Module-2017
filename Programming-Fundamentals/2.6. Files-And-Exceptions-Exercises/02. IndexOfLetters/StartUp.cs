using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IndexOfLetters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string str = File.ReadAllText("input.txt");
            var output = str.Select(c => c + " -> " + (c - 'a')).ToArray();
            File.WriteAllLines("output.txt", output);
        }
    }
}
