using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#if NET45
using System.Threading.Tasks;
#elif NET35 || NET40
#endif
using System.IO;
using System.Web.Script.Serialization;
using QingStor_SDK_NET.Yaml;

namespace QingStor_SDK_NET.Common
{
    // Config Class
    public class CConfig
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Protocol { get; set; }
        public Int32 ConnectionRetry { get; set; }
        public string LogLevel { get; set; }
        public string AccessKeyID { get; set; }
        public string SecretAccessKey { get; set; }
        public string UserAgent { get; set; }

        public CConfig(string strAccessKeyID, string strSecretAccessKey)
        {
            this.AccessKeyID = strAccessKeyID;
            this.SecretAccessKey = strSecretAccessKey;
            this.Host = "qingstor.com";
            this.Port = "443";
            this.Protocol = "https";
            this.ConnectionRetry = 3;
            this.LogLevel = "warn";
            this.UserAgent = "";
        }

        public CConfig(string strConfigFile)
        {
            if (!LoadConfigFile(strConfigFile))
            {
                this.AccessKeyID = "ACCESS_KEY_ID";
                this.SecretAccessKey = "SECRET_ACCESS_KEY";
                this.Host = "qingstor.com";
                this.Port = "443";
                this.Protocol = "https";
                this.ConnectionRetry = 3;
                this.LogLevel = "warn";
                this.UserAgent = "";
            }
        }
        
        public CConfig()
        {
            this.AccessKeyID = "ACCESS_KEY_ID";
            this.SecretAccessKey = "SECRET_ACCESS_KEY";
            this.Host = "qingstor.com";
            this.Port = "443";
            this.Protocol = "https";
            this.ConnectionRetry = 3;
            this.LogLevel = "warn";
            this.UserAgent = "";
        }

        ~CConfig()
        { 
        }

        private bool LoadConfigFile(string strConfigFile)
        {
            if (File.Exists(strConfigFile))
            {
                try
                {
                    YamlStream YamlStream = CYamlParser.Load(strConfigFile);
                    if (YamlStream != null)
                    {
                        foreach (YamlDocument YamlDoc in YamlStream.Documents)
                        {
                            DataItem Item = YamlDoc.Root;
                            if (Item is Mapping)
                            {
                                Mapping Mapping = Item as Mapping;
                                if (Mapping != null)
                                {
                                    foreach (MappingEntry MapEntry in Mapping.Enties)
                                    {
                                        string strKey = (MapEntry.Key == null ? "" : MapEntry.Key.ToString());
                                        string strValue = (MapEntry.Value == null ? "" : MapEntry.Value.ToString());

                                        // access_key_id
                                        if (strKey.Equals("access_key_id"))
                                        {
                                            this.AccessKeyID = strValue;
                                        }
                                        // secret_access_key
                                        else if (strKey.Equals("secret_access_key"))
                                        {
                                            this.SecretAccessKey = strValue;
                                        }
                                        // host
                                        else if (strKey.Equals("host"))
                                        {
                                            this.Host = strValue;
                                        }
                                        // port
                                        else if (strKey.Equals("port"))
                                        {
                                            this.Port = strValue;
                                        }
                                        // protocol
                                        else if (strKey.Equals("protocol"))
                                        {
                                            this.Protocol = strValue;
                                        }
                                        // connection_retries
                                        else if (strKey.Equals("connection_retries"))
                                        {
                                            this.ConnectionRetry = int.Parse(strValue);
                                        }
                                        // additional_user_agent
                                        else if (strKey.Equals("additional_user_agent"))
                                        {
                                            this.UserAgent = strValue;
                                        }
                                        // log_level
                                        else if (strKey.Equals("log_level"))
                                        {
                                            this.LogLevel = strValue;
                                        }
                                    }  // foreach (MappingEntry MapEntry in Mapping.Enties)

                                    return true;
                                }  // if (Mapping != null)
                            }  // if (Item is Mapping)
                        }  // foreach (YamlDocument YamlDoc in YamlStream.Documents)
                    }  // if (YamlStream != null)

                    return false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
