using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.DTO
{
    public class MasterUserDTO
    {
        public int USER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public int DEPARTMENT_ID { get; set; }
        public int ROLE_ID { get; set; }
        public string STATUS { get; set; }
        public string USER_CODE { get; set; }
        public string C_BY { get; set; }
        public DateTime? C_DATE { get; set; }
        public string E_BY { get; set; }
        public DateTime? E_DATE { get; set; }
        public int LOGIN_ID { get; set; }
    }
}
