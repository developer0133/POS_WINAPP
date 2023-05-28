using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_EF;
using DAL.Utils;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DATA_Models.Models;

namespace DAL
{
    public class Parameter : IParameter
    {
        POSSYSTEMEntities _db;
        public List<PARAMETER> GetParameterAll()
        {
            List<PARAMETER> listParm = new List<PARAMETER>();
            _db = new POSSYSTEMEntities();
            try
            {

                using (POSSYSTEMEntities db = new POSSYSTEMEntities())
                {
                    listParm = db.PARAMETER.Where(w => w.STATUS == STATUS.ACTIVE).ToList();
                    db.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listParm;
        }

        public List<PARAMETER> GetParameter(string code)
        {
            List<PARAMETER> listParm = new List<PARAMETER>();
            _db = new POSSYSTEMEntities();
            try
            {
                listParm = _db.PARAMETER.Where(w => w.STATUS == STATUS.ACTIVE && w.MAJOR_CODE == code).ToList();
                _db.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listParm;
        }

        public bool InsertParameter(PARAMETER pData)
        {
            bool isSuccess = false;
            try
            {
                var checkname = _db.PARAMETER.Where(w => w.NAME.ToLower() == pData.NAME.ToLower() && w.MAJOR_CODE == pData.MAJOR_CODE.ToLower() && w.STATUS == STATUS.ACTIVE).FirstOrDefault();
               
                if (checkname != null)
                {
                    //throw new Exception("Data exist");
                }
                else
                {
                    pData.C_DATE = clsFunction.GetDate();
                    pData.STATUS = STATUS.ACTIVE;
                    _db.PARAMETER.Add(pData);

                    _db.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }
        public bool UpdateParameter(PARAMETER pData)
        {
            _db = new POSSYSTEMEntities();
            bool isSuccess = false;

            pData.E_DATE = clsFunction.GetDate();
            _db.Entry(pData).State = EntityState.Modified;
            try
            {
                _db.SaveChanges();
                isSuccess = true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception(ex.Message);
            }

            return isSuccess;
        }

        public bool DeleteParameter(int parameter_id)
        {
            bool isSuccess = false;
            var obj = _db.PARAMETER.Find(parameter_id);

            obj.STATUS = STATUS.INACTIVE;

            try
            {
                _db.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return isSuccess;
        }

        public PARAMETER GetParameterByID(int id)
        {
            PARAMETER obj = new PARAMETER();
            _db = new POSSYSTEMEntities();
            try
            {
                obj = _db.PARAMETER.Where(w => w.STATUS == STATUS.ACTIVE && w.PARAMETER_ID == id).SingleOrDefault();
                _db.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return obj;
        }

        public List<ParameterModel> ParameterSearch(string OSearch)
        {
            List<ParameterModel> dataList = new List<ParameterModel>();

            using (POSSYSTEMEntities db = new POSSYSTEMEntities())
            {
                var qry = (from t in db.PARAMETER
                           where t.STATUS == STATUS.ACTIVE &&
                           (t.NAME.Trim().Contains(OSearch.Trim()) || t.MAJOR_CODE.Trim().Contains(OSearch.Trim())
                           || t.MINOR_CODE.Trim().Contains(OSearch.Trim()) || string.IsNullOrEmpty(OSearch))
                           select new ParameterModel
                           {
                               PARAMETER_ID = t.PARAMETER_ID,
                               MAJOR_CODE = t.MAJOR_CODE,
                               MINOR_CODE = t.MINOR_CODE,
                               NAME = t.NAME,
                               CONDITION1 = t.CONDITION1,
                               CONDITION2=t.CONDITION2,
                               STATUS = t.STATUS,
                               DESCRIPTION=t.DESCRIPTION
                           }).AsQueryable();

                dataList = (List<ParameterModel>)qry.AsEnumerable().Select(s => new ParameterModel
                {
                    PARAMETER_ID = s.PARAMETER_ID,
                    MAJOR_CODE = s.MAJOR_CODE,
                    MINOR_CODE = s.MINOR_CODE,
                    NAME = s.NAME,
                    CONDITION1 = s.CONDITION1,
                    CONDITION2 = s.CONDITION2,
                    STATUS = s.STATUS,
                    DESCRIPTION = s.DESCRIPTION
                }).ToList();


                db.Dispose();
            }

            return dataList;
        }
    }
}
