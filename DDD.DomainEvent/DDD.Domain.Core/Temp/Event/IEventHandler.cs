using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Event
{
    public interface IEventHandler
    {
    }

    public interface IEventHandler<TEventData> :IEventHandler where TEventData : IEventData
    {
        void HandleEvent(TEventData eventData);
    }
}
