using EventManager.Dal.Domain;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Dal.ViewModel
{
    public class EventViewModel
    {
        public EventDto Event { get; }

        public IReadOnlyCollection<EventDto> Collection { get; }

        public EventViewModel(Event e)
        {
            Event = new EventDto(e);
        }

        public EventViewModel(IReadOnlyCollection<Event> events)
        {
            Collection = events.Select(e => new EventDto(e)).ToList();
        }
    }
}