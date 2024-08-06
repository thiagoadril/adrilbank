namespace AdrilBank.Domain.Base.Events
{
    public class StoredEvent : Event
    {
        public Guid Id { get; private set; }
        public string Data { get; private set; }
        public string User { get; private set; }

        public StoredEvent(Event theEvent, string data, string user)
        {
            Id = Guid.NewGuid();
            AggregateId = theEvent.AggregateId;
            Action = theEvent.Action;
            Data = data;
            User = user;
        }

        // EF Constructor
        protected StoredEvent() { }
    }
}
