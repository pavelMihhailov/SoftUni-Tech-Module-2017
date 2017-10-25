using System;
using System.Linq;
using System.Text;

namespace _07.MultiplyBigNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());

            if (num == "0" || multiplier == 0 || num == "")
            {
                Console.WriteLine(0);
                return;
            }
            int reminder = 0;
            int sum = 0;
            int number = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = num.Length - 1; i >= 0; i--)
            {
                sum = (int)(int.Parse(num[i].ToString()) * multiplier + reminder);
                number = (int)(sum % 10);
                sb.Append(number);
                reminder = (int)(sum / 10);

                if (i == 0 && reminder != 0) sb.Append(reminder);
            }

            Console.WriteLine(new string(sb.ToString().ToCharArray().Reverse().ToArray()));
        }
    }
}
