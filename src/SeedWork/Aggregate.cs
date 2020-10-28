using System;
using System.Collections.Generic;

namespace SeedWork
{
    public abstract class Aggregate
    {
        public Guid Id { get; private set; }
        private List<SeedWork.IEvent> _unCommittedEvents;
        public Aggregate()
        {
            Id = Guid.NewGuid();
            _unCommittedEvents = new List<IEvent>();
        }

        public void ApplyEvent(IEvent @event)
        {
            _unCommittedEvents.Add(@event);
        }
    }
}