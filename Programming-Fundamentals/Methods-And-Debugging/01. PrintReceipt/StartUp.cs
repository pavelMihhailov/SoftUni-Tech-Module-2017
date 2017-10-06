using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndDebugging
{
    class StartUp
    {
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT \n------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        static void PrintBottom()
        {
            Console.WriteLine("------------------------------\n© SoftUni");
        }
        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintBottom();
        }
        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
