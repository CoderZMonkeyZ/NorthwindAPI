using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderzModel.Models.Employee
{
    public class EmployeeModelList
    {
        public int EmployeeCount { get; set; }
        public List<EmployeeModel> Employees { get; set; }
    }
}
