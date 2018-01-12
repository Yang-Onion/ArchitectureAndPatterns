using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Core.Events
{
    public class Message:INotification
    {
        public Guid AggregateId { get; protected set; }
        public String MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
