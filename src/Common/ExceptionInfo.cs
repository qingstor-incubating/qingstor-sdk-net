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
    // Exception Info Class
    public class CExceptionInfo
    {
        public string url { get; set; }
        public string message { get; set; }
        public string code { get; set; }
        public string request_id { get; set; }
    }
}
