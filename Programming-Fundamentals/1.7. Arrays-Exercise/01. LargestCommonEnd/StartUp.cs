using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ').ToArray();
            string[] array2 = Console.ReadLine().Split(' ').ToArray();
            string[] reversed1 = array1.Reverse().ToArray();
            string[] reversed2 = array2.Reverse().ToArray();

            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] == array2[i])
                {
                    leftCount++;
                }
            }
            for (int i = 0; i < Math.Min(reversed1.Length, reversed2.Length); i++)
            {
                if (reversed1[i] == reversed2[i])
                {
                    rightCount++;
                }
            }
            Console.WriteLine(Math.Max(leftCount, rightCount));
        }
    }
}
