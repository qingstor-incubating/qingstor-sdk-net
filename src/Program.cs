using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net;
using System.Reflection;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using Newtonsoft.Json;
using Microsoft.Scripting.Hosting;
using IronRuby;
using IronRuby.Hosting;
using IronRuby.StandardLibrary.Yaml;
using System.Linq.Expressions;
using QingStor_SDK_CSharp.Common;
using QingStor_SDK_CSharp.Service;
using QingStor_SDK_CSharp.Yaml;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.ListBuckets
            CListBucketsInput input2 = new CListBucketsInput();
            input2.Location = "pek3a";
            CConfig Config = new CConfig("Config.yaml");
            CQingStor Service = new CQingStor(Config);
            CListBucketsOutput ListBuckets = Service.ListBuckets(null);

            // 2.List Objects
            CBucket Bucket = Service.Bucket("david-bucket1", "zw");
            CListObjectsInput ObjectListInput = new CListObjectsInput() { delimiter = "/", limit = 4, prefix = "OK", marker = "a"};
            CListObjectsOutput ListObject = Bucket.ListObjects(null);

            // 3.Put Bucket
            CBucket PutBucket = Service.Bucket("test-david-bucket1", "zw");
            CPutBucketOutput BucketOutput = PutBucket.Put();

            // 4.DELETE Bucket
            CBucket DeleteBucket = Service.Bucket("test-david-bucket", "zw");
            CDeleteBucketOutput BucketDeleteOutput = DeleteBucket.Delete();

            // 5.Delete Multiple Objects
            CBucket DeleteMultiObj = Service.Bucket("david-bucket1", "zw");
            CDeleteMultipleObjectsInput DelMultiObjInput = new CDeleteMultipleObjectsInput();
            DelMultiObjInput.quiet = false;
            byte[] BodyByte = Encoding.UTF8.GetBytes("{\"objects\":[{\"created\": \"2017-05-11T03:16:56.000Z\",\"encrypted\": false,\"etag\": \"\"a059f21902873d07795b8fbf9ec8a582\"\",\"key\": \"Python.pdf\",\"mime_type\": \"application/pdf\",\"modified\": 1494472616,\"size\": 6589681}], \"quiet\":false}");
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] ByteMD5 = md5.ComputeHash(BodyByte);
            //DelMultiObjInput.Content_MD5 = "1cSpfDo7midVxHBxHfx/Hg==";
            DelMultiObjInput.objects = ListObject.keys;
            CDeleteMultipleObjectsOutput BucketDeleteMultiOutput = DeleteMultiObj.DeleteMultipleObjects(DelMultiObjInput);

            // 6.HEAD Bucket
            CBucket HeadBucket = Service.Bucket("david-bucket1", "zw");
            CHeadBucketOutput HeadObjOutput = HeadBucket.Head();

            // 7.GET Bucket Statistics
            CBucket StatisticsBucket = Service.Bucket("david-bucket1", "zw");
            CGetBucketStatisticsOutput StatisticsOutput = StatisticsBucket.GetStatistics();

            // 8.PUT Bucket ACL
            CGranteeType Grantee = new CGranteeType() { id = "usr-lQJuQJSp", type = "user" };
            CACLType ACL = new CACLType() { grantee = Grantee, permission = "FULL_CONTROL" };
            CPutBucketACLInput PutBucketACLInput = new CPutBucketACLInput();
            PutBucketACLInput.acl = new CACLType[] { ACL };
            CPutBucketACLOutput PutBucketACLOutput = Bucket.PutACL(PutBucketACLInput);

            // 9.GET Bucket ACL
            CGetBucketACLOutput GetACLOutput = Bucket.GetACL();

            // 10.PUT Bucket CORS
            CBucket BucketCors = Service.Bucket("david-bucket1", "zw");
            CPutBucketCORSInput CorsInput = new CPutBucketCORSInput();
            CCORSRuleType CORSRule = new CCORSRuleType();
            string[] strHeaders = new string[] { "X-QS-Date", "Content-Type", "Content-MD5", "Authorization" };
            CORSRule.allowed_headers = strHeaders;
            string[] strMethods = new string[] { "PUT", "GET", "HEAD"};
            CORSRule.allowed_methods = strMethods;
            CORSRule.allowed_origin = "http://*.qingstorage.com";
            CorsInput.cors_rules = new CCORSRuleType[] {CORSRule };
            CPutBucketCORSOutput CorsOutput = BucketCors.PutCORS(CorsInput);

            // 11.GET Bucket CORS
            CGetBucketCORSOutput GetCorsOutput = BucketCors.GetCORS();

            // 12.DELETE Bucket CORS
            CDeleteBucketCORSOutput DelCorsOutput = BucketCors.DeleteCORS();

            // 13.PUT Bucket Policy
            CBucket BucketPolicy = Service.Bucket("david-bucket2", "zw");
            CPutBucketPolicyInput PolicyInput = new CPutBucketPolicyInput();
            CStatementType stmt = new CStatementType();
            stmt.id = "allow usr-qo3yay7t to list objects and create objects";
            string[] strUsers = new string[] { "usr-lQJuQJSp" };
            stmt.user = strUsers;
            stmt.effect = "deny";
            string[] strResource = new string[] { "david-bucket2/source_code.rar" };
            stmt.resource = strResource;
            string[] action = new string[] { "list_objects", "create_object" };
            stmt.action = action;
            CConditionType Condition = new CConditionType();
            string[] strRefer = new string[] { "*.zw.qingstorage.com" };
            Condition.string_like = new CStringLikeType() { Referer = strRefer };
            stmt.condition = Condition;
            PolicyInput.statement = new CStatementType[] { stmt };
            CPutBucketPolicyOutput PolicyOutput = BucketPolicy.PutPolicy(PolicyInput);

            // 14.GET Bucket Policy
            CGetBucketPolicyOutput GetPolicyOutput = BucketPolicy.GetPolicy();

            // 15.DELETE Bucket Policy
            CDeleteBucketPolicyOutput DelPolicyOutput = BucketPolicy.DeletePolicy();

            // 16.PUT Bucket External Mirror
            CBucket BucketMirror = Service.Bucket("david-bucket1", "zw");
            CPutBucketExternalMirrorInput MirrorInput = new CPutBucketExternalMirrorInput();
            MirrorInput.source_site = "http://download.csdn.net/download";
            CPutBucketExternalMirrorOutput MirrorOutput = BucketMirror.PutExternalMirror(MirrorInput);

            // 17.GET Bucket External Mirror
            CGetBucketExternalMirrorOutput GetMirrorOutput = BucketMirror.GetExternalMirror();

            // 18.DELETE Bucket External Mirror
            CDeleteBucketExternalMirrorOutput DelMirrorOutput = BucketMirror.DeleteExternalMirror();

            // 19.GET Object
            CBucket BucketObj = Service.Bucket("david-bucket1", "zw");
            CGetObjectInput ObjInput = new CGetObjectInput();
            CGetObjectOutput ObjOutput = BucketObj.GetObject("5.txt", ObjInput);
            StreamReader SR2 = ObjOutput.Body;
            FileStream fs = File.Create("E:\\Win.txt");
            if (SR2 != null)
            {
                string strStream = SR2.ReadToEnd();
                byte[] DataByte = System.Text.Encoding.Default.GetBytes(strStream);
                fs.Write(DataByte, 0, DataByte.Length);
                fs.Flush();
                fs.Close();
            }

            // 20.POST Object Web页面使用,SDK不提供
            // 21.PUT Object
            CBucket BucketPutObj = Service.Bucket("david-bucket1", "zw");
            CPutObjectInput PutObjInput = new CPutObjectInput();
            PutObjInput.Content_Type = "application/pdf";
            PutObjInput.Body = new FileStream("C:\\Users\\lanhaibin\\Desktop\\Python.pdf", FileMode.Open);
            CPutObjectOutput PutObjOutput = BucketPutObj.PutObject("Python.pdf", PutObjInput);

            // 22.PUT Object - Copy
            CPutObjectInput PutObjInputCopy = new CPutObjectInput();
            CBucket BucketCopy = Service.Bucket("david-bucket2", "zw");
            PutObjInputCopy.Content_Type = "application/pdf";
            string strCopySrc = "/david-bucket1/";
            strCopySrc = strCopySrc + System.Web.HttpUtility.UrlEncode("Python.pdf");
            PutObjInputCopy.X_QS_Copy_Source = strCopySrc;
            PutObjInputCopy.X_QS_Copy_Source_If_Unmodified_Since = DateTime.Now.ToUniversalTime().ToString("r");
            CPutObjectOutput PutObjOutputCopy = BucketCopy.PutObject("Python.pdf", PutObjInputCopy);

            // 23.PUT Object - Move
            CPutObjectInput MoveObjInput = new CPutObjectInput();
            MoveObjInput.Content_Type = "application/pdf";
            string strMoveSrc = "/david-bucket1/";
            strMoveSrc = strMoveSrc + System.Web.HttpUtility.UrlEncode("Python.pdf");
            MoveObjInput.X_QS_Move_Source = strMoveSrc;
            CBucket BucketMoveObj = Service.Bucket("david-bucket2", "zw");
            CPutObjectOutput MoveObjOutput = BucketMoveObj.PutObject("Python.pdf", MoveObjInput);

            // 24.DELETE Object
            CBucket BucketDelObj = Service.Bucket("david-bucket1", "zw");
            CDeleteObjectOutput DelObjOutput = BucketObj.DeleteObject("Windows内核安全与驱动开发.pdf");

            // 25.HEAD Object
            CBucket BucketHeadObj = Service.Bucket("david-bucket1", "zw");
            CHeadObjectInput HeadObjInput = new CHeadObjectInput();
            CHeadObjectOutput HeadObjectOutput = BucketObj.HeadObject("Python.pdf", HeadObjInput);

            // 26.OPTIONS Object
            COptionsObjectInput OptionsObjInput = new COptionsObjectInput();
            OptionsObjInput.Origin = "http://csharp.pek3a.qingstor.com";
            OptionsObjInput.Access_Control_Request_Method = "GET";
            OptionsObjInput.Access_Control_Request_Headers = "Content-MD5";
            COptionsObjectOutput OptionsObjOutput = BucketObj.OptionsObject("Python.pdf", OptionsObjInput);

            // 27.Initiate Multipart Upload
            CInitiateMultipartUploadInput InitInput = new CInitiateMultipartUploadInput();
            InitInput.Content_Type = "application/pdf";
            CInitiateMultipartUploadOutput InitOutput = BucketObj.InitiateMultipartUpload("Windows内核安全与驱动开发.pdf", InitInput);

            // 28.Upload Multipart
            CUploadMultipartInput UploadInput = new CUploadMultipartInput();
            UploadInput.upload_id = InitOutput.upload_id;
            UploadInput.part_number = 1;
            UploadInput.Body = File.Open("D:\\电子书\\Windows内核安全与驱动开发.pdf", FileMode.Open);
            CUploadMultipartOutput UploadOutput = BucketObj.UploadMultipart("Windows内核安全与驱动开发.pdf", UploadInput);

            // 29.List Multipart
            CListMultipartInput ListMultiInput = new CListMultipartInput();
            ListMultiInput.upload_id = InitOutput.upload_id;
            ListMultiInput.limit = 800;
            CListMultipartOutput ListMultiOutput = BucketObj.ListMultipart("Windows内核安全与驱动开发.pdf", ListMultiInput);

            // 30.Abort Multipart Upload
            CAbortMultipartUploadInput AbortMultiInput = new CAbortMultipartUploadInput();
            AbortMultiInput.upload_id = InitOutput.upload_id;
            CAbortMultipartUploadOutput AbortMultiOutput = BucketObj.AbortMultipartUpload("Windows.pdf", AbortMultiInput);

            // 31.Complete Multipart Upload
            CCompleteMultipartUploadInput CompleteInput = new CCompleteMultipartUploadInput();
            CompleteInput.upload_id = InitOutput.upload_id;
            CObjectPartType ObjPart = new CObjectPartType();
            ObjPart.part_number = 1;
            CompleteInput.object_parts = new CObjectPartType[] { ObjPart };
            CCompleteMultipartUploadOutput CompleteOutput = BucketObj.CompleteMultipartUpload("Windows内核安全与驱动开发.pdf", CompleteInput);
        }
    }
}
