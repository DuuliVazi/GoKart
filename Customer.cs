using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailID { get; set; }
        public long[] CustomerContact { get; set; }
        public Customer(string customerId, string customerName)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
        }
        public void AddContactDetails(string emailId, params long[] customerContact)
        {
            this.EmailID = emailId;
            this.CustomerContact = customerContact;
        }
    }

}
