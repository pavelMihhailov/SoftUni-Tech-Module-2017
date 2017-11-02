using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.RoliTheCoder
{
    class Event
    {
        public string ID { get; set; }
        public string EventName { get; set; }
        public List<string> Participants { get; set; }
    }

    class StartUp
    {
        static void Main()
        {
            List<Event> events = new List<Event>();

            while (true)
            {
                string mainInput = Console.ReadLine();
                if (mainInput == "Time for Code") break;

                string[] input = mainInput.Split(" \t\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string ID = input[0];
                string eventName = input[1];
                string patternParticipants = @"@[\w|\-|\']+";

                if (eventName.StartsWith("#"))
                {
                    eventName = eventName.TrimStart('#');
                    Event newEvent = new Event { Participants = new List<string>() };

                    bool hasCurrID = false;
                    bool hasSameEventName = false;
                    for (int i = 0; i < events.Count; i++)
                    {
                        if (events[i].ID == ID) hasCurrID = true;
                        if (events[i].EventName == eventName) hasSameEventName = true;
                    }
                    if (!hasCurrID)
                    {
                        newEvent.ID = ID;
                        newEvent.EventName = eventName;
                        AddParticipants(input, patternParticipants, newEvent);
                        events.Add(newEvent);
                    }
                    else if (hasCurrID && hasSameEventName)
                    {
                        for (int i = 0; i < events.Count; i++)
                        {
                            if (events[i].ID == ID) AddParticipants(events, input, patternParticipants, i);
                        }
                    }
                }
            }
            PrintResult(events);
        }

        private static void PrintResult(List<Event> events)
        {
            foreach (var eventt in events.OrderByDescending(e => e.Participants.Count).ThenBy(e => e.EventName))
            {
                Console.WriteLine($"{eventt.EventName} - {eventt.Participants.Count}");
                if (eventt.Participants.Count > 0)
                {
                    Console.WriteLine(string.Join("\n", eventt.Participants.OrderBy(e => e)));
                }
            }
        }

        private static void AddParticipants(List<Event> events, string[] input, string patternParticipants, int i)
        {
            for (int j = 2; j < input.Length; j++)
            {
                Match checkParticipantMatch = Regex.Match(input[j], patternParticipants);
                if (checkParticipantMatch.Success)
                {
                    bool hasThisParticipant = events[i].Participants.Contains(input[j]);
                    if (!hasThisParticipant) events[i].Participants.Add(input[j]);
                }
            }
        }

        private static void AddParticipants(string[] input, string patternParticipants, Event newEvent)
        {
            for (int i = 2; i < input.Length; i++)
            {
                Match checkParticipantMatch = Regex.Match(input[i], patternParticipants);
                if (checkParticipantMatch.Success)
                {
                    bool hasThisParticipant = newEvent.Participants.Contains(input[i]);
                    if (!hasThisParticipant) newEvent.Participants.Add(input[i]);
                }
            }
        }
    }
}
