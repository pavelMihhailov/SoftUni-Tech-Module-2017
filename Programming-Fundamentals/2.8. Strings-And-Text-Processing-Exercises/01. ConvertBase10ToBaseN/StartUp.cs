using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.ConvertBase10ToBaseN
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<BigInteger> result = new List<BigInteger>();

            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger convertInBase = input[0];
            BigInteger base10Num = input[1];
            
            while (base10Num != 0)
            {
                result.Insert(0, base10Num % convertInBase);
                base10Num /= convertInBase;
            }
            
            Console.WriteLine(string.Join("", result));
        }
    }
}
