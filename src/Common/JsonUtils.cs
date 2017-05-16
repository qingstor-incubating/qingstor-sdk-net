using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace QingStor_SDK_CSharp.Common
{
    // Json Tools
    public static class CJsonUtils
    {
        // From Object to Json
        public static string ObjectToJson(object Obj)
        {
            if (Obj == null)
            {
                return "";
            }

            string strJson = JsonConvert.SerializeObject(Obj, Formatting.Indented, 
                                                         new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            return strJson;
        }

        // From Dictionary to Json
        public static string DictionaryToJson(Dictionary<Object, Object> DictObj)
        {
            JavaScriptSerializer JSS = new JavaScriptSerializer();

            return JSS.Serialize(DictObj);
        }

        // From Json to Object
        public static object JsonToObject(string strJson, object Obj)
        {
            if (strJson.Equals(""))
            {
                return null;
            }

            DataContractJsonSerializer Serializer = new DataContractJsonSerializer(Obj.GetType());
            MemoryStream Stream = new MemoryStream(Encoding.UTF8.GetBytes(strJson));

            return Serializer.ReadObject(Stream);
        }
    }
}
