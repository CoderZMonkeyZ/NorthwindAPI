using coderzModel.Models.Product;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderzAdapter.Product
{
    public class ProductAdapter : BaseAdapter
    {
        private ProductModel productModelResults = new ProductModel();
        private List<ProductModel> productModelResultsLists = new List<ProductModel>();

        public List<ProductModel> GetCustomerOrderHistryByID(string customerID)
        {
            htParams["@CustomerID"] = customerID;

            try
            {
                DataSet ds = results.GetSPDataSet("dbo.CustOrderHist", htParams);
                productModelResultsLists = base.MappingProductData(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productModelResultsLists;
        }

        public List<ProductModel> GetTopTenExpensiveProducts()
        {
            List<ProductModel> productModelList = new List<ProductModel>();

            try
            {
                DataSet ds = results.GetSPDataSet("[dbo].[Ten Most Expensive Products]", null);
                productModelList = base.MappingProductTopTenData(ds);
            }
            catch (Exception)
            {
                
                throw;
            }

            return productModelList;
        }
    }
}
