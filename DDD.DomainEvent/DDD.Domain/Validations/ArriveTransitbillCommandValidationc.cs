using DDD.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Validations
{
    public class ArriveTransitbillCommandValidationc:TransitBillValidation<ArriveTransitBillCommand>
    {
        public ArriveTransitbillCommandValidationc()
        {
            ValidateName();
            ValidateTaxFee();
            ValidateGrossProfit();
            ValidateDistanceFee();
        }
    }
}
