using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography;
using QingStor_SDK_CSharp.Common;

namespace QingStor_SDK_CSharp.Request
{
    // Authorization Class
    public class CAuthorization
    {
        private HttpWebRequest HttpRequest;
        private string strAccessKeyID;
        private string strSecretAccessKey;

        public CAuthorization(HttpWebRequest HttpRequest, string strAccessKeyID, string strSecretAccessKey)
        {
            this.HttpRequest = HttpRequest;
            this.strAccessKeyID = strAccessKeyID;
            this.strSecretAccessKey = strSecretAccessKey;
        }
        ~CAuthorization()
        {

        }

        // Get Authorization String
        public string GetAuthorization()
        {
            string strSign = "";
            string strCanonicalizedHeaders = GetCanonicalizedHeaders();
            if (strCanonicalizedHeaders.Equals(""))
            {
                strSign = string.Format("{0}\n{1}\n{2}\n{3}\n{4}", GetVerb(), GetContentMD5(), 
                                        GetContentType(), GetDate(), GetCanonicalizedResource());
            }
            else
            {
                strSign = string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", GetVerb(), GetContentMD5(), GetContentType(),
                                        GetDate(), strCanonicalizedHeaders, GetCanonicalizedResource());
            }

            var Encoding = new ASCIIEncoding();
            byte[] KeyByte = Encoding.GetBytes(strSecretAccessKey);
            var HmacSHA256 = new HMACSHA256(KeyByte);
            byte[] MsgBytes = Encoding.GetBytes(strSign);
            byte[] HashMsg = HmacSHA256.ComputeHash(MsgBytes);
            string strSignature = Convert.ToBase64String(HashMsg);
            string strAuth = string.Format("QS {0}:{1}", strAccessKeyID, strSignature);

            return strAuth;
        }

        // Verb
        private string GetVerb()
        {
            return HttpRequest.Method.ToUpper();
        }

        // Content-MD5
        private string GetContentMD5()
        {
            return HttpRequest.Headers["Content-MD5"];
        }

        // Content-Type
        private string GetContentType()
        {
            return HttpRequest.ContentType;
        }

        // Date
        private string GetDate()
        {
            return HttpRequest.Date.ToUniversalTime().ToString("r");
        }

        // Canonicalized Headers
        private string GetCanonicalizedHeaders()
        {
            Dictionary<string, string> dictHeaders = new Dictionary<string, string>();
            string[] strAllKeys = HttpRequest.Headers.AllKeys;
            foreach (var Item in strAllKeys)
            {
                string strKey = Item.ToLower();
                if (strKey.StartsWith("x-qs-"))
                {
                    dictHeaders.Add(strKey, HttpRequest.Headers[Item.ToString()]);
                }
            }

            // Order by Dictionary
            bool bFirst = true;
            string strCanonicalizedHeaders = ""; 
            Dictionary<string, string> dictSortHeaders = dictHeaders.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
            foreach (KeyValuePair<string, string> Item in dictSortHeaders)
            {
                if (bFirst)
                {
                    bFirst = false;
                    strCanonicalizedHeaders += string.Format("{0}:{1}", Item.Key, Item.Value);
                }
                else
                {
                    strCanonicalizedHeaders += string.Format("\n{0}:{1}", Item.Key, Item.Value);
                }
            }

            return strCanonicalizedHeaders;
        }

        // Canonicalized Resource
        private string GetCanonicalizedResource()
        {
            // Sub Resources
            string strSubResources = "";
            bool bFirst = true;
            Dictionary<string, string> dictSubResources = GetSubResources(HttpRequest.RequestUri.Query);
            foreach (var Item in dictSubResources)
            {
                if (bFirst)
                {
                    bFirst = false;
                    if (Item.Value.Equals(""))
                    {
                        strSubResources += string.Format("{0}", Item.Key);
                    }
                    else
                    {
                        strSubResources += string.Format("{0}={1}", Item.Key, Item.Value);
                    }
                }
                else
                {
                    if (Item.Value.Equals(""))
                    {
                        strSubResources += string.Format("&{0}", Item.Key);
                    }
                    else
                    {
                        strSubResources += string.Format("&{0}={1}", Item.Key, Item.Value);
                    }
                }
            }  // foreach (var Item in dictSubResources)

            string strResource = HttpRequest.RequestUri.AbsolutePath;
            if (!strSubResources.Equals(""))
            {
                strResource += string.Format("?{0}", strSubResources);
            }

            return strResource;
        }

        // Sub Resources
        private Dictionary<string, string> GetSubResources(string strQueryParams)
        {
            Dictionary<string, string> dictSubResources = new Dictionary<string, string>();

            if (strQueryParams.StartsWith("?") && strQueryParams.Length > 1)
            {
                strQueryParams = strQueryParams.Substring(1);
            }

            // Fetch
            string[] strSeparator = new string[] { "&" };
            string[] strSplit = strQueryParams.Split(strSeparator, StringSplitOptions.RemoveEmptyEntries);
            foreach (var Item in strSplit)
            {
                int nIndex = Item.IndexOf("=");
                if (nIndex != -1) 
                {
                    string strSubResource = Item.Substring(0, nIndex);
                    if (CGlobalSet.SetSubResources.Contains(strSubResource) 
                        || CGlobalSet.SetResponseFields.Contains(strSubResource))
                    {
                        string strSubResourceValue = "";
                        if (nIndex + 1 < Item.Length)
                        {
                            strSubResourceValue = Item.Substring(nIndex + 1);
                        }
                        dictSubResources.Add(strSubResource, strSubResourceValue);
                    }
                }
                else
                {
                    if (CGlobalSet.SetSubResources.Contains(Item) || CGlobalSet.SetResponseFields.Contains(Item))
                    {
                        dictSubResources.Add(Item, "");
                    }
                }
            }  // foreach (var Item in strSplit)

            // Order by Dictionary
            Dictionary<string, string> dictSortedSubResources = dictSubResources.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);

            return dictSortedSubResources;
        }
    }
}
