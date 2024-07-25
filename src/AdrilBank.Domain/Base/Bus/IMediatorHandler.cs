using AdrilBank.Domain.Base.Commands;
using AdrilBank.Domain.Base.Events;

namespace AdrilBank.Domain.Base.Bus
{
    public interface IMediatorHandler
    {
        Task Send<T>(T Command) where T : Command;
        Task Raise<T>(T @event) where T : Event;
    }
}
