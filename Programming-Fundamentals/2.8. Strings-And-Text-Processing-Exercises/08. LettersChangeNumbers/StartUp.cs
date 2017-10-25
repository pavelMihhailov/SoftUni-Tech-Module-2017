using System;
using System.Linq;
using System.Text;

namespace _08.LettersChangeNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result += SequenceResult(input[i]);
            }
            Console.WriteLine("{0:f2}", result);
        }

        public static decimal SequenceResult(string firstSeq)
        {
            char firstLetter = firstSeq.First();
            char lastLetter = firstSeq.Last();
            decimal result = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < firstSeq.Length - 1; i++)
            {
                sb.Append(firstSeq[i]);
            }
            
            decimal num = decimal.Parse(sb.ToString());

            //upperCaseFirstLetter
            if (firstLetter >= 65 && firstLetter <= 90)
            {
                result = num / (firstLetter - 64);
                num = num / (firstLetter - 64);
            }
            
            //lowerCaseFirstLetter
            else if (firstLetter >= 97 && firstLetter <= 122)
            {
                result = num * (firstLetter - 96);
                num = num * (firstLetter - 96);
            }
            //upperCaseLastLetter
            if (lastLetter >= 65 && lastLetter <= 90)
            {
                result = num - (lastLetter - 64);
                num = num - (lastLetter - 64);
            }
            //lowerCaseLastLetter
            else if (lastLetter >= 97 && lastLetter <= 122)
            {
                result = num + (lastLetter - 96);
                num = num + (lastLetter - 96);
            }
            return result;
        }
    }
}
