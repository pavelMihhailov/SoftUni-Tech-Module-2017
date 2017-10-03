using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            int magic1 = 0;
            int magic2 = 0;

            for (int n1 = N; n1 <= M; n1++)
            {
                for (int n2 = N; n2 <= M; n2++)
                {
                    combinations++;
                    if (n1 + n2 == magicNum)
                    {
                        magic1 = n1;
                        magic2 = n2;
                    }
                }
            }
            if (magic1 + magic2 == magicNum)
            {
                Console.WriteLine($"Number found! {magic1} + {magic2} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }

        }
    }
}
