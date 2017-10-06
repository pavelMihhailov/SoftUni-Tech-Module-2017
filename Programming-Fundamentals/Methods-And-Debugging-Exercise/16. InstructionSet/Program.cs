using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            long result = 0;
            while (command != "END")
            {
                string[] codeArgs = command.Split(' ');
                
                switch (codeArgs[0])
                {
                    case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        break;
                    }
                    case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        break;
                    }
                    case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                    case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = (long) (operandOne * operandTwo);
                        break;
                    }
                        

                }
                Console.WriteLine(result);
                command = Console.ReadLine();
            }
        }
    }
}
