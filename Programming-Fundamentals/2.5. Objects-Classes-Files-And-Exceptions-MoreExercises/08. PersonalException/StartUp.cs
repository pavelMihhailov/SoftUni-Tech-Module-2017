using System;
using _08.PersonalException;

namespace _08.PersonalException
{
    public class PersonallException : Exception
    {
        public PersonallException() : base("My first exception is awesome!!!")
        {
        }
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            while (true)
            {
                var n = int.Parse(Console.ReadLine());
                if (n < 0)
                    throw new PersonallException();
                Console.WriteLine(n);
            }
        }
        catch (PersonallException fe)
        {
            Console.WriteLine(fe.Message);
        }
    }
}