using System;
using System.Collections.Generic;

namespace employees
{
    static class Events
    {
        static List<Event> events = new List<Event>();

        public static void AddEvent(Event e)
        {
            events.Add(e);
        }
    }
}