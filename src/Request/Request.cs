using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Web.Script.Serialization;
using QingStor_SDK_CSharp.Common;

namespace QingStor_SDK_CSharp.Request
{
    // Paramter Type
    enum EParamType
    {
        PARAM_TYPE_HEADER,  // header
        PARAM_TYPE_QUERY,   // query
        PARAM_TYPE_BODY     // body
    };

    // Http Request Class
    public class CRequest
    {
        private static CRequest SingletonInstance = null;

        private CRequest()
        {

        }
        ~CRequest()
        {

        }

        public static CRequest GetInstance()
        {
            if (SingletonInstance == null)
            {
                SingletonInstance = new CRequest();
            }

            return SingletonInstance;
        }

        // Http Request Entry
        public string Request(Dictionary<Object, Object> DictInput, Object InputParam)
        {
            string strResponse = "{";
            try
            {
                HttpWebRequest HttpRequest = CreateRequest(DictInput, InputParam);
                if (HttpRequest != null)
                {
                    HttpWebResponse HttpResponse = HttpRequest.GetResponse() as HttpWebResponse;
                    if (HttpResponse != null)
                    {
                        // StatusCode,RequestID
                        strResponse += string.Format("\"StatusCode\":{0}, \"RequestID\":\"{1}\"", 
                                                    (int)HttpResponse.StatusCode, 
                                                    HttpResponse.Headers.Get("X-QS-Request-ID"));

                        // Headers
                        string[] strHeaders = HttpResponse.Headers.AllKeys;
                        foreach (var Item in strHeaders)
                        {
                            string strKey = Item.ToString();
                            strKey = strKey.Replace("-", "_");
                            string strValue = HttpResponse.Headers.Get(Item.ToString());
                            strValue = strValue.Replace("\"", "");
                            strResponse += string.Format(", \"{0}\":\"{1}\"", strKey, strValue);
                        }

                        // Body
                        if (HttpResponse.StatusCode == HttpStatusCode.OK)
                        {
                            Stream ResponseStream = HttpResponse.GetResponseStream();
                            if (ResponseStream != null)
                            {
                                StreamReader Reader = new StreamReader(ResponseStream);
                                if (Reader != null)
                                {
                                    string strStream = Reader.ReadToEnd();
                                    if (strStream.StartsWith("{") && strStream.EndsWith("}") && strStream.Length > 2)
                                    {
                                        strStream = strStream.Substring(1, strStream.Length - 2);
                                        strResponse += string.Format(", {0}", strStream);
                                    }
                                }
                            }
                        }  // if (HttpResponse.StatusCode == HttpStatusCode.OK)

                        strResponse += "}";
                        return strResponse;
                    }
                }  // if (HttpRequest != null)

                strResponse += string.Format("\"StatusCode\":{0}", -1);
                strResponse += "}";
                return strResponse;
            }
            catch (WebException e)
            {
                // Exception Information
                HttpWebResponse HttpResponse = e.Response as HttpWebResponse;
                Stream Stream = e.Response.GetResponseStream();
                StreamReader Reader = new StreamReader(Stream);
                string strException = Reader.ReadToEnd();
                JavaScriptSerializer Serializer = new JavaScriptSerializer();
                CExceptionInfo ExceptionInfo = Serializer.Deserialize<CExceptionInfo>(strException);

                if (ExceptionInfo != null)
                {
                    strResponse += string.Format("\"StatusCode\":{0}, \"RequestID\":\"{1}\", \"ErrorCode\":\"{2}\"",
                                                 (int)HttpResponse.StatusCode, ExceptionInfo.request_id, ExceptionInfo.code);
                }
                else
                {
                    strResponse += string.Format("\"StatusCode\":{0}, \"RequestID\":\"{1}\", \"ErrorCode\":\"{2}\"",
                                                 (int)HttpResponse.StatusCode, "", "");
                }
                strResponse += "}";

                return strResponse;
            }
        }

