using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Repository.Memory
{
    public class DatabaseCustomer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Telephone { get; set; }
    }
}
