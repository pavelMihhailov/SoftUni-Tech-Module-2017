using System.IO;
using System.Linq;

namespace _05.WriteToFile
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("sample_text.txt");
            var newText = text.Where(x => ".:,!?".IndexOf(x) == -1).ToArray();

            File.WriteAllText("textWithoutPunctuation.txt", string.Join("", newText));
        }
    }
}
