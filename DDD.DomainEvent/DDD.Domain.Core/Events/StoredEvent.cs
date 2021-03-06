﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Core.Events
{
    public class StoredEvent:Event
    {
        public StoredEvent(Event @event,string data,string user)
        {
            Id = Guid.NewGuid();
            AggregateId = @event.AggregateId;
            MessageType = @event.MessageType;
            Data = data;
            User = user;
        }

        public Guid Id { get; private set; }
        public string Data { get; private set; }
        public string User { get; private set; }
    }
}
