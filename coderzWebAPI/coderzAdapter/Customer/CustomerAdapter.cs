using coderzModel.Models.Customer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace coderzAdapter.Customer
{
    public class CustomerAdapter : BaseAdapter
    {
        private CustomerModel customerModelResults = new CustomerModel();
        public CustomerModel GetCustomerByID(string customerID)
        {
            htParams["@CustomerID"] = customerID;

            try
            {
                DataSet ds = results.GetSPDataSet("dbo.usp_GetCustomerByID", htParams);
                customerModelResults.CompanyName = ds.Tables[0].Rows[0][0].ToString();
                customerModelResults.ContactName = ds.Tables[0].Rows[0][1].ToString();
                customerModelResults.ContactTitle = ds.Tables[0].Rows[0][2].ToString();
                customerModelResults.Address = ds.Tables[0].Rows[0][3].ToString();
                customerModelResults.City = ds.Tables[0].Rows[0][4].ToString();
                customerModelResults.Region = ds.Tables[0].Rows[0][5].ToString();
                customerModelResults.PostalCode = ds.Tables[0].Rows[0][6].ToString();
                customerModelResults.Country = ds.Tables[0].Rows[0][7].ToString();
                customerModelResults.Phone = ds.Tables[0].Rows[0][8].ToString();
                customerModelResults.Fax = ds.Tables[0].Rows[0][9].ToString();
            }
            catch (Exception)
            {
                
                throw;
            }

            return customerModelResults;
        }
    }
}
