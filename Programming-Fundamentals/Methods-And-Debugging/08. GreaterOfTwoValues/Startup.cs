using System;

namespace _08.GreaterOfTwoValues
{
    class Startup
    {
        static int GetMax(int a, int b)
        {
            {
                if (a >= b) return a;

                else return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a >= b) return a;
            
            else return b;
        }
        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) >= 0) return a;
            
            else return b;
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "char")
            {
                char a = Char.Parse(Console.ReadLine());
                char b = Char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
        }
    }
}