        // Http Request Entry and Output Body Object
        public string Request(Dictionary<Object, Object> DictInput, Object InputParam, ref Object ObjOutput)
        {
            string strResponse = "{";
            try
            {
                HttpWebRequest HttpRequest = CreateRequest(DictInput, InputParam);
                if (HttpRequest != null)
                {
                    HttpWebResponse HttpResponse = HttpRequest.GetResponse() as HttpWebResponse;
                    if (HttpResponse != null)
                    {
                        // StatusCode,RequestID
                        strResponse += string.Format("\"StatusCode\":{0}, \"RequestID\":\"{1}\"",
                                                    (int)HttpResponse.StatusCode,
                                                    HttpResponse.Headers.Get("X-QS-Request-ID"));

                        // Headers
                        string[] strHeaders = HttpResponse.Headers.AllKeys;
                        foreach (var Item in strHeaders)
                        {
                            string strKey = Item.ToString();
                            strKey = strKey.Replace("-", "_");
                            string strValue = HttpResponse.Headers.Get(Item.ToString());
                            strValue = strValue.Replace("\"", "");
                            strResponse += string.Format(", \"{0}\":\"{1}\"", strKey, strValue);
                        }

                        // Body
                        if (HttpResponse.StatusCode == HttpStatusCode.OK)
                        {
                            Stream ResponseStream = HttpResponse.GetResponseStream();
                            if (ResponseStream != null)
                            {
                                ObjOutput = new StreamReader(ResponseStream);
                            }
                        }

                        strResponse += "}";
                        return strResponse;
                    }
                }  // if (HttpRequest != null)

                strResponse += string.Format("\"StatusCode\":{0}", -1);
                strResponse += "}";
                return strResponse;
            }
            catch (WebException e)
            {
                // Exception Information
                HttpWebResponse HttpResponse = e.Response as HttpWebResponse;
                Stream Stream = e.Response.GetResponseStream();
                StreamReader Reader = new StreamReader(Stream);
                string strException = Reader.ReadToEnd();
                JavaScriptSerializer Serializer = new JavaScriptSerializer();
                CExceptionInfo ExceptionInfo = Serializer.Deserialize<CExceptionInfo>(strException);

                if (ExceptionInfo != null)
                {
                    strResponse += string.Format("\"StatusCode\":{0}, \"RequestID\":\"{1}\", \"ErrorCode\":\"{2}\"",
                                                 (int)HttpResponse.StatusCode, ExceptionInfo.request_id, ExceptionInfo.code);
                }
                else
                {
                    strResponse += string.Format("\"StatusCode\":{0}, \"RequestID\":\"{1}\", \"ErrorCode\":\"{2}\"",
                                                 (int)HttpResponse.StatusCode, "", "");
                }
                strResponse += "}";

                return strResponse;
            }
        }

        // Build WebHttpRequest
        private HttpWebRequest CreateRequest(Dictionary<Object, Object> dictInput, Object InputParam)
        {
            try
            {
                // Fetch Header, Query and Body
                Dictionary<EParamType, Dictionary<Object, Object>> dictParams = GetParams(InputParam);
                if (dictParams == null)
                {
                    return null;
                }
                Dictionary<Object, Object> dictHeaderParams = dictParams.ContainsKey(EParamType.PARAM_TYPE_HEADER) ? 
                                                              dictParams[EParamType.PARAM_TYPE_HEADER] : null;
                Dictionary<Object, Object> dictQueryParams = dictParams.ContainsKey(EParamType.PARAM_TYPE_QUERY) ? 
                                                             dictParams[EParamType.PARAM_TYPE_QUERY] : null;
                Dictionary<Object, Object> dictBodyParams = dictParams.ContainsKey(EParamType.PARAM_TYPE_BODY) ?
                                                            dictParams[EParamType.PARAM_TYPE_BODY] : null;
                
                // URL
                HttpWebRequest HttpRequest = HttpWebRequest.Create(CreateURL(dictInput, dictQueryParams)) as HttpWebRequest;
                if (HttpRequest == null)
                {
                    return null;
                }

                // Method
                string strMethod = dictInput.ContainsKey(ConstDef.REQ_HEADER_METHOD) ?
                                   dictInput[ConstDef.REQ_HEADER_METHOD].ToString().ToUpper() : "";
                HttpRequest.Method = strMethod;

                // Headers
                if (!AddHeadersInfo(dictInput, dictHeaderParams, ref HttpRequest))
                {
                    //
                }

                // Authorization
                CAuthorization Auth = new CAuthorization(HttpRequest,
                                                         dictInput[ConstDef.REQ_HEADER_ACCESS_KEY_ID].ToString(),
                                                         dictInput[ConstDef.REQ_HEADER_SECRET_ACCESS_KEY].ToString());
                if (Auth == null)
                {
                    return null;
                }
                HttpRequest.Headers.Add("Authorization", Auth.GetAuthorization());

                // Body
                if ((!strMethod.Equals("GET") && !strMethod.Equals("HEAD")) && !AddBody(dictParams, ref HttpRequest))
                {
                    //
                }

                return HttpRequest;
            }
            catch (WebException e)
            {
                return null;
            }
        }

