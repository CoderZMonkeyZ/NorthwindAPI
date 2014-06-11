using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using coderzModel.Category;


namespace coderzWebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        [HttpGet]
        public CategoriesModel GetCategory(string categoryName)
        {
            CategoriesModel results = new coderzAdapter.Category.CategoriesAdapter().GetCategory(categoryName);
            return results;
        }
    }
}
