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
using QingStor_SDK_CSharp.Common;
namespace QingStor_SDK_CSharp.Service
{
	public class CACLType : ICustomType
	{
		// Required
	    public CGranteeType grantee { get; set; }
		// Permission for this grantee
		// Permission's available values: READ, WRITE, FULL_CONTROL
		// Required
	    public string permission { get; set; }
	}
	public class CBucketType : ICustomType
	{
		// Created time of the bucket
	    public string created { get; set; }
		// QingCloud Zone ID		
	    public string location { get; set; }
		// Bucket name
	    public string name { get; set; }

		// URL to access the bucket
	    public string url { get; set; }
	}
	public class CConditionType : ICustomType
	{
	    public CIPAddressType ip_address { get; set; }

	    public CIsNullType is_null { get; set; }
	    public CNotIPAddressType not_ip_address { get; set; }
	    public CStringLikeType string_like { get; set; }
	    public CStringNotLikeType string_not_like { get; set; }
	}
	public class CCORSRuleType : ICustomType
	{
		// Allowed headers
	    public string[] allowed_headers { get; set; }
		// Allowed methods        // Required
	    public string[] allowed_methods { get; set; }
		// Allowed origin        // Required
	    public string allowed_origin { get; set; }
		// Expose headers
	    public string[] expose_headers { get; set; }
		// Max age seconds
	    public long max_age_seconds { get; set; }
	}
	public class CGranteeType : ICustomType
	{
		// Grantee user ID
	    public string id { get; set; }
		// Grantee group name
	    public string name { get; set; }
		// Grantee type
		// Type's available values: user, group
		// Required
	    public string type { get; set; }
	}
	public class CIPAddressType : ICustomType
	{
		// Source IP
	    public string[] source_ip { get; set; }
	}
	public class CIsNullType : ICustomType
	{
		// Refer url
	    public bool Referer { get; set; }
	}
	public class CKeyType : ICustomType
	{
		// Object created time
	    public string created { get; set; }
		// Whether this key is encrypted
	    public bool encrypted { get; set; }

		// MD5sum of the object
	    public string etag { get; set; }
		// Object key
	    public string key { get; set; }
		// MIME type of the object
	    public string mime_type { get; set; }
		// Last modified time in unix time format
	    public long modified { get; set; }
		// Object content size
	    public long size { get; set; }
	}
	public class CKeyDeleteErrorType : ICustomType
	{
		// Error code
	    public string code { get; set; }
		// Object key
	    public string key { get; set; }
		// Error message
	    public string message { get; set; }
	}
	public class CNotIPAddressType : ICustomType
	{
		// Source IP
	    public string[] source_ip { get; set; }
	}
	public class CObjectPartType : ICustomType
	{
		// Object part created time
	    public string created { get; set; }
		// MD5sum of the object part
	    public string etag { get; set; }
		// Object part number
        // Required
	    public long part_number { get; set; }
		// Object part size
	    public long size { get; set; }
	}
	public class COwnerType : ICustomType
	{
		// User ID
	    public string id { get; set; }

		// Username
	    public string name { get; set; }
	}
	public class CStatementType : ICustomType
	{
		// QingStor API methods        // Required
	    public string[] action { get; set; }
	    public CConditionType condition { get; set; }
		// Statement effect
		// Effect's available values: allow, deny
		// Required
	    public string effect { get; set; }
		// Bucket policy id, must be unique
        // Required
	    public string id { get; set; }
		// The resources to apply bucket policy
	    public string[] resource { get; set; }
		// The user to apply bucket policy        // Required
	    public string[] user { get; set; }
	}
	public class CStringLikeType : ICustomType
	{
		// Refer url
	    public string[] Referer { get; set; }
	}
	public class CStringNotLikeType : ICustomType
	{
		// Refer url
	    public string[] Referer { get; set; }
	}
	public class CUploadsType : ICustomType
	{
		// Object part created time
	    public string created { get; set; }
		// Object key
	    public string key { get; set; }
		// Object upload id
	    public string upload_id { get; set; }
	}
}

﻿


























