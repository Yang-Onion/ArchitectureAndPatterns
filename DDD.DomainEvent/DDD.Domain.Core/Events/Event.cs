using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Core.Events
{
    public abstract class Event:Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
