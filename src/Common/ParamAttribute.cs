using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#if NET45
using System.Threading.Tasks;
#elif NET35 || NET40
#endif

namespace QingStor_SDK_NET.Common
{
    [AttributeUsage(AttributeTargets.All)]
    public class CParamAttribute : System.Attribute
    {
        public string ParamType { get; set; }
        public string ParamName { get; set; }
    }
}
