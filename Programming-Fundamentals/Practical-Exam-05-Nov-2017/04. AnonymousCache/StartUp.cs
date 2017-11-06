using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AnonymousCache
{
    internal class DataSet
    {
        public string DataName { get; set; }
        public List<string> DataKey { get; set; }
        public long DataSize { get; set; }
    }

    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var resultList = new List<DataSet>();
            var cache = new List<DataSet>();

            while (true)
            {
                var input = Console.ReadLine().Split(" -> |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "thetinggoesskrra") break;

                if (input.Length == 1)
                {
                    var dataSet = input[0];
                    var newDataSet = new DataSet {DataKey = new List<string>()};

                    var hasThatName = false;

                    for (var i = 0; i < cache.Count; i++)
                        if (cache[i].DataName == dataSet)
                        {
                            newDataSet.DataName = dataSet;
                            newDataSet.DataKey.AddRange(cache[i].DataKey);
                            newDataSet.DataSize += cache[i].DataSize;
                            hasThatName = true;
                        }
                    if (hasThatName)
                        resultList.Add(newDataSet);
                    if (hasThatName == false)
                    {
                        newDataSet.DataName = dataSet;
                        resultList.Add(newDataSet);
                    }
                }

                else
                {
                    var dataKey = input[0];
                    var dataSize = long.Parse(input[1]);
                    var dataSet = input[2];

                    var alreadyContainsDataSet = false;

                    for (var i = 0; i < resultList.Count; i++)
                        if (resultList[i].DataName == dataSet)
                        {
                            resultList[i].DataKey.Add(dataKey);
                            resultList[i].DataSize += dataSize;
                            alreadyContainsDataSet = true;
                        }
                    if (alreadyContainsDataSet == false)
                    {
                        var newDataSet = new DataSet {DataKey = new List<string>()};
                        newDataSet.DataName = dataSet;
                        newDataSet.DataKey.Add(dataKey);
                        newDataSet.DataSize += dataSize;
                        cache.Add(newDataSet);
                    }
                }
            }
            foreach (var dataSet in resultList.OrderByDescending(d => d.DataSize))
            {
                Console.WriteLine($"Data Set: {dataSet.DataName}, Total Size: {dataSet.DataSize}");

                foreach (var dataKey in dataSet.DataKey)
                    Console.WriteLine($"$.{dataKey}");
                break;
            }
        }
    }
}