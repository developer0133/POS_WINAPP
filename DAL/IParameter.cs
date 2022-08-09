using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_EF;

namespace DAL
{
    public interface IParameter
    {
        List<PARAMETER> GetParameter(string code);
        List<PARAMETER> GetParameterAll();
        bool InsertParameter(PARAMETER pData);
        bool UpdateParameter(PARAMETER pData);
        bool DeleteParameter(int parameter_id);//delete
    }
}
