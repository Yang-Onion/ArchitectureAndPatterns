using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain
{
    public class Customer : EntityBase<int>,IAggregateRoot
    {
        public string Name { get; set; }
        public Address CustomerAddress { get; set; }
        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                AddBrokenRules(CustomerBusinessRule.CustomerNameRequired);
            }
            CustomerAddress.ThrowExceptionIfIsvalid();
        }
    }
}
