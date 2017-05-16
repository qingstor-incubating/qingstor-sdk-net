// +-------------------------------------------------------------------------
// | Copyright (C) 2017 Yunify, Inc.
// +-------------------------------------------------------------------------
// | Licensed under the Apache License, Version 2.0 (the "License");
// | you may not use this work except in compliance with the License.
// | You may obtain a copy of the License in the LICENSE file, or at:
// |
// | http://www.apache.org/licenses/LICENSE-2.0
// |
// | Unless required by applicable law or agreed to in writing, software
// | distributed under the License is distributed on an "AS IS" BASIS,
// | WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// | See the License for the specific language governing permissions and
// | limitations under the License.
// +-------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using QingStor_SDK_CSharp.Common;
using QingStor_SDK_CSharp.Request;
namespace QingStor_SDK_CSharp.Service
{
	public class CDeleteBucketOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
	public class CDeleteBucketCORSOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
	public class CDeleteBucketExternalMirrorOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
	public class CDeleteBucketPolicyOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
    public class CDeleteMultipleObjectsInput : ICustomType
	{
		public CDeleteMultipleObjectsInput()
		{
		    this.Content_MD5 = "";
		    this.objects = null;
		    this.quiet = false;
		}
		// Object MD5sum
        // Required
	    [CParam(ParamType = "header", ParamName = "Content_MD5")]
	    public string Content_MD5 { get; set; }
		// The request body
		// A list of keys to delete        // Required
	    [CParam(ParamType = "body", ParamName = "objects")]
	    public CKeyType[] objects { get; set; }
		// Whether to return the list of deleted objects
	    [CParam(ParamType = "body", ParamName = "quiet")]
	    public bool quiet { get; set; }
	}
	public class CDeleteMultipleObjectsOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// List of deleted objects
	    [CParam(ParamType = "query", ParamName = "deleted")]
	    public CKeyType[] deleted { get; set; }
		// Error messages
	    [CParam(ParamType = "query", ParamName = "errors")]
	    public CKeyDeleteErrorType[] errors { get; set; }
	}
	public class CGetBucketACLOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Bucket ACL rules
	    [CParam(ParamType = "query", ParamName = "acl")]
	    public CACLType[] acl { get; set; }
		// Bucket owner
	    [CParam(ParamType = "query", ParamName = "owner")]
	    public COwnerType owner { get; set; }
	}
	public class CGetBucketCORSOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }

		// Bucket CORS rules
	    [CParam(ParamType = "query", ParamName = "cors_rules")]
	    public CCORSRuleType[] cors_rules { get; set; }
	}
	public class CGetBucketExternalMirrorOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Source site url
	    [CParam(ParamType = "query", ParamName = "source_site")]
	    public string source_site { get; set; }
	}
	public class CGetBucketPolicyOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Bucket policy statement
	    [CParam(ParamType = "query", ParamName = "statement")]
	    public CStatementType[] statement { get; set; }
	}
	public class CGetBucketStatisticsOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Objects count in the bucket
	    [CParam(ParamType = "query", ParamName = "count")]
	    public long count { get; set; }
		// Bucket created time
	    [CParam(ParamType = "query", ParamName = "created")]
	    public string created { get; set; }
		// QingCloud Zone ID
	    [CParam(ParamType = "query", ParamName = "location")]
	    public string location { get; set; }
		// Bucket name
	    [CParam(ParamType = "query", ParamName = "name")]
	    public string name { get; set; }
		// Bucket storage size
	    [CParam(ParamType = "query", ParamName = "size")]
	    public long size { get; set; }
		// Bucket status
		// Status's available values: active, suspended
	    [CParam(ParamType = "query", ParamName = "status")]
	    public string status { get; set; }
		// URL to access the bucket
	    [CParam(ParamType = "query", ParamName = "url")]
	    public string url { get; set; }
	}
	public class CHeadBucketOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
    public class CListMultipartUploadsInput : ICustomType
	{
		public CListMultipartUploadsInput()
		{
		    this.delimiter = "";
		    this.limit = 0;
		    this.marker = "";
		    this.prefix = "";
		}
		// Put all keys that share a common prefix into a list
	    [CParam(ParamType = "query", ParamName = "delimiter")]
	    public string delimiter { get; set; }
		// Results count limit
	    [CParam(ParamType = "query", ParamName = "limit")]
	    public long limit { get; set; }
		// Limit results to keys that start at this marker
	    [CParam(ParamType = "query", ParamName = "marker")]
	    public string marker { get; set; }
		// Limits results to keys that begin with the prefix
	    [CParam(ParamType = "query", ParamName = "prefix")]
	    public string prefix { get; set; }
	}
	public class CListMultipartUploadsOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Other object keys that share common prefixes
	    [CParam(ParamType = "query", ParamName = "common_prefixes")]
	    public string[] common_prefixes { get; set; }
		// Delimiter that specified in request parameters
	    [CParam(ParamType = "query", ParamName = "delimiter")]
	    public string delimiter { get; set; }
		// Limit that specified in request parameters
	    [CParam(ParamType = "query", ParamName = "limit")]
	    public long limit { get; set; }
		// Marker that specified in request parameters
	    [CParam(ParamType = "query", ParamName = "marker")]
	    public string marker { get; set; }
		// Bucket name
	    [CParam(ParamType = "query", ParamName = "name")]
	    public string name { get; set; }
		// The last key in keys list
	    [CParam(ParamType = "query", ParamName = "next_marker")]
	    public string next_marker { get; set; }
		// Prefix that specified in request parameters
	    [CParam(ParamType = "query", ParamName = "prefix")]
	    public string prefix { get; set; }
		// Multipart uploads
	    [CParam(ParamType = "query", ParamName = "uploads")]
	    public CUploadsType[] uploads { get; set; }
	}
    public class CListObjectsInput : ICustomType
	{
		public CListObjectsInput()
		{
            this.delimiter = "";
            this.limit = 0;
            this.marker = "";
            this.prefix = "";	
		}
		// Put all keys that share a common prefix into a list
	    [CParam(ParamType = "query", ParamName = "delimiter")]
	    public string delimiter { get; set; }

		// Results count limit
	    [CParam(ParamType = "query", ParamName = "limit")]
	    public long limit { get; set; }
		// Limit results to keys that start at this marker
	    [CParam(ParamType = "query", ParamName = "marker")]
	    public string marker { get; set; }
		// Limits results to keys that begin with the prefix
	    [CParam(ParamType = "query", ParamName = "prefix")]
	    public string prefix { get; set; }
	}
	public class CListObjectsOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Other object keys that share common prefixes
	    [CParam(ParamType = "query", ParamName = "common_prefixes")]
	    public string[] common_prefixes { get; set; }

		// Delimiter that specified in request parameters
	    [CParam(ParamType = "query", ParamName = "delimiter")]
	    public string delimiter { get; set; }
		// Object keys
	    [CParam(ParamType = "query", ParamName = "keys")]
	    public CKeyType[] keys { get; set; }
		// Limit that specified in request parameters
	    [CParam(ParamType = "query", ParamName = "limit")]
	    public long limit { get; set; }
		// Marker that specified in request parameters
	    [CParam(ParamType = "query", ParamName = "marker")]
	    public string marker { get; set; }
		// Bucket name
	    [CParam(ParamType = "query", ParamName = "name")]
	    public string name { get; set; }
		// The last key in keys list
	    [CParam(ParamType = "query", ParamName = "next_marker")]
	    public string next_marker { get; set; }
		// Bucket owner
	    [CParam(ParamType = "query", ParamName = "owner")]
	    public COwnerType owner { get; set; }
		// Prefix that specified in request parameters
	    [CParam(ParamType = "query", ParamName = "prefix")]
	    public string prefix { get; set; }
	}
	public class CPutBucketOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
    public class CPutBucketACLInput : ICustomType
	{
		public CPutBucketACLInput()
		{
		    this.acl = null;
		}
		// The request body
		// Bucket ACL rules        // Required
	    [CParam(ParamType = "body", ParamName = "acl")]
	    public CACLType[] acl { get; set; }
	}
	public class CPutBucketACLOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
    public class CPutBucketCORSInput : ICustomType
	{
		public CPutBucketCORSInput()
		{
		    this.cors_rules = null;
		}
		// The request body
		// Bucket CORS rules        // Required
	    [CParam(ParamType = "body", ParamName = "cors_rules")]
	    public CCORSRuleType[] cors_rules { get; set; }
	}
	public class CPutBucketCORSOutput : ICustomType
	{   
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
    public class CPutBucketExternalMirrorInput : ICustomType
	{
		public CPutBucketExternalMirrorInput()
		{
		    this.source_site = "";
		}
		// The request body
		// Source site url        // Required
	    [CParam(ParamType = "body", ParamName = "source_site")]
	    public string source_site { get; set; }
	}
	public class CPutBucketExternalMirrorOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
    public class CPutBucketPolicyInput : ICustomType
	{
		public CPutBucketPolicyInput()
		{
		    this.statement = null;
		}
		// The request body
		// Bucket policy statement        // Required
	    [CParam(ParamType = "body", ParamName = "statement")]
	    public CStatementType[] statement { get; set; }
	}
	public class CPutBucketPolicyOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}	
    public class CAbortMultipartUploadInput : ICustomType
	{
		public CAbortMultipartUploadInput()
		{
		    this.upload_id = "";
		}
		// Object multipart upload ID
        // Required
	    [CParam(ParamType = "query", ParamName = "upload_id")]
	    public string upload_id { get; set; }
	}
	public class CAbortMultipartUploadOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
    public class CCompleteMultipartUploadInput : ICustomType
	{
		public CCompleteMultipartUploadInput()
		{
		    this.upload_id = "";
		    this.ETag = "";
		    this.X_QS_Encryption_Customer_Algorithm = "";
		    this.X_QS_Encryption_Customer_Key = "";
		    this.X_QS_Encryption_Customer_Key_MD5 = "";
		    this.object_parts = null;
		}
		// Object multipart upload ID
        // Required
	    [CParam(ParamType = "query", ParamName = "upload_id")]
	    public string upload_id { get; set; }
		// MD5sum of the object part
	    [CParam(ParamType = "header", ParamName = "ETag")]
	    public string ETag { get; set; }
		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
	    public string X_QS_Encryption_Customer_Algorithm { get; set; }
		// Encryption key of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key")]
	    public string X_QS_Encryption_Customer_Key { get; set; }
		// MD5sum of encryption key
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key_MD5")]
	    public string X_QS_Encryption_Customer_Key_MD5 { get; set; }
		// Object parts
	    [CParam(ParamType = "body", ParamName = "object_parts")]
	    public CObjectPartType[] object_parts { get; set; }
	}
	public class CCompleteMultipartUploadOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }

        // Encryption algorithm of the object
        [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
        public string X_QS_Encryption_Customer_Algorithm { get; set; }
	}
	public class CDeleteObjectOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
	}
    public class CGetObjectInput : ICustomType
	{
		public CGetObjectInput()
		{
            this.response_cache_control = "";
            this.response_content_disposition = "";
            this.response_content_encoding = "";
            this.response_content_language = "";
            this.response_content_type = "";
            this.response_expires = "";
            this.If_Match = "";
            this.If_Modified_Since = "";
            this.If_None_Match = "";
            this.If_Unmodified_Since = "";
            this.Range = "";
            this.X_QS_Encryption_Customer_Algorithm = "";
            this.X_QS_Encryption_Customer_Key = "";
		    this.X_QS_Encryption_Customer_Key_MD5 = "";
		}
		// Specified the Cache-Control response header
	    [CParam(ParamType = "query", ParamName = "response_cache_control")]
	    public string response_cache_control { get; set; }
		// Specified the Content-Disposition response header
	    [CParam(ParamType = "query", ParamName = "response_content_disposition")]
	    public string response_content_disposition { get; set; }
		// Specified the Content-Encoding response header
	    [CParam(ParamType = "query", ParamName = "response_content_encoding")]
	    public string response_content_encoding { get; set; }
		// Specified the Content-Language response header
	    [CParam(ParamType = "query", ParamName = "response_content_language")]
	    public string response_content_language { get; set; }

		// Specified the Content-Type response header
	    [CParam(ParamType = "query", ParamName = "response_content_type")]
	    public string response_content_type { get; set; }
		// Specified the Expires response header
	    [CParam(ParamType = "query", ParamName = "response_expires")]
	    public string response_expires { get; set; }
		// Check whether the ETag matches
	    [CParam(ParamType = "header", ParamName = "If_Match")]
	    public string If_Match { get; set; }
		// Check whether the object has been modified
	    [CParam(ParamType = "header", ParamName = "If_Modified_Since")]
	    public string If_Modified_Since { get; set; }
		// Check whether the ETag does not match
	    [CParam(ParamType = "header", ParamName = "If_None_Match")]
	    public string If_None_Match { get; set; }
		// Check whether the object has not been modified
	    [CParam(ParamType = "header", ParamName = "If_Unmodified_Since")]
	    public string If_Unmodified_Since { get; set; }
		// Specified range of the object
	    [CParam(ParamType = "header", ParamName = "Range")]
	    public string Range { get; set; }

		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
	    public string X_QS_Encryption_Customer_Algorithm { get; set; }
		// Encryption key of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key")]
	    public string X_QS_Encryption_Customer_Key { get; set; }
		// MD5sum of encryption key
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key_MD5")]
	    public string X_QS_Encryption_Customer_Key_MD5 { get; set; }
	}
	public class CGetObjectOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Object content length
	    [CParam(ParamType = "header", ParamName = "Content_Length")]
	    public long Content_Length { get; set; }
		// Range of response data content
	    [CParam(ParamType = "header", ParamName = "Content_Range")]
	    public string Content_Range { get; set; }
		// MD5sum of the object
	    [CParam(ParamType = "header", ParamName = "ETag")]
	    public string ETag { get; set; }
		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
	    public string X_QS_Encryption_Customer_Algorithm { get; set; }

        // The response body
		[CParam(ParamType = "body", ParamName = "Body")]
		public StreamReader Body { get; set; }
	}
    public class CHeadObjectInput : ICustomType
	{
		public CHeadObjectInput()
		{
		    this.If_Match = "";
		    this.If_Modified_Since = "";
            this.If_None_Match = "";
            this.If_Unmodified_Since = "";
            this.X_QS_Encryption_Customer_Algorithm = "";
            this.X_QS_Encryption_Customer_Key = "";
            this.X_QS_Encryption_Customer_Key_MD5 = "";	
		}
		// Check whether the ETag matches
	    [CParam(ParamType = "header", ParamName = "If_Match")]
	    public string If_Match { get; set; }
		// Check whether the object has been modified
	    [CParam(ParamType = "header", ParamName = "If_Modified_Since")]
	    public string If_Modified_Since { get; set; }
		// Check whether the ETag does not match
	    [CParam(ParamType = "header", ParamName = "If_None_Match")]
	    public string If_None_Match { get; set; }
		// Check whether the object has not been modified
	    [CParam(ParamType = "header", ParamName = "If_Unmodified_Since")]
	    public string If_Unmodified_Since { get; set; }
		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
	    public string X_QS_Encryption_Customer_Algorithm { get; set; }
		// Encryption key of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key")]
	    public string X_QS_Encryption_Customer_Key { get; set; }
		// MD5sum of encryption key
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key_MD5")]
	    public string X_QS_Encryption_Customer_Key_MD5 { get; set; }
	}
	public class CHeadObjectOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Object content length
	    [CParam(ParamType = "header", ParamName = "Content_Length")]
	    public long Content_Length { get; set; }
		// Object content type
	    [CParam(ParamType = "header", ParamName = "Content_Type")]
	    public string Content_Type { get; set; }
		// MD5sum of the object
	    [CParam(ParamType = "header", ParamName = "ETag")]
	    public string ETag { get; set; }
	    [CParam(ParamType = "header", ParamName = "Last_Modified")]
	    public string Last_Modified { get; set; }
		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
	    public string X_QS_Encryption_Customer_Algorithm { get; set; }
	}
    public class CInitiateMultipartUploadInput : ICustomType
	{
		public CInitiateMultipartUploadInput()
		{
            this.Content_Type = "";
            this.X_QS_Encryption_Customer_Algorithm = "";
            this.X_QS_Encryption_Customer_Key = "";
            this.X_QS_Encryption_Customer_Key_MD5 = "";
		}
		// Object content type
	    [CParam(ParamType = "header", ParamName = "Content_Type")]
	    public string Content_Type { get; set; }
		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
	    public string X_QS_Encryption_Customer_Algorithm { get; set; }
		// Encryption key of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key")]
	    public string X_QS_Encryption_Customer_Key { get; set; }
		// MD5sum of encryption key
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key_MD5")]
	    public string X_QS_Encryption_Customer_Key_MD5 { get; set; }
	}
	public class CInitiateMultipartUploadOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Bucket name
	    [CParam(ParamType = "query", ParamName = "bucket")]
	    public string bucket { get; set; }
		// Object key
	    [CParam(ParamType = "query", ParamName = "key")]
	    public string key { get; set; }
		// Object multipart upload ID
	    [CParam(ParamType = "query", ParamName = "upload_id")]
	    public string upload_id { get; set; }
		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
	    public string X_QS_Encryption_Customer_Algorithm { get; set; }
	}
    public class CListMultipartInput : ICustomType
	{
		public CListMultipartInput()
		{
            this.limit = 0;
            this.part_number_marker = 0;
            this.upload_id = "";
		}
		// Limit results count
	    [CParam(ParamType = "query", ParamName = "limit")]
	    public long limit { get; set; }
		// Object multipart upload part number
	    [CParam(ParamType = "query", ParamName = "part_number_marker")]
	    public long part_number_marker { get; set; }
		// Object multipart upload ID        // Required
	    [CParam(ParamType = "query", ParamName = "upload_id")]
	    public string upload_id { get; set; }
	}
	public class CListMultipartOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Object multipart count
	    [CParam(ParamType = "query", ParamName = "count")]
	    public long count { get; set; }
		// Object parts
	    [CParam(ParamType = "query", ParamName = "object_parts")]
	    public CObjectPartType[] object_parts { get; set; }
	}
    public class COptionsObjectInput : ICustomType
	{
		public COptionsObjectInput()
		{
		    this.Access_Control_Request_Headers = "";
		    this.Access_Control_Request_Method = "";
		    this.Origin = "";
		}
		// Request headers
	    [CParam(ParamType = "header", ParamName = "Access_Control_Request_Headers")]
	    public string Access_Control_Request_Headers { get; set; }
		// Request method        // Required
	    [CParam(ParamType = "header", ParamName = "Access_Control_Request_Method")]
	    public string Access_Control_Request_Method { get; set; }
		// Request origin        // Required
	    [CParam(ParamType = "header", ParamName = "Origin")]
	    public string Origin { get; set; }
	}
	public class COptionsObjectOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Allowed headers
	    [CParam(ParamType = "header", ParamName = "Access_Control_Allow_Headers")]
	    public string Access_Control_Allow_Headers { get; set; }
		// Allowed methods
	    [CParam(ParamType = "header", ParamName = "Access_Control_Allow_Methods")]
	    public string Access_Control_Allow_Methods { get; set; }
		// Allowed origin
	    [CParam(ParamType = "header", ParamName = "Access_Control_Allow_Origin")]
	    public string Access_Control_Allow_Origin { get; set; }
		// Expose headers
	    [CParam(ParamType = "header", ParamName = "Access_Control_Expose_Headers")]
	    public string Access_Control_Expose_Headers { get; set; }
		// Max age
	    [CParam(ParamType = "header", ParamName = "Access_Control_Max_Age")]
	    public string Access_Control_Max_Age { get; set; }
	}
    public class CPutObjectInput : ICustomType
	{
		public CPutObjectInput()
		{
		    this.Content_Length = 0;
		    this.Content_MD5 = "";
		    this.Content_Type = "";
		    this.Expect = "";
		    this.X_QS_Copy_Source = "";
		    this.X_QS_Copy_Source_Encryption_Customer_Algorithm = "";
		    this.X_QS_Copy_Source_Encryption_Customer_Key = "";
		    this.X_QS_Copy_Source_Encryption_Customer_Key_MD5 = "";
		    this.X_QS_Copy_Source_If_Match = "";
		    this.X_QS_Copy_Source_If_Modified_Since = "";
		    this.X_QS_Copy_Source_If_None_Match = "";
		    this.X_QS_Copy_Source_If_Unmodified_Since = "";
		    this.X_QS_Encryption_Customer_Algorithm = "";
		    this.X_QS_Encryption_Customer_Key = "";
		    this.X_QS_Encryption_Customer_Key_MD5 = "";
		    this.X_QS_Fetch_If_Unmodified_Since = "";
		    this.X_QS_Fetch_Source = "";
		    this.X_QS_Move_Source = "";
			this.Body = null;
		}
		// Object content size
        // Required
	    [CParam(ParamType = "header", ParamName = "Content_Length")]
	    public long Content_Length { get; set; }
		// Object MD5sum
	    [CParam(ParamType = "header", ParamName = "Content_MD5")]
	    public string Content_MD5 { get; set; }
		// Object content type
	    [CParam(ParamType = "header", ParamName = "Content_Type")]
	    public string Content_Type { get; set; }
		// Used to indicate that particular server behaviors are required by the client
	    [CParam(ParamType = "header", ParamName = "Expect")]
	    public string Expect { get; set; }
		// Copy source, format (/<bucket-name>/<object-key>)
	    [CParam(ParamType = "header", ParamName = "X_QS_Copy_Source")]
	    public string X_QS_Copy_Source { get; set; }
		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Copy_Source_Encryption_Customer_Algorithm")]
	    public string X_QS_Copy_Source_Encryption_Customer_Algorithm { get; set; }
		// Encryption key of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Copy_Source_Encryption_Customer_Key")]
	    public string X_QS_Copy_Source_Encryption_Customer_Key { get; set; }
		// MD5sum of encryption key
	    [CParam(ParamType = "header", ParamName = "X_QS_Copy_Source_Encryption_Customer_Key_MD5")]
	    public string X_QS_Copy_Source_Encryption_Customer_Key_MD5 { get; set; }
		// Check whether the copy source matches
	    [CParam(ParamType = "header", ParamName = "X_QS_Copy_Source_If_Match")]
	    public string X_QS_Copy_Source_If_Match { get; set; }
		// Check whether the copy source has been modified
	    [CParam(ParamType = "header", ParamName = "X_QS_Copy_Source_If_Modified_Since")]
	    public string X_QS_Copy_Source_If_Modified_Since { get; set; }
		// Check whether the copy source does not match
	    [CParam(ParamType = "header", ParamName = "X_QS_Copy_Source_If_None_Match")]
	    public string X_QS_Copy_Source_If_None_Match { get; set; }
		// Check whether the copy source has not been modified
	    [CParam(ParamType = "header", ParamName = "X_QS_Copy_Source_If_Unmodified_Since")]
	    public string X_QS_Copy_Source_If_Unmodified_Since { get; set; }

		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
	    public string X_QS_Encryption_Customer_Algorithm { get; set; }
		// Encryption key of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key")]
	    public string X_QS_Encryption_Customer_Key { get; set; }
		// MD5sum of encryption key
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key_MD5")]
	    public string X_QS_Encryption_Customer_Key_MD5 { get; set; }
		// Check whether fetch target object has not been modified
	    [CParam(ParamType = "header", ParamName = "X_QS_Fetch_If_Unmodified_Since")]
	    public string X_QS_Fetch_If_Unmodified_Since { get; set; }
		// Fetch source, should be a valid url
	    [CParam(ParamType = "header", ParamName = "X_QS_Fetch_Source")]
	    public string X_QS_Fetch_Source { get; set; }
		// Move source, format (/<bucket-name>/<object-key>)
	    [CParam(ParamType = "header", ParamName = "X_QS_Move_Source")]
	    public string X_QS_Move_Source { get; set; }
		// The request body
		[CParam(ParamType = "body", ParamName = "Body")]
		// The request body
		public FileStream Body { get; set; }
	}
	public class CPutObjectOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }

        // MD5sum of the object part
        [CParam(ParamType = "header", ParamName = "ETag")]
        public string ETag { get; set; }

        // Encryption algorithm of the object
        [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
        public string X_QS_Encryption_Customer_Algorithm { get; set; }
	}
    public class CUploadMultipartInput : ICustomType
	{
		public CUploadMultipartInput()
		{
            this.part_number = 0;
            this.upload_id = "";
            this.Content_Length = 0;
		    this.Content_MD5 = "";
		    this.X_QS_Encryption_Customer_Algorithm = "";
		    this.X_QS_Encryption_Customer_Key = "";
		    this.X_QS_Encryption_Customer_Key_MD5 = "";
			this.Body = null;
		}
		// Object multipart upload part number        // Required
	    [CParam(ParamType = "query", ParamName = "part_number")]
	    public long part_number { get; set; }
		// Object multipart upload ID        // Required
	    [CParam(ParamType = "query", ParamName = "upload_id")]
	    public string upload_id { get; set; }
		// Object multipart content length
	    [CParam(ParamType = "header", ParamName = "Content_Length")]
	    public long Content_Length { get; set; }
		// Object multipart content MD5sum
	    [CParam(ParamType = "header", ParamName = "Content_MD5")]
	    public string Content_MD5 { get; set; }
		// Encryption algorithm of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
	    public string X_QS_Encryption_Customer_Algorithm { get; set; }
		// Encryption key of the object
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key")]
	    public string X_QS_Encryption_Customer_Key { get; set; }
		// MD5sum of encryption key
	    [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Key_MD5")]
	    public string X_QS_Encryption_Customer_Key_MD5 { get; set; }
		// The request body
		[CParam(ParamType = "body", ParamName = "Body")]
		// The request body
		public FileStream Body { get; set; }
	}
	public class CUploadMultipartOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }

        // MD5sum of the object part
        [CParam(ParamType = "header", ParamName = "ETag")]
        public string ETag { get; set; }

        // Encryption algorithm of the object
        [CParam(ParamType = "header", ParamName = "X_QS_Encryption_Customer_Algorithm")]
        public string X_QS_Encryption_Customer_Algorithm { get; set; }
	}
	public class CBucket 
	{
		public CConfig Config { get; set; }
        public string Zone { get; set; }
        public string BucketName { get; set; }
		public CBucket(CConfig Config, string BucketName) 
		{
			this.Config = Config;
			this.BucketName = BucketName;
			this.Zone = "";
		}
		public CBucket(CConfig Config, string BucketName, string Zone) 
		{
			this.Config = Config;
			this.BucketName = BucketName;
			this.Zone = Zone;
		}
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/delete.html
        */
        public CDeleteBucketOutput Delete()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "DeleteBucket");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "DELETE");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CDeleteBucketOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/cors/delete_cors.html
        */
        public CDeleteBucketCORSOutput DeleteCORS()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?cors";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "DeleteBucketCORS");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "DELETE");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CDeleteBucketCORSOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/external_mirror/delete_external_mirror.html
        */
        public CDeleteBucketExternalMirrorOutput DeleteExternalMirror()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?mirror";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "DeleteBucketExternalMirror");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "DELETE");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CDeleteBucketExternalMirrorOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/policy/delete_policy.html
        */
        public CDeleteBucketPolicyOutput DeletePolicy()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?policy";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "DeleteBucketPolicy");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "DELETE");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CDeleteBucketPolicyOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/delete_multiple.html
        */
        public CDeleteMultipleObjectsOutput DeleteMultipleObjects(CDeleteMultipleObjectsInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?delete";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "DeleteMultipleObjects");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "POST");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CDeleteMultipleObjectsOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/get_acl.html
        */
        public CGetBucketACLOutput GetACL()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?acl";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "GetBucketACL");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "GET");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CGetBucketACLOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/cors/get_cors.html
        */
        public CGetBucketCORSOutput GetCORS()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?cors";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "GetBucketCORS");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "GET");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CGetBucketCORSOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/external_mirror/get_external_mirror.html
        */
        public CGetBucketExternalMirrorOutput GetExternalMirror()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?mirror";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "GetBucketExternalMirror");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "GET");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CGetBucketExternalMirrorOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://https://docs.qingcloud.com/qingstor/api/bucket/policy/get_policy.html
        */
        public CGetBucketPolicyOutput GetPolicy()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?policy";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "GetBucketPolicy");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "GET");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CGetBucketPolicyOutput>(strResponse);
		    }
		    return null;  
        }

        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/get_stats.html
        */
        public CGetBucketStatisticsOutput GetStatistics()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?stats";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "GetBucketStatistics");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "GET");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CGetBucketStatisticsOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/head.html
        */
        public CHeadBucketOutput Head()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "HeadBucket");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "HEAD");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CHeadBucketOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/list_multipart_uploads.html
        */
        public CListMultipartUploadsOutput ListMultipartUploads(CListMultipartUploadsInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?uploads";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "ListMultipartUploads");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "GET");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CListMultipartUploadsOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/get.html
        */
        public CListObjectsOutput ListObjects(CListObjectsInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "ListObjects");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "GET");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CListObjectsOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/put.html
        */
        public CPutBucketOutput Put()
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "PutBucket");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "PUT");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {                Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CPutBucketOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/put_acl.html
        */
        public CPutBucketACLOutput PutACL(CPutBucketACLInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?acl";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "PutBucketACL");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "PUT");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CPutBucketACLOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/cors/put_cors.html
        */
        public CPutBucketCORSOutput PutCORS(CPutBucketCORSInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?cors";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "PutBucketCORS");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "PUT");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CPutBucketCORSOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/external_mirror/put_external_mirror.html
        */
        public CPutBucketExternalMirrorOutput PutExternalMirror(CPutBucketExternalMirrorInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?mirror";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "PutBucketExternalMirror");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "PUT");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CPutBucketExternalMirrorOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/bucket/policy/put_policy.html
        */
        public CPutBucketPolicyOutput PutPolicy(CPutBucketPolicyInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>?policy";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "PutBucketPolicy");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "PUT");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CPutBucketPolicyOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/abort_multipart_upload.html
        */
        public CAbortMultipartUploadOutput AbortMultipartUpload(string ObjectName, CAbortMultipartUploadInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "AbortMultipartUpload");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "DELETE");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CAbortMultipartUploadOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/complete_multipart_upload.html
        */
        public CCompleteMultipartUploadOutput CompleteMultipartUpload(string ObjectName,                                                                        CCompleteMultipartUploadInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "CompleteMultipartUpload");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "POST");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CCompleteMultipartUploadOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/delete.html
        */
        public CDeleteObjectOutput DeleteObject(string ObjectName)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "DeleteObject");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "DELETE");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, null);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CDeleteObjectOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/get.html
        */
        public CGetObjectOutput GetObject(string ObjectName, CGetObjectInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "GetObject");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "GET");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);

            Object ObjOutput = null;
            string strResponse = CRequest.GetInstance().Request(dictInput, InputParam, ref ObjOutput);
            JavaScriptSerializer Serializer = new JavaScriptSerializer();
            if (Serializer != null)
            {
                Serializer.MaxJsonLength = Int32.MaxValue;
                CGetObjectOutput GetObjOutput = Serializer.Deserialize<CGetObjectOutput>(strResponse);
                GetObjOutput.Body = ObjOutput as StreamReader;
                return GetObjOutput;
            }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/head.html
        */
        public CHeadObjectOutput HeadObject(string ObjectName, CHeadObjectInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "HeadObject");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "HEAD");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CHeadObjectOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/initiate_multipart_upload.html
        */
        public CInitiateMultipartUploadOutput InitiateMultipartUpload(string ObjectName, CInitiateMultipartUploadInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>?uploads";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "InitiateMultipartUpload");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "POST");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CInitiateMultipartUploadOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/list_multipart.html
        */
        public CListMultipartOutput ListMultipart(string ObjectName, CListMultipartInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "ListMultipart");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "GET");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CListMultipartOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/options.html
        */
        public COptionsObjectOutput OptionsObject(string ObjectName, COptionsObjectInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "OptionsObject");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "OPTIONS");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<COptionsObjectOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/put.html
        */
        public CPutObjectOutput PutObject(string ObjectName, CPutObjectInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "PutObject");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "PUT");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CPutObjectOutput>(strResponse);
		    }
		    return null;  
        }
        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/object/multipart/upload_multipart.html
        */
        public CUploadMultipartOutput UploadMultipart(string ObjectName, CUploadMultipartInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/<bucket-name>/<object-key>";
		    strURIPath = strURIPath.Replace("<bucket-name>", this.BucketName);
            dictInput.Add(ConstDef.REQ_HEADER_BUCKET_NAME, this.BucketName);
		    strURIPath = strURIPath.Replace("<object-key>", ObjectName);
		    dictInput.Add(ConstDef.REQ_HEADER_OBJECT_NAME, ObjectName);
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "UploadMultipart");
		    dictInput.Add(ConstDef.REQ_HEADER_METHOD, "PUT");
		    dictInput.Add(ConstDef.REQ_HEADER_REQUEST_PATH, strURIPath);
		    dictInput.Add(ConstDef.REQ_HEADER_HOST, this.Config.Host);
		    dictInput.Add(ConstDef.REQ_HEADER_PORT, this.Config.Port);
		    dictInput.Add(ConstDef.REQ_HEADER_PROTOCOL, this.Config.Protocol);
		    dictInput.Add(ConstDef.REQ_HEADER_LOG_LEVEL, this.Config.LogLevel);
		    dictInput.Add(ConstDef.REQ_HEADER_CONNECT_RETRY, this.Config.ConnectionRetry);
		    dictInput.Add(ConstDef.REQ_HEADER_ACCESS_KEY_ID, this.Config.AccessKeyID);
		    dictInput.Add(ConstDef.REQ_HEADER_SECRET_ACCESS_KEY, this.Config.SecretAccessKey);
		    string strResponse = CRequest.GetInstance().Request(dictInput, InputParam);
		    JavaScriptSerializer Serializer = new JavaScriptSerializer();
		    if (Serializer != null)
		    {
			    Serializer.MaxJsonLength = Int32.MaxValue;
			    return Serializer.Deserialize<CUploadMultipartOutput>(strResponse);
		    }
		    return null;  
        }
	}
}﻿


























