using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Event
{
    public class EventData : IEventData
    {
        public DateTime Timestamp { get ; set; }
        public object EventSource { get; set ; }
        public EventData()
        {
            Timestamp = DateTime.Now;
        }
    }
}
