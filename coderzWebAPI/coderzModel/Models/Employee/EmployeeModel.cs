using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderzModel.Models.Employee
{
    public class EmployeeModel
    {
        public string Country { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime ShippedDate { get; set; }
        public int OrderID { get; set; }
        public decimal SaleAmount { get; set; }
    }
}
