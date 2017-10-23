using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaxSeqOfEqualElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var arr = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();
            int longestInt = 0;
            int longestLength = 0;
            int lastInt = 0;
            int lastLength = 0;
            foreach (var i in arr)
            {
                if (lastInt == i)
                {
                    lastLength++;
                }
                else
                {
                    lastInt = i;
                    lastLength = 1;
                }
                if (lastLength <= longestLength) continue;
                longestLength = lastLength;
                longestInt = i;
            }

            string output = string.Empty;
            for (int i = 0; i < longestLength; i++)
                output += longestInt + " ";
            File.WriteAllText("output.txt", output);
        }
    }
}
