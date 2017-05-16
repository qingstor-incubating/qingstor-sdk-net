using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QingStor_SDK_CSharp.Common
{
    public static class ConstDef
    {
        public static readonly string OPERATION_ID = "operationId";

        public static readonly string REQ_HEADER_HOST = "Host";
        public static readonly string REQ_HEADER_PORT = "Port";
        public static readonly string REQ_HEADER_PROTOCOL = "Protocol";
        public static readonly string REQ_HEADER_CONNECT_RETRY = "ConnectionRetry";
        public static readonly string REQ_HEADER_LOG_LEVEL = "LogLevel";
        public static readonly string REQ_HEADER_ACCESS_KEY_ID = "AccessKeyID";
        public static readonly string REQ_HEADER_SECRET_ACCESS_KEY = "SecretAccessKey";
        public static readonly string REQ_HEADER_BUCKET_NAME = "BucketName";
        public static readonly string REQ_HEADER_OBJECT_NAME = "ObjectName";
        public static readonly string REQ_HEADER_ZONE = "Zone";
        public static readonly string REQ_HEADER_METHOD = "Method";
        public static readonly string REQ_HEADER_REQUEST_PATH = "RequestPath";
        public static readonly string REQ_HEADER_CONTENT_LENGTH = "Content-Length";
        public static readonly string REQ_HEADER_CONTENT_MD5 = "Content-MD5";
        public static readonly string REQ_HEADER_USER_AGENT = "User-Agent";
        public static readonly string REQ_HEADER_CONTENT_TYPE = "Content-Type";

        public static readonly string SUB_RESOURCE_ACL = "acl";
        public static readonly string SUB_RESOURCE_CORS = "cors";
        public static readonly string SUB_RESOURCE_DELETE = "delete";
        public static readonly string SUB_RESOURCE_MIRROR = "mirror";
        public static readonly string SUB_RESOURCE_POLICY = "policy";
        public static readonly string SUB_RESOURCE_STATS = "stats";
        public static readonly string SUB_RESOURCE_PART_NUMBER = "part_number";
        public static readonly string SUB_RESOURCE_UPLOADS = "uploads";
        public static readonly string SUB_RESOURCE_UPLOAD_ID = "upload_id";

        public static readonly string RESPONSE_FIELD_EXPIRES = "response-expires";
        public static readonly string RESPONSE_FIELD_CACHE_CONTROL = "response-cache-control";
        public static readonly string RESPONSE_FIELD_CONTENT_TYPE = "response-content-type";
        public static readonly string RESPONSE_FIELD_CONTENT_LANGUAGE = "response-content-language";
        public static readonly string RESPONSE_FIELD_CONTENT_ENCODING = "response-content-encoding";
        public static readonly string RESPONSE_FIELD_CONTENT_DISPOSITION = "response-content-disposition";
    }
}
