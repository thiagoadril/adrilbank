using FluentValidation.Results;

namespace AdrilBank.Domain.Base.Commands
{
    public abstract class Command
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
