namespace AdrilBank.Domain.Base.Events
{
    public interface IEventStore
    {
        void Save<T>(T current) where T : Event;
    }
}
