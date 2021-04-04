using EventManager.Dal.Domain;

namespace EventManager.Dal.ViewModel
{
    public class EventDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public EventDto()
        {
        }

        public EventDto(Event e)
        {
            Id = e.Id;
            Name = e.Name;
            Description = e.Description;
        }
    }
}