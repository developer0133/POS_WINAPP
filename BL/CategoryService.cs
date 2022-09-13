using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DATA_Models.Models;
using DATA_Models.DTO;
using DATA_EF;

namespace BL
{
    public class CategoryService
    {
        static ICategory _category;

        static CategoryService()
        {
            _category = new Category();
        }

        public static List<CategoryModel> GetCategories()
        {
            return _category.GetCategories();
        }

        public static List<CategoryModel> CategoriesSearch(string OSearch)
        {
            return _category.CategoriesSearch(OSearch);
        }

        public static CATEGORY GetCategoryByID(int id)
        {
            return _category.GetCategoryByID(id);
        }

        public static bool InsertCategory(CATEGORY category)
        {
            return _category.InsertCategory(category);
        }

        public static bool UpdateCategory(CATEGORY category)
        {
            return _category.UpdateCategory(category);
        }
        public static bool DeleteCategory(int categorY_ID)
        {
            return _category.DeleteCategory(categorY_ID);
        }
    }
}
