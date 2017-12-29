using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain
{
    public static class AddressBusinessRule
    {
        public static readonly BusinessRule CityInAddressRequired = new BusinessRule(" And address must have a city ");
    }
}
