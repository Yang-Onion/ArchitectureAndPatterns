using DDD.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Commands
{
    public class ArriveTransitBillCommand : TransitBillCommand
    {
        public ArriveTransitBillCommand(string name , decimal taxfee, decimal grossprofit,decimal distancefee)
        {
            Name = name;
            TaxFee = taxfee;
            GrossProfit = grossprofit;
            DistanceFee = distancefee;

        }
        public override bool IsValid()
        {
            ValidationResult = new ArriveTransitbillCommandValidationc().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
