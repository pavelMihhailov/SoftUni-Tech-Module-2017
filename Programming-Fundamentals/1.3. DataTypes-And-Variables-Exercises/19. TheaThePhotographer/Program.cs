using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long secondsToFilter = long.Parse(Console.ReadLine());
            long filterProcent = long.Parse(Console.ReadLine());
            long secondsToUpload = long.Parse(Console.ReadLine());
            
            long filterSecs = pictures * secondsToFilter;
            long filteredPics = (long)Math.Ceiling(filterProcent * pictures / 100.0);
            long uploadSecs = (filteredPics * secondsToUpload);
            long totalSecs = filterSecs + uploadSecs;

            TimeSpan vremeto = TimeSpan.FromSeconds(totalSecs);
            string pechatai = vremeto.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(pechatai);
        }
    }
}
