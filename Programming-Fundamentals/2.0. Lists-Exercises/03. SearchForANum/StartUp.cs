using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] commandNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> resultList = new List<int>();
            bool found = false;

            for (int i = 0; i < commandNums[0]; i++)
            {
                resultList.Add(nums[i]);
            }
            for (int i = 0; i < commandNums[1]; i++)
            {
                resultList.Remove(resultList[0]);
            }
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i] == commandNums[2]) found = true;
            }
            if (found == true) Console.WriteLine("YES!");
            else Console.WriteLine("NO!");
        }
    }
}
