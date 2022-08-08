using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_Models.Models;
using DATA_Models.DTO;

namespace DAL
{
    public interface ILogin
    {
        MasterUserDTO PSSLogin(LoginModel oLogin);
        //Task<bool> PSSLogout(MasterUserDTO data);
    }
}
