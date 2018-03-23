using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWatch.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        void Dispatch<TEvent>(TEvent domainEvent) where TEvent : IDomainEvent;
    }
}
