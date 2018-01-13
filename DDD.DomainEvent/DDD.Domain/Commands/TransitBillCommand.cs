using DDD.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Commands
{
    public abstract class TransitBillCommand : Command
    {
        public string Name { get; protected set; }
        /// <summary>
        ///  税费
        /// </summary>
        public decimal TaxFee { get; protected set; }
        /// <summary>
        ///  长途运费
        /// </summary>
        public decimal DistanceFee { get; protected set; }

        /// <summary>
        /// 毛利
        /// </summary>
        public decimal GrossProfit { get; protected set; }
    }
}
