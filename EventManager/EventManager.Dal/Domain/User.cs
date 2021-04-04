using System.Collections.Generic;

namespace EventManager.Dal.Domain
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Event> Events { get; set; }
    }
}