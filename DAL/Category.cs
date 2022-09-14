using DATA_EF;
using DAL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DATA_Models.Models;
using DATA_Models.DTO;
using System.Data.Entity;

namespace DAL
{
    public class Category : ICategory
    {
        public List<CategoryModel> GetCategories()
        {
            List<CategoryModel> cateList = new List<CategoryModel>();

            using (POSSYSTEMEntities db = new POSSYSTEMEntities())
            {
                var qry = (from t in db.CATEGORY
                           where t.STATUS == STATUS.ACTIVE
                         
                           select new CategoryModel
                           {
                               CATEGORY_ID = t.CATEGORY_ID,
                               CATEGORY_NAME = t.CATEGORY_NAME,
                               CATE_CODE = t.CATE_CODE,
                               REMARK = t.REMARK,
                               STATUS = t.STATUS
                           }).AsQueryable();

                cateList = (List<CategoryModel>)qry.AsEnumerable().Select(s => new CategoryModel
                {
                    CATEGORY_ID = s.CATEGORY_ID,
                    CATEGORY_NAME = s.CATEGORY_NAME,
                    CATE_CODE = s.CATE_CODE,
                    REMARK = s.REMARK,
                    STATUS = s.STATUS
                }).ToList();
            }

            return cateList;
        }

        public List<CategoryModel> CategoriesSearch(string OSearch)
        {
            List<CategoryModel> cateList = new List<CategoryModel>();

            using (POSSYSTEMEntities db = new POSSYSTEMEntities())
            {
                var qry = (from t in db.CATEGORY
                           where t.STATUS == STATUS.ACTIVE &&
                           (t.CATEGORY_NAME.Trim().Contains(OSearch.Trim()) || t.CATEGORY_ID.ToString() == OSearch.ToString() || string.IsNullOrEmpty(OSearch))
                           select new CategoryModel
                           {
                               CATEGORY_ID = t.CATEGORY_ID,
                               CATEGORY_NAME = t.CATEGORY_NAME,
                               CATE_CODE = t.CATE_CODE,
                               REMARK = t.REMARK,
                               STATUS = t.STATUS

                           }).AsQueryable();

                cateList = (List<CategoryModel>)qry.AsEnumerable().Select(s => new CategoryModel
                {
                    CATEGORY_ID = s.CATEGORY_ID,
                    CATEGORY_NAME = s.CATEGORY_NAME,
                    CATE_CODE = s.CATE_CODE,
                    REMARK = s.REMARK,
                    STATUS = s.STATUS
                }).ToList();

                
                db.Dispose();
            }

            return cateList;
        }

        public CATEGORY GetCategoryByID(int id)
        {
            CATEGORY obj = new CATEGORY();

            using (POSSYSTEMEntities db = new POSSYSTEMEntities())
            {
                obj = db.CATEGORY.Where(w => w.CATEGORY_ID == id).SingleOrDefault();
            }

            return obj;
        }

        public  bool InsertCategory(CATEGORY category)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();

            bool isSuccess = false;
            
            try
            {
                var checkname = _db.CATEGORY.Where(w => w.CATEGORY_NAME.ToLower() == category.CATEGORY_NAME.ToLower() && w.STATUS == STATUS.ACTIVE).FirstOrDefault();
                if (checkname != null)
                {
                    throw new Exception("Data exist");
                }

                category.STATUS = STATUS.ACTIVE;
                _db.CATEGORY.Add(category);
                _db.SaveChanges();

                isSuccess = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return isSuccess;
        }

        public bool UpdateCategory(CATEGORY category)
        {
            bool isSuccess = false;

            try
            {
                using (POSSYSTEMEntities db = new POSSYSTEMEntities())
                {
                    db.Entry(category).State = EntityState.Modified;
                    isSuccess = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return isSuccess;
        }

        public bool DeleteCategory(int categorY_ID)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();

            bool isSuccess = false;
            var obj =  _db.CATEGORY.Find(categorY_ID);

            try
            {
                if (obj != null)
                {
                    obj.STATUS = STATUS.INACTIVE;
                    _db.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }

            return isSuccess;
        }
    }
}
