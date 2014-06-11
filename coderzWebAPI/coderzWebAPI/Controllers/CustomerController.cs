using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using coderzModel.Models.Customer;

namespace coderzWebAPI.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpGet]
        public CustomerModel GetCustomerByID(string customerID)
        {
            CustomerModel customer = new coderzAdapter.Customer.CustomerAdapter().GetCustomerByID(customerID);
            return customer;
        }
    }
}
