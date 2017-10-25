using System;
using System.Linq;
using System.Text;

namespace _06.SumBigNums
{
    class StartUp
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.Length > second.Length)
                 second = second.PadLeft(first.Length, '0');
            else
                 first = first.PadLeft(second.Length, '0');

            int reminder = 0;
            int sum = 0;
            int number = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = first[i] - 48 + second[i] - 48 + reminder;
                number = sum % 10;
                sb.Append(number);
                reminder = sum / 10;

                if (i == 0 && reminder > 0) sb.Append(reminder);
            }
            Console.WriteLine(new string(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}
