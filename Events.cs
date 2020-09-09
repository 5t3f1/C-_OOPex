using System;
using System.Collections.Generic;

namespace employees
{
    static class Events
    {
        List<Event> events = new List<Event>();

        public void AddEvent(Event e)
        {
            events.Add(e);
        }
    }
}
