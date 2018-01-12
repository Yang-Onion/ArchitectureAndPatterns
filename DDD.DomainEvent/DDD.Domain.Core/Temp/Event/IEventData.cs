using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Event
{
    public interface IEventData
    {
         DateTime Timestamp { get; set; }

        object EventSource { get; set; }
    }
}
