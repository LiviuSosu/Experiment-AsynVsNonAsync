using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailAddress { get; set; }
    }
}