        // Build URL
        private string CreateURL(Dictionary<Object, Object> dictInput, Dictionary<Object, Object> dictQueryParams)
        {
            try
            {
                string strURL = "";

                // Filt "www." of Host
                string strHost = dictInput.ContainsKey(ConstDef.REQ_HEADER_HOST) ? dictInput[ConstDef.REQ_HEADER_HOST].ToString() : "";
                strHost = strHost.ToLower();
                if (strHost.StartsWith("www."))
                {
                    strHost = strHost.Substring(4);
                }

                // Port is empty
                if (dictInput.ContainsKey(ConstDef.REQ_HEADER_PORT)
                    && dictInput[ConstDef.REQ_HEADER_PORT].ToString().Equals(""))
                {
                    strURL = string.Format("{0}", strHost);
                }
                else
                {
                    strURL = string.Format("{0}:{1}", strHost, dictInput[ConstDef.REQ_HEADER_PORT]);
                }

                // Zone Exists
                if (dictInput.ContainsKey(ConstDef.REQ_HEADER_ZONE)
                    && !dictInput[ConstDef.REQ_HEADER_ZONE].ToString().Equals(""))
                {
                    strURL = string.Format("{0}.", dictInput[ConstDef.REQ_HEADER_ZONE]) + strURL;
                }

                // Protoco
                string strProtoco = dictInput.ContainsKey(ConstDef.REQ_HEADER_PROTOCOL) ?
                                    dictInput[ConstDef.REQ_HEADER_PROTOCOL].ToString() : "http";
                strURL = string.Format("{0}://", strProtoco) + strURL;

                // Path
                string strURLPath = dictInput.ContainsKey(ConstDef.REQ_HEADER_REQUEST_PATH) ?
                                    dictInput[ConstDef.REQ_HEADER_REQUEST_PATH].ToString() : "";
                strURL += strURLPath;

                // Add params to tail of URL, if the method is GET or sub resources
                string strMethod = dictInput.ContainsKey(ConstDef.REQ_HEADER_METHOD) ?
                                   dictInput[ConstDef.REQ_HEADER_METHOD].ToString().ToUpper() : "";
                if (dictQueryParams != null)
                {
                    // GET方法
                    if (strMethod.Equals("GET"))
                    {
                        // Query Params
                        string strQueryParams = "";
                        bool bFirst = true;
                        foreach (var Item in dictQueryParams)
                        {
                            if (bFirst)
                            {
                                bFirst = false;
                                strQueryParams += string.Format("{0}={1}", Item.Key, Item.Value);
                            }
                            else
                            {
                                strQueryParams += string.Format("&{0}={1}", Item.Key, Item.Value);
                            }
                        }

                        strURL = strURL + (strQueryParams.Equals("") ? "" : string.Format("?{0}", strQueryParams));
                    }  // if (strMethod.Equals("GET"))
                    // Sub Resources
                    else
                    {
                        // Query Params
                        string strQueryParams = "";
                        bool bFirst = true;
                        foreach (var Item in dictQueryParams)
                        {
                            if (!CGlobalSet.SetSubResources.Contains(Item.Key))
                            {
                                continue;
                            }

                            if (bFirst)
                            {
                                bFirst = false;
                                strQueryParams += string.Format("{0}={1}", Item.Key, Item.Value);
                            }
                            else
                            {
                                strQueryParams += string.Format("&{0}={1}", Item.Key, Item.Value);
                            }
                        }

                        strURL = strURL + (strQueryParams.Equals("") ? "" : string.Format("?{0}", strQueryParams));
                    }
                }  // if (dictQueryParams != null)

                return strURL;
            }  // try
            catch (WebException e)
            {
                // Exception Information
                Stream Stream = e.Response.GetResponseStream();
                StreamReader Reader = new StreamReader(Stream);
                string strException = Reader.ReadToEnd();

                return "";
            }
        }

