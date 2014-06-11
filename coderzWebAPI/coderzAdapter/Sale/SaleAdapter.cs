using coderzModel.Models.Sale;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace coderzAdapter.Sale
{
    public class SaleAdapter : BaseAdapter
    {
        public SalesModelList GetSalesByYear(DateTime beginningDate, DateTime endingDate)
        {
            SalesModelList salesResults = new SalesModelList(); 
            htParams["@Beginning_Date"] = beginningDate;
            htParams["@Ending_Date"] = endingDate;

            try
            {
                DataSet ds = results.GetSPDataSet("[dbo].[Sales by Year]", htParams);
                salesResults = MappingSalesByYear(ds);
            }
            catch (Exception)
            {
                throw;
            }

            return salesResults;
        }

        public SalesModelList GetSalesByCategory(string categoryName, string orderYear)
        {
            SalesModelList salesResults = new SalesModelList();
            htParams["@CategoryName"] = categoryName;
            htParams["@OrdYear"] = orderYear;

            try
            {
                DataSet ds = results.GetSPDataSet("[dbo].[SalesByCategory]", htParams);

            }
            catch (Exception)
            {
                
                throw;
            }

            return salesResults;
        }
    }
}
