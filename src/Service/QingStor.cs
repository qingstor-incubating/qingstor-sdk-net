// +-------------------------------------------------------------------------
// | Copyright (C) 2016 Yunify, Inc.
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
using QingStor_SDK_CSharp.Common;
using QingStor_SDK_CSharp.Request;
// QingStorService: QingStor provides low-cost and reliable online storage service with unlimited storage space, high read and write performance, high reliability and data safety, fine-grained access control, and easy to use API.
namespace QingStor_SDK_CSharp.Service
{
    public class CListBucketsInput : ICustomType
	{
		public CListBucketsInput()
		{
		    this.Location = "";
		}
		// Limits results to buckets that in the location
	    [CParam(ParamType = "header", ParamName = "Location")]
	    public string Location { get; set; }
	}
	public class CListBucketsOutput : ICustomType
	{
		public int StatusCode { get; set; }
		public string RequestID { get; set; }
		public string ErrorCode { get; set; }
		// Buckets information
	    [CParam(ParamType = "query", ParamName = "buckets")]
	    public CBucketType[] buckets { get; set; }
		// Bucket count
	    [CParam(ParamType = "query", ParamName = "count")]
	    public long count { get; set; }
	}
	public class CQingStor
	{
		public CConfig Config { get; set; }
        public string Zone { get; set; }
		public CQingStor(CConfig Config)
		{
			this.Config = Config;
			this.Zone = "";
		}
		public CQingStor(CConfig Config, string Zone)
		{
			this.Config = Config;
			this.Zone = Zone;
		}

        /*
         *
         * @param InputParam
         *
         * Documentation URL: https://docs.qingcloud.com/qingstor/api/service/get.html
        */
        public CListBucketsOutput ListBuckets(CListBucketsInput InputParam)
	    {
            Dictionary<Object, Object> dictInput = new Dictionary<Object, Object>();
		    if (dictInput == null)
		    {
			    return null;
		    }
		    string strURIPath = "/";
            dictInput.Add(ConstDef.REQ_HEADER_ZONE, this.Zone);
		    dictInput.Add(ConstDef.OPERATION_ID, "ListBuckets");
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
			    return Serializer.Deserialize<CListBucketsOutput>(strResponse);
		    }
		    return null;
        }

        /*
         *
         * @param BucketName
         * @param Zone
         *
         * Get Bucket
        */
        public CBucket Bucket(string BucketName, string Zone)
        {
            return new CBucket(this.Config, BucketName, Zone);
        }
	}
}﻿

























