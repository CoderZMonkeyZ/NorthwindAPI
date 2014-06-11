using coderzAdapter.Product;
using coderzModel.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace coderzWebAPI.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<ProductModel> GetCustomerOrderHistory(string customerID)
        {
            List<ProductModel> productResults = new ProductAdapter().GetCustomerOrderHistryByID(customerID);

            return productResults;
        }

        [HttpGet]
        public List<ProductModel> GetTenMostExpensiveProducts()
        {
            return new ProductAdapter().GetTopTenExpensiveProducts();
        }
    }
}
