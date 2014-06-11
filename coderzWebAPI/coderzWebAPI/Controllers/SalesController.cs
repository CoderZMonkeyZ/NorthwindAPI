using coderzModel.Models.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace coderzWebAPI.Controllers
{
    public class SalesController : ApiController
    {
        [HttpGet]
        public SalesModelList GetSalesByTheYear(DateTime beginningDate, DateTime endingDate)
        {
            return new coderzAdapter.Sale.SaleAdapter().GetSalesByYear(beginningDate, endingDate);
        }

        [HttpGet]
        public SalesModelList GetSalesByCategory(string categoryName, string orderYear)
        {
            return new coderzAdapter.Sale.SaleAdapter().GetSalesByCategory(categoryName, orderYear);
        }
    }
}
