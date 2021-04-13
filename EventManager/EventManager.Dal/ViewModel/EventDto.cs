using EventManager.Dal.Domain;
using EventManager.Dal.Helper;
using System;

namespace EventManager.Dal.ViewModel
{
    public class EventDto
    {
        

        public string Name { get; set; }

        public string Description { get; set; }

        public int CreateById { get; set; }

        public string ModifiedByUser { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public int? Repetition { get; set; }

        public TimePeriod TimePeriod { get; set; }


        public EventDto()
        {
        }

        public EventDto(Event e)
        {
            Name = e.Name;
            Description = e.Description;
            CreateById = e.CreatedById;
            StartDate = e.StartDate;
            EndDate = e.EndDate;
            ModifiedAt = e.ModifiedAt;
            CreatedAt = e.CreatedAt;
            ModifiedByUser = e.ModifiedByUser;
            Repetition = e.Repetition;
            TimePeriod = e.TimePeriod;
        }
    }
}