using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderzAdapter.Employee
{
    public class EmployeeAdapter : BaseAdapter
    {
        public coderzModel.Models.Employee.EmployeeModelList GetEmployeeListSalesCountry(DateTime beginningDate, DateTime endingDate)
        {
            htParams["@Beginning_Date"] = beginningDate;
            htParams["@Ending_Date"] = endingDate;

            coderzModel.Models.Employee.EmployeeModelList employeeModelList = new coderzModel.Models.Employee.EmployeeModelList();
            try
            {
                DataSet ds = results.GetSPDataSet("[dbo].[Employee Sales by Country]", htParams);
                employeeModelList = base.MappingEmployeeSalesCountry(ds);
            }
            catch (Exception)
            {
                throw;
            }

            return employeeModelList;
        }
    }
}
