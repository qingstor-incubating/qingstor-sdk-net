using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QingStor_SDK_CSharp.Common
{
    [AttributeUsage(AttributeTargets.All)]
    public class CParamAttribute : System.Attribute
    {
        public string ParamType { get; set; }
        public string ParamName { get; set; }
    }
}
