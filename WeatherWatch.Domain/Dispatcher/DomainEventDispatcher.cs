using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WeatherWatch.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace WeatherWatch.Domain.Dispatcher
{
    public class DomainEventDispatcher : IDomainEventDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public DomainEventDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Dispatch<TEvent>(TEvent domainEvent) where TEvent : IDomainEvent
        {
            var handlers = _serviceProvider.GetServices<IHandle<TEvent>>();

            foreach (IHandle<TEvent> handle in handlers)
            {
                handle.Handle(domainEvent);
            }
        }
    }
}
