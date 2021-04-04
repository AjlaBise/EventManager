using System;

namespace EventManager.Dal.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        //public DateTime ModifiedAt { get; set; }
        //public int ModifiedById { get; set; }
        //public User ModifiedByUser { get; set; }

        public int CreatedById { get; set; }
        public User CreatedByUser { get; set; }

        //public BaseEntity(int createdById)
        //{
        //    CreatedById = createdById;
        //    CreatedAt = DateTime.Now;
        //}
    }
}