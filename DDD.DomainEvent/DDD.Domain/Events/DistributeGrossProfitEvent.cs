using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Events
{
    public class DistributeGrossProfitEvent : Core.Events.Event
    {
        public DistributeGrossProfitEvent(Guid id, string name,  decimal grossProfit)
        {
            Id = id;
            Name = name;

            GrossProfit = grossProfit;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// 毛利
        /// </summary>
        public decimal GrossProfit { get; set; }
    }
}
