using coderzModel.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace coderzWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public EmployeeModelList GetEmployeeSalesByCountry(DateTime beginningDate, DateTime endingDate)
        {
            return new coderzAdapter.Employee.EmployeeAdapter().GetEmployeeListSalesCountry(beginningDate, endingDate);
        }
    }
}
