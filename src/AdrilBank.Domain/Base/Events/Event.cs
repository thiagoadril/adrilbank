
using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdrilBank.Domain.Base.Events
{
    public abstract class Event : Message, INotification
    {
        public DateTime CreatedAt { get; private set; }

        protected Event()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
