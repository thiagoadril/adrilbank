using AdrilBank.Domain.Base.Bus;
using AdrilBank.Domain.Base.Commands;
using AdrilBank.Domain.Base.Events;
using MediatR;

namespace AdrilBank.Infra.CrossCutting.Bus
{
    public sealed class InMemoryBus(IMediator mediator, IEventStore eventStore) : IMediatorHandler
    {
        private readonly IMediator _mediator = mediator;
        private readonly IEventStore _eventStore = eventStore;

        public async Task SendAsync<T>(T command) where T : Command
            => await _mediator.Send(command);

        public Task RaiseAsync<T>(T @event) where T : Event
        {
            if (!@event.Action.Equals("DomainNotification"))
                _eventStore?.Save(@event);

            return _mediator.Publish(@event);
        }
    }
}
