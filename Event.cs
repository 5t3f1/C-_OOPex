using System;

namespace employees
{
    public class Event
    {
        string name;
        string start;
        string end;

        Event(string eventName, string eventStart, string eventEnd)
        {
            name = eventName;
            start = eventStart;
            end = eventEnd;
        }

        public void PrintEvent()
        {
            Console.WriteLine("Event '{0}': started - {1}; ended - {1}",
            name, start, end);
        }
    }
}