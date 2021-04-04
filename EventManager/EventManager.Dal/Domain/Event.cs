namespace EventManager.Dal.Domain
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}