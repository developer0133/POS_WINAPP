using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.Models
{
    public class LoginAccessModel
    {
        public int LOGIN_ID { get; set; }
        public string USER_ID { get; set; }
        public string USERNAME { get; set; }
        public DateTime? LOGIN_DATE { get; set; }
        public DateTime? LOGOUT_DATE { get; set; }
        public string STATUS { get; set; }
        public string IP_ADDRESS { get; set; }
    }
}
