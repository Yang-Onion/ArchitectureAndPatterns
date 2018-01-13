using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Events
{
    public class DistributeTaxFeeEvent : Core.Events.Event
    {
        public DistributeTaxFeeEvent(Guid id, string name, decimal taxFee)
        {
            Id = id;
            Name = name;
            TaxFee = taxFee;

        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        ///  税费
        /// </summary>
        public decimal TaxFee { get; set; }
    }
}
