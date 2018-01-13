using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Events
{
    public class TransitBillArriveEvent: Core.Events.Event
    {
        public TransitBillArriveEvent(Guid id, string name, decimal taxFee, decimal distanceFee, decimal grossProfit)
        {
            Id = id;
            Name = name;
            TaxFee = taxFee;
            DistanceFee = distanceFee;
            GrossProfit = grossProfit;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        ///  税费
        /// </summary>
        public decimal TaxFee { get; set; }
        /// <summary>
        ///  长途运费
        /// </summary>
        public decimal DistanceFee { get; set; }

        /// <summary>
        /// 毛利
        /// </summary>
        public decimal GrossProfit { get; set; }
    }
}
