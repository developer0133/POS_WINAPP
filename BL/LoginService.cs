using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DATA_Models.Models;
using DATA_Models.DTO;

namespace BL
{
    public static class LoginService
    {
        static ILogin _login;

        static LoginService()
        {
            _login = new Login();
        }

        public static MasterUserDTO PSSLogin(LoginModel oLogin)
        {
            return _login.PSSLogin(oLogin);//test
        }
    }
}