        // Add Http Headers Info
        private bool AddHeadersInfo(Dictionary<Object, Object> dictInput, Dictionary<Object, Object> dictHeaderParams, 
                                    ref HttpWebRequest HttpRequest)
        {
            // Common Headers
            HttpRequest.ProtocolVersion = HttpVersion.Version11;
            HttpRequest.Method = dictInput[ConstDef.REQ_HEADER_METHOD].ToString();
            HttpRequest.Date = DateTime.Now;

            // Add Header Params
            if (!AddHeaderParams(dictHeaderParams, ref HttpRequest))
            {
                return false;
            }

            return true;
        }

        // Add Header Params
        private bool AddHeaderParams(Dictionary<Object, Object> dictHeaderParams, ref HttpWebRequest HttpRequest)
        {
            if (dictHeaderParams == null)
            {
                return false;
            }

            // header
            foreach (var Item in dictHeaderParams)
            {
                // Content-Length and Method are set elsewhere
                if (Item.Key.ToString().Equals("Content-Length")
                    || Item.Key.ToString().Equals("Method"))
                {
                    continue;
                }

                // Content-Type
                if (Item.Key.ToString().Equals("Content-Type"))
                {
                    string strContentType = Item.Value.ToString();
                    HttpRequest.ContentType = strContentType.Equals("") ? "application/octet-stream" : strContentType;
                }
                // IfModifiedSince
                else if (Item.Key.ToString().Equals("If-Modified-Since"))
                {
                    if (!string.IsNullOrEmpty(Item.Value.ToString()))
                    {
                        HttpRequest.IfModifiedSince = DateTime.Parse(Item.Value.ToString());
                    }
                }
                // Range
                else if (Item.Key.ToString().Equals("Range"))
                {
                    if (!string.IsNullOrEmpty(Item.Value.ToString()))
                    {
                        HttpRequest.AddRange(int.Parse(Item.Value.ToString()));
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(Item.Value.ToString()))
                    {
                        HttpRequest.Headers.Add(Item.Key.ToString(), Item.Value.ToString());
                    }
                }
            }
            
            return true;
        }

        // Fetch Header、Query and Body params
        private Dictionary<EParamType, Dictionary<Object, Object>> GetParams(Object InputParam)
        {
            Dictionary<EParamType, Dictionary<Object, Object>> dictParams = new Dictionary<EParamType, Dictionary<Object, Object>>();
            Dictionary<Object, Object> dictHeaderParams = new Dictionary<object, object>();
            Dictionary<Object, Object> dictQueryParams = new Dictionary<object, object>();
            Dictionary<Object, Object> dictBodyParams = new Dictionary<object, object>();

            if (InputParam == null)
            {
                return dictParams;
            }

            Type type = InputParam.GetType();
            PropertyInfo[] aPropertyInfo = type.GetProperties();
            foreach (var Item in aPropertyInfo)
            {
                // The Description of Attribute
                Object[] aObject = Item.GetCustomAttributes(typeof(CParamAttribute), false);
                foreach (CParamAttribute Attribute in aObject)
                {
                    // The Value of Param
                    PropertyInfo ProInfo = type.GetProperty(Attribute.ParamName);
                    string strParamKey = CGlobalSet.SetUnderlineID.Contains(Attribute.ParamName) ?
                                         Attribute.ParamName : Attribute.ParamName.Replace("_", "-");
                    Object ParamValue = ProInfo.GetValue(InputParam);

                    // header
                    if (Attribute.ParamType.Equals("header"))
                    {
                        dictHeaderParams.Add(strParamKey, ParamValue);
                    }
                    // query
                    else if (Attribute.ParamType.Equals("query"))
                    {
                        dictQueryParams.Add(strParamKey, ParamValue);
                    }
                    // body
                    else if (Attribute.ParamType.Equals("body"))
                    {
                        dictBodyParams.Add(strParamKey, ParamValue);
                    }
                }  // foreach (CParamAttribute Attribute in aObject)
            }  // foreach (var Item in aPropertyInfo)      

            // Add to common dictionary
            dictParams.Add(EParamType.PARAM_TYPE_HEADER, dictHeaderParams);
            dictParams.Add(EParamType.PARAM_TYPE_QUERY, dictQueryParams);
            dictParams.Add(EParamType.PARAM_TYPE_BODY, dictBodyParams);

            return dictParams;
        }

