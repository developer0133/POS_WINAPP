using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_EF;

using ParameterModel = DATA_Models.Models.ParameterModel;

namespace DAL
{
    public interface IParameter
    {
        List<PARAMETER> GetParameter(string code);
        List<PARAMETER> GetParameter(string code, string text);
        PARAMETER GetParameterByID(int id);
        List<PARAMETER> GetParameterAll();
        List<ParameterModel> ParameterSearch(string OSearch);
        bool InsertParameter(PARAMETER pData);
        bool UpdateParameter(PARAMETER pData);
        bool DeleteParameter(int parameter_id);//delete
    }
}
