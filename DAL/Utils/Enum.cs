using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utils
{
    public class Enum
    {
    }

    public sealed class STATUS
    {
        public STATUS() { }
        public const string ACTIVE = "ACTIVE";
        public const string INACTIVE = "INACTIVE";
    }
    public sealed class KEY
    {
        public KEY() { }
        public const string KEY_STRING = "b14ca5898a4e4133bbce2ea2315a1916";
    }

    public sealed class POSPARAMETER
    {
        public POSPARAMETER() { }
        public const string POSPARAMETER_SIZE = "SIZE";
        public const string POSPARAMETER_TYPE = "TYPE";
        public const string UNIT = "UNIT";
        public const string UNITSELL = "UNITSELL";
    }

    public sealed class PARAMETERCODE
    {
        public PARAMETERCODE() { }
        public const string PARAMETER_SIZE = "SIZE";
        public const string PARAMETER_TYPE = "TYPE";
        public const string UNIT = "UNIT";
        public const string UNITSELL = "UNITSELL";

    }
}
