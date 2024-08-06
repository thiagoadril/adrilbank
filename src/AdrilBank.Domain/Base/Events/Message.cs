using MediatR;

namespace AdrilBank.Domain.Base.Events
{
    public abstract class Message: IRequest<bool>
    {
        public string Action { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message() => Action = GetType().Name;
    }
}
