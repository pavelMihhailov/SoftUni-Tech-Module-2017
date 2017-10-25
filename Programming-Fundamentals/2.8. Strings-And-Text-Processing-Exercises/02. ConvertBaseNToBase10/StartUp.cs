using System;
using System.Linq;
using System.Numerics;

namespace _02.ConvertBaseNToBase10
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            var baseToConvert = input[0];
            var numToConvert = input[1];
            var index = 0;
            BigInteger result = 0;

            while (true)
            {
                BigInteger forSum = 0;
                forSum = BigInteger.Multiply(numToConvert % 10, BigInteger.Pow(baseToConvert, index));
                result += forSum;
                index++;
                numToConvert /= 10;
                if (numToConvert <= 0)
                    break;
            }
            Console.WriteLine(result);
        }
    }
}