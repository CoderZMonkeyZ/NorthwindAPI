using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coderzAdapter;
using coderzModel.Category;

namespace coderzAdapter.Category
{
    public class CategoriesAdapter : BaseAdapter
    {
        private CategoriesModel categoryModelResults = new CategoriesModel();

        public CategoriesModel GetCategory(string categoryName)
        {
            htParams["@CategoryName"] = categoryName;
            
            try
            {
                DataSet ds                          = results.GetSPDataSet("dbo.usp_GetCategoryByName", htParams);
                categoryModelResults.CategoryID     = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                categoryModelResults.CategoryName   = ds.Tables[0].Rows[0][1].ToString();
                categoryModelResults.Description    = ds.Tables[0].Rows[0][2].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoryModelResults;
        }
    }
}