using System;
using System.Text;

namespace _03.UnicodeChars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            foreach (char letter in input)
            {
                result.Append("\\u");
                result.Append(String.Format("{0:x4}", (int) letter));
            }
            Console.WriteLine(result.ToString());
        }
    }
}
