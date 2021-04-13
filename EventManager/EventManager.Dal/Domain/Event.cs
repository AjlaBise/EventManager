using EventManager.Dal.Helper;
using System;

namespace EventManager.Dal.Domain
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int? Repetition { get; set; }

        public TimePeriod TimePeriod { get; set; }

    }
}