using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVar
{
    class Program
    {
        static void Main(string[] args)
        {
            string booL = Console.ReadLine();
            Convert.ToBoolean(booL);
            if (booL == "True")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
