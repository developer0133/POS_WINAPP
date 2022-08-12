using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_EF;
using DAL.Utils;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

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
                var checkname = _db.PARAMETER.Where(w => w.NAME.ToLower() == pData.NAME.ToLower() && w.STATUS == STATUS.ACTIVE).FirstOrDefault();
                if (checkname != null)
                {
                    throw new Exception("Data exist");
                }

                pData.C_DATE = clsFunction.GetDate();
                pData.STATUS = STATUS.ACTIVE;
                _db.PARAMETER.Add(pData);

                _db.SaveChanges();
                isSuccess = true;
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
    }
}
