using System;
using System.Collections.Generic;
using System.Text;

namespace QingStor_SDK_NET.Yaml
{
    public partial class MappingEntry
    {
        public override string ToString()
        {
            return String.Format("{{Key:{0}, Value:{1}}}", Key, Value);
        }
    }
}
