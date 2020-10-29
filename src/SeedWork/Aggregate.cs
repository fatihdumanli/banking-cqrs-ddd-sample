using NServiceBus;
using System;
using System.Collections.Generic;

namespace SeedWork
{
    public abstract class Aggregate
    {
        public Guid Id { get; protected set; }
        private List<SeedWork.IEvent> _unCommittedEvents;
        public IReadOnlyCollection<SeedWork.IEvent> UncomittedEvents => _unCommittedEvents.AsReadOnly();

        public Aggregate()
        {
            Id = Guid.NewGuid();
            _unCommittedEvents = new List<IEvent>();
        }

        protected void ApplyEvent(IEvent @event)
        {
            _unCommittedEvents.Add(@event);
        }
    }
}