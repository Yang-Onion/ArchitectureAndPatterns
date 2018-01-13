using DDD.Domain.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Validations
{
    public abstract class TransitBillValidation<T> : AbstractValidator<T> where T:TransitBillCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("name can not be empty")
                .Length(1, 20).WithMessage("The Name must have between 2 and 150 characters");
        }

        protected void ValidateTaxFee()
        {
            RuleFor(c => c.TaxFee)
                .GreaterThan(0).WithMessage("TaxFee must greater than 0");
        }

        protected void ValidateGrossProfit()
        {
            RuleFor(c => c.GrossProfit)
                  .GreaterThan(0).WithMessage("GrossProfit must greater than 0");

        }
        protected void ValidateDistanceFee()
        {
            RuleFor(c => c.DistanceFee)
               .GreaterThan(0).WithMessage("DistanceFee must greater than 0");
        }
    }
}
