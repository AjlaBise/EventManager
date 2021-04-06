using EventManager.Dal.Domain;
using System;

namespace EventManager.Dal.ViewModel
{
    public class EventDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CreateById { get; set; }

        public string ModifiedByUser { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }


        public EventDto()
        {
        }

        public EventDto(Event e)
        {
            Id = e.Id;
            Name = e.Name;
            Description = e.Description;
            CreateById = e.CreatedById;
            StartDate = e.StartDate;
            StartTime = e.StartTime;
            EndDate = e.EndDate;
            EndTime = e.EndTime;
            ModifiedAt = e.ModifiedAt;
            CreatedAt = e.CreatedAt;
            ModifiedByUser = e.ModifiedByUser;
        }
    }
}