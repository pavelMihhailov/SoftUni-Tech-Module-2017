using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> rootAndSize = new Dictionary<string, decimal>();
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(';').ToArray();
                if (rootAndSize.ContainsKey(input[0]))
                {
                    rootAndSize[input[0]] = decimal.Parse(input[1]);
                }
                else
                {
                    rootAndSize.Add(input[0], decimal.Parse(input[1]));
                }
            }
            string[] extensionInRootToTake = Console.ReadLine().Split().ToArray();
            string extension = extensionInRootToTake[0];
            string root = extensionInRootToTake[2];

            foreach (var fileRoot in rootAndSize)
            {
                CheckFiles(result, extension, root, fileRoot);
            }
            PrintResult(result);
        }

        private static void PrintResult(Dictionary<string, decimal> result)
        {
            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine(file.Key + " - " + file.Value + " KB");
                }
            }
        }

        private static void CheckFiles(Dictionary<string, decimal> result, string extension, string root, KeyValuePair<string, decimal> fileRoot)
        {
            if (fileRoot.Key.StartsWith(root + "\\"))
            {
                if (fileRoot.Key.EndsWith("." + extension))
                {
                    string[] temp = fileRoot.Key.Split('\\').ToArray();
                    string fileNameExt = temp.Last();
                    if (result.ContainsKey(fileNameExt))
                    {
                        result[fileNameExt] = fileRoot.Value;
                    }
                    else
                    {
                        result.Add(fileNameExt, fileRoot.Value);
                    }
                }
            }
        }
    }
}
