using DATA_EF;
using DATA_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICategory
    {
        CATEGORY GetCategoryByID(int id);
        List<CategoryModel> GetCategories();
        List<CategoryModel> CategoriesSearch(string OSearch);
        bool InsertCategory(CATEGORY category);
        bool UpdateCategory(CATEGORY category);
        bool DeleteCategory(int categorY_ID);
    }
}
