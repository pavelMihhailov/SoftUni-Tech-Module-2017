using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke
{
    class Participant
    {
        public string Name { get; set; }
        public List<string> AwardsList { get; set; }
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToList();
            List<string> availableSongs = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();

            List<Participant> listOfParticipants = new List<Participant>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim()).ToArray();
                if (input[0] == "dawn") break;

                string currParticipant = input[0].Trim();
                string wantedSong = input[1];
                string award = input[2];
                AddAwards(participants, availableSongs, listOfParticipants, currParticipant, wantedSong, award);
            }
            PrintResult(listOfParticipants);
        }

        private static void AddAwards(List<string> participants, List<string> availableSongs, List<Participant> listOfParticipants, string currParticipant, string wantedSong, string award)
        {
            bool sang = false;
            for (int i = 0; i < listOfParticipants.Count; i++)
            {
                if (listOfParticipants[i].Name == currParticipant) sang = true;
            }
            if (participants.Contains(currParticipant) && availableSongs.Contains(wantedSong))
            {
                if (!sang)
                {
                    Participant newParticipant = new Participant();
                    newParticipant.Name = currParticipant;
                    newParticipant.AwardsList = new List<string>();
                    newParticipant.AwardsList.Add(award);
                    listOfParticipants.Add(newParticipant);
                }
                else
                {
                    for (int i = 0; i < listOfParticipants.Count; i++)
                    {
                        if (listOfParticipants[i].Name == currParticipant &&
                            !listOfParticipants[i].AwardsList.Contains(award))
                        {
                            listOfParticipants[i].AwardsList.Add(award);
                        }
                    }
                }
            }
        }

        private static void PrintResult(List<Participant> listOfParticipants)
        {
            if (listOfParticipants.Count > 0)
            {
                foreach (var participant in listOfParticipants.OrderByDescending(p => p.AwardsList.Count).ThenBy(p => p.Name))
                {
                    Console.WriteLine($"{participant.Name}: {participant.AwardsList.Count} awards");
                    foreach (var award in participant.AwardsList.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
