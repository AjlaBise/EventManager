using System;

namespace EventManager.Dal.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        //I set this as a string because I think the best way to implement this is by using authentication.
        //I did not implement that because the task doesn't require it.
        public string ModifiedByUser { get; set; }

        public int CreatedById { get; set; }

        public User CreatedByUser { get; set; }

        public DateTime StartDate { get; set; } 

        public DateTime StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime EndTime { get; set;}
    }
}