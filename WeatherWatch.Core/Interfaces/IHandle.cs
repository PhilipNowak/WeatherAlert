using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWatch.Core.Interfaces
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T domianEvent);
    }
}
