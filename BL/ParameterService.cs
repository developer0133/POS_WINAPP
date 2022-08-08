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
    public class ParameterService
    {
        static IParameter _parameter;

        static ParameterService()
        {
            _parameter = new Parameter();
        }

        public static List<PARAMETER> GetParameter(string code)
        {
            return _parameter.GetParameter(code);
        }
        public static List<PARAMETER> GetParameterAll()
        {
            return _parameter.GetParameterAll();
        }

        public static bool InsertParameter(PARAMETER pData)
        {
            return _parameter.InsertParameter(pData);
        }

        public static bool UpdateParameter(PARAMETER pData)
        {
            return _parameter.UpdateParameter(pData);
        }

        public static bool DeleteParameter(int parameter_id)
        {
            return _parameter.DeleteParameter(parameter_id);
        }

    }
}
