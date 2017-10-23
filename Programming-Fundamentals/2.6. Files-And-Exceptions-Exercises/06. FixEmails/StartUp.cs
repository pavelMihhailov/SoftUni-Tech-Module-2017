using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _06.FixEmails
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            var input = File.ReadAllLines("input.txt");
            for (var i = 0; i < input.Length; i += 2)
            {
                var name = input[i];
                if (name == "stop")
                    break;
                string email = input[i + 1];
                if (email.ToLower().EndsWith("us") ||
                    email.ToLower().EndsWith("uk"))
                    continue;
                emails[name] = email;
            }
            var output = emails
                .Select(email => $"{email.Key} -> {email.Value}")
                .ToList();
            File.WriteAllLines("output.txt", output);
        }
    }
}
