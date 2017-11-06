using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.AnonymousThreat
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "3:1") break;

                if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);

                    if (startIndex >= 0 && startIndex < data.Count || endIndex < data.Count && endIndex >= 0)
                    {
                        if (startIndex < 0) startIndex = 0;
                        if (endIndex >= data.Count) endIndex = data.Count - 1;
                        StringBuilder merged = new StringBuilder();

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            merged.Append(data[i]);
                        }
                        data.RemoveRange(startIndex, endIndex - startIndex + 1);
                        data.Insert(startIndex, merged.ToString());
                    }
                }

                else if (input[0] == "divide")
                {
                    List<string> dividedList = new List<string>();

                    int index = int.Parse(input[1]);
                    int partitions = int.Parse(input[2]);

                    StringBuilder elementToDivide = new StringBuilder(data[index]);
                    Divide(data, dividedList, index, partitions, elementToDivide);
                }
            }
            Console.WriteLine(string.Join(" ", data));
        }

        private static void Divide(List<string> data, List<string> dividedList, int index, int partitions, StringBuilder elementToDivide)
        {
            while (true)
            {
                if (elementToDivide.Length % partitions == 0)
                {
                    int startIndex = 0;
                    for (int i = 0; i < partitions; i++)
                    {
                        string dividedWord = elementToDivide.ToString()
                            .Substring(startIndex, elementToDivide.Length / partitions);
                        startIndex += elementToDivide.Length / partitions;
                        dividedList.Add(dividedWord);
                    }
                    data.RemoveAt(index);
                    data.InsertRange(index, dividedList);
                    break;
                }
                else
                {
                    if (partitions >= elementToDivide.Length) break;
                    int element = elementToDivide.Length - 1;
                    int takeRange = element / partitions;
                    while (true)
                    {
                        if (elementToDivide.Length == 0) break;
                        if (element / 2 != elementToDivide.Length - 1)
                        {
                            dividedList.Add(elementToDivide.ToString().Substring(0, takeRange));
                            elementToDivide.Remove(0, takeRange);
                        }
                        else
                        {
                            dividedList.Add(elementToDivide.ToString());
                            elementToDivide.Remove(0, elementToDivide.Length);
                        }
                    }
                    data.RemoveAt(index);
                    data.InsertRange(index, dividedList);
                    break;
                }
            }
        }
    }
}