        // Add Body
        private bool AddBody(Dictionary<EParamType, Dictionary<Object, Object>> dictParams, 
                             ref HttpWebRequest HttpRequest)
        {
            if (dictParams == null)
            {
                return false;
            }

            Dictionary<Object, Object> dictHeaderParams = dictParams.ContainsKey(EParamType.PARAM_TYPE_HEADER) ? 
                                                          dictParams[EParamType.PARAM_TYPE_HEADER] : null;
            Dictionary<Object, Object> dictQueryParams = dictParams.ContainsKey(EParamType.PARAM_TYPE_QUERY) ? 
                                                         dictParams[EParamType.PARAM_TYPE_QUERY] : null;
            Dictionary<Object, Object> dictBodyParams = dictParams.ContainsKey(EParamType.PARAM_TYPE_BODY) ? 
                                                        dictParams[EParamType.PARAM_TYPE_BODY] : null;

            bool bFirst = true;
            string strBodyData = "";

            // Query Params
            if (dictQueryParams != null)
            {
                foreach (var Item in dictQueryParams)
                {
                    if (Item.Key != null && Item.Value != null)
                    {
                        // It's finished,if it is Sub Resources.
                        if (CGlobalSet.SetSubResources.Contains(Item.Key))
                        {
                            continue;
                        }

                        if (bFirst)
                        {
                            bFirst = false;
                            strBodyData += string.Format("\"{0}\":{1}", Item.Key, CJsonUtils.ObjectToJson(Item.Value));
                        }
                        else
                        {
                            strBodyData += string.Format(", \"{0}\":{1}", Item.Key, CJsonUtils.ObjectToJson(Item.Value));
                        }
                    }
                }
            }

            // Body Element
            FileStream fileStream = null;
            if (dictBodyParams != null)
            {
                foreach (var Item in dictBodyParams)
                {
                    if (Item.Key != null && Item.Value != null)
                    {
                        // Upload file
                        if (Item.Key.ToString().Equals("Body"))
                        {
                            fileStream = Item.Value as FileStream;
                            continue;
                        }

                        if (bFirst)
                        {
                            bFirst = false;
                            strBodyData += string.Format("\"{0}\":{1}", Item.Key, CJsonUtils.ObjectToJson(Item.Value));
                        }
                        else
                        {
                            strBodyData += string.Format(", \"{0}\":{1}", Item.Key, CJsonUtils.ObjectToJson(Item.Value));
                        }
                    }
                }
            }

            // Upload file or not
            if (fileStream != null)
            {
                if (dictHeaderParams != null)
                {
                    // Content-Length
                    if (dictHeaderParams.ContainsKey(ConstDef.REQ_HEADER_CONTENT_LENGTH))
                    {
                        HttpRequest.ContentLength = fileStream.Length;
                    }
                }

                byte[] Buffer = new Byte[checked((uint)Math.Min(4096, (int)fileStream.Length))];
                int ReadBytes = 0;
                while ((ReadBytes = fileStream.Read(Buffer, 0, Buffer.Length)) != 0)
                {
                    HttpRequest.GetRequestStream().Write(Buffer, 0, ReadBytes);
                }
            }  // if (fileStream != null)
            else
            {
                strBodyData = "{" + strBodyData + "}";
                byte[] BodyByte = Encoding.UTF8.GetBytes(strBodyData);

                // Set Header Info
                if (dictHeaderParams != null)
                {
                    // Content-Length
                    if (dictHeaderParams.ContainsKey(ConstDef.REQ_HEADER_CONTENT_LENGTH))
                    {
                        HttpRequest.ContentLength = BodyByte.Length;
                    }
                }

                // Write Data Stream
                HttpRequest.GetRequestStream().Write(BodyByte, 0, BodyByte.Length);
            }

            return true;
        }
    }
}
