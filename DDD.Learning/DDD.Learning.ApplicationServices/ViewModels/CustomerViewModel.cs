using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.ApplicationServices
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string District { get; set; }
        public string Town { get; set; }
        public string PostalCode { get; set; }
    }
}
