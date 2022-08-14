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
        public List<CATEGORY> GetCategories()
        {
            List<CATEGORY> cateList = new List<CATEGORY>();

            using (POSSYSTEMEntities db = new POSSYSTEMEntities())
            {
                cateList = db.CATEGORY.Where(w => w.STATUS == STATUS.ACTIVE).ToList();
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
