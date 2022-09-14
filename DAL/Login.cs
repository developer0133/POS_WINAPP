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

namespace DAL
{
    public class Login : ILogin
    {
        public MasterUserDTO PSSLogin(LoginModel oLogin)
        {
            MasterUserDTO objUser = new MasterUserDTO();
            bool isSuccess = false;
            int userid = 0;

            try
            {
                using (var db = new POSSYSTEMEntities())
                {
                    var obj = db.MASTER_USER.Where(w => w.STATUS == STATUS.ACTIVE && w.USERNAME == oLogin.UserName).SingleOrDefault();

                    if (obj != null)
                    {
                        var data = db.MASTER_USER.Find(obj.USER_ID);
                        var dbPasswordRoot = data.PASSWORD;
                        dbPasswordRoot = clsFunction.DecryptText(dbPasswordRoot);

                        if (oLogin.UserName.ToUpper() == data.USERNAME.ToUpper() && dbPasswordRoot.ToUpper() == oLogin.Password.ToUpper())
                        {
                            isSuccess = true;
                            userid = data.USER_ID;
                            objUser.USER_ID = data.USER_ID;
                            objUser.USERNAME = data.USERNAME;
                            objUser.FIRST_NAME = data.FIRST_NAME;
                            objUser.LAST_NAME = data.LAST_NAME;
                            objUser.USER_CODE = data.USER_CODE;

                            //var host = Dns.GetHostEntry(Dns.GetHostName());
                            //foreach (var ip in host.AddressList)
                            //{
                            //    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            //    {
                            //        LOGIN_ACCESS accesslog = new LOGIN_ACCESS();
                            //        accesslog.USER_ID = data.USER_ID.ToString();
                            //        accesslog.USERNAME = data.USERNAME;
                            //        accesslog.LOGIN_DATE = clsFunction.GetDate();
                            //        accesslog.STATUS = "A";
                            //        accesslog.IP_ADDRESS = ip.ToString();

                            //        db.LOGIN_ACCESS.Add(accesslog);
                            //        db.SaveChanges();

                            //        objUser.LOGIN_ID = accesslog.LOGIN_ID;
                            //    }
                            //}
                        }
                    }

                    db.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return objUser;
        }
    }
}
