using DDD.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Models
{
    public class TransitBill:Entity
    {
        public TransitBill(Guid id,string name,decimal taxFee,decimal distanceFee,decimal grossProfit)
        {
            Id = id;
            Name = name;
            TaxFee = taxFee;
            DistanceFee = distanceFee;
            GrossProfit = grossProfit;
        }

        public string Name { get; private set; }
        /// <summary>
        ///  税费
        /// </summary>
        public decimal TaxFee { get; private set; }
        /// <summary>
        ///  长途运费
        /// </summary>
        public decimal DistanceFee { get; private set; }

        /// <summary>
        /// 毛利
        /// </summary>
        public decimal GrossProfit { get; private set; }

    }

   
}
