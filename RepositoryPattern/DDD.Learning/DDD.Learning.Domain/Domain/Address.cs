using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain
{
    public class Address : ValueObjectBase
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string District { get; set; }
        public string Town { get; set; }
        public string PostalCode { get; set; }
        public override void Validate()
        {
            if (string.IsNullOrEmpty(City))
            {
                AddBrokenRule(AddressBusinessRule.CityInAddressRequired);
            }
        }
    }
}
