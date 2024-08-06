using AdrilBank.Domain.Base.Commands;
using AdrilBank.Domain.Base.Events;

namespace AdrilBank.Domain.Base.Bus
{
    public interface IMediatorHandler
    {
        Task SendAsync<T>(T command) where T : Command;
        Task RaiseAsync<T>(T @event) where T : Event;
    }
}
