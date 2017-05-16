using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using IronRuby;
using IronRuby.Hosting;
using IronRuby.StandardLibrary.Yaml;
using QingStor_SDK_CSharp.Yaml;

namespace QingStor_SDK_CSharp.Common
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
                    // Json串
                    /*StreamReader SR = new StreamReader(strConfigFile);
                    string strLine = "";
                    string strJson = "";
                    while ((strLine = SR.ReadLine()) != null)
                    {
                        strJson += strLine;
                    }

                    // 将Json串转换为Config结构
                    JavaScriptSerializer Serializer = new JavaScriptSerializer();
                    if (Serializer == null)
                    {
                        return false;
                    }
                    CConfig Config = Serializer.Deserialize<CConfig>(strJson);*/

                    CYamlParse YamlParse = new CYamlParse();
                    var Config = YamlParse.ParseFile(strConfigFile);

                    var AccessKeyID = ((Config as MappingNode).Nodes.Where(n => (n.Key as ScalarNode).Value == "access_key_id").Single().Value as ScalarNode).Value;
                    var SecretAccessKey = ((Config as MappingNode).Nodes.Where(n => (n.Key as ScalarNode).Value == "secret_access_key").Single().Value as ScalarNode).Value;
                    var Host = ((Config as MappingNode).Nodes.Where(n => (n.Key as ScalarNode).Value == "host").Single().Value as ScalarNode).Value;
                    var Port = ((Config as MappingNode).Nodes.Where(n => (n.Key as ScalarNode).Value == "port").Single().Value as ScalarNode).Value;
                    var Protoco = ((Config as MappingNode).Nodes.Where(n => (n.Key as ScalarNode).Value == "protocol").Single().Value as ScalarNode).Value;
                    var ConnectionRetry = ((Config as MappingNode).Nodes.Where(n => (n.Key as ScalarNode).Value == "connection_retries").Single().Value as ScalarNode).Value;
                    var LogLevel = ((Config as MappingNode).Nodes.Where(n => (n.Key as ScalarNode).Value == "log_level").Single().Value as ScalarNode).Value;
                    var UserAgent = ((Config as MappingNode).Nodes.Where(n => (n.Key as ScalarNode).Value == "additional_user_agent").Single().Value as ScalarNode).Value;
                    
                    this.Host = (Host == null ? "" : Host);
                    this.Port = (Port == null ? "" : Port);
                    this.Protocol = (Protoco == null ? "" : Protoco);
                    this.ConnectionRetry = int.Parse(ConnectionRetry == null ? "" : ConnectionRetry);
                    this.LogLevel = (LogLevel == null ? "" : LogLevel);
                    this.AccessKeyID = (AccessKeyID == null ? "" : AccessKeyID);
                    this.SecretAccessKey = (SecretAccessKey == null ? "" : SecretAccessKey);
                    this.UserAgent = (UserAgent == null ? "" : UserAgent);

                    return true;
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
