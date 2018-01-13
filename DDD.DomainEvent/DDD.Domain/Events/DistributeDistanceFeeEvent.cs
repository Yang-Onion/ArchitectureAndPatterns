using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Events
{
    public class DistributeDistanceFeeEvent : Core.Events.Event
    {
        public DistributeDistanceFeeEvent(Guid id, string name, decimal distanceFee)
        {
            Id = id;
            Name = name;
            DistanceFee = distanceFee;
                    }
        public Guid Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        ///  长途运费
        /// </summary>
        public decimal DistanceFee { get; set; }
    }
}
