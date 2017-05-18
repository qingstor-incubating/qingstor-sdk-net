# QingStor Service Usage Guide

Import the QingStor and initialize service with a config, and you are ready to use the initialized service. Service only contains one API, and it is "ListBuckets".
To use bucket related APIs, you need to initialize a bucket from service using "Bucket" function.

Each API function take a Input struct and return an Output struct. The Input struct consists of request params, request headers, request elements and request body, and the Output holds the HTTP status code, QingStor request ID, response headers, response elements, response body and error (if error occurred).

You can use a specified version of a service by import a service package with a date suffix.

``` C#
using QingStor_SDK_CSharp.Service;
```

### Code Snippet

Initialize the QingStor service with a configuration

``` C#
CQingStor Service = new CQingStor(Config);
```

List buckets

``` C#
CListBucketsOutput ListBuckets = Service.ListBuckets(null);

// Print the HTTP status code.
// Example: 200
Console.Write(ListBuckets.StatusCode);

// Print the bucket count.
// Example: 5
Console.Write(ListBuckets.count);

// Print the name of first bucket.
// Example: "test-bucket"
Console.Write(ListBuckets.buckets[0].name);
```

Initialize a QingStor bucket

``` C#
CBucket Bucket = Service.Bucket("bucket-name", "zone");
```

List objects in the bucket

``` C#
CListObjectsOutput ListObjectsOutput = Bucket.ListObjects(null);

// Print the HTTP status code.
// Example: 200
Console.Write(ListObjectsOutput.StatusCode);

// Print the key count.
// Example: 7
Console.Write(ListObjectsOutput.keys.Length);
```

Set ACL of the bucket

``` C#
CGranteeType Grantee = new CGranteeType() { id = "usr-id", type = "user" };
CACLType ACL = new CACLType() { grantee = Grantee, permission = "FULL_CONTROL" };
CPutBucketACLInput PutBucketACLInput = new CPutBucketACLInput();
PutBucketACLInput.acl = new CACLType[] { ACL };
CPutBucketACLOutput PutBucketACLOutput = Bucket.PutACL(PutBucketACLInput);

// Print the HTTP status code.
// Example: 200
Console.Write(PutBucketACLOutput.StatusCode);
```

Put object

``` C#
CPutObjectInput PutObjectInput = new CPutObjectInput();
PutObjInput.Body = new FileStream("/tmp/Screenshot.jpg", FileMode.Open);
CPutObjectOutput PutObjectOutput = Bucket.PutObject("Screenshot.jpg", PutObjectInput);
	
// Print the HTTP status code.
// Example: 201
Console.Write(PutObjectOutput.StatusCode);
```

Delete object

``` C#
CDeleteObjectOutput DeleteObjectOutput = BucketObj.DeleteObject("Screenshot.jpg");

// Print the HTTP status code.
// Example: 204
Console.Write(DeleteObjectOutput.StatusCode);
```

Initialize Multipart Upload

``` C#
CInitiateMultipartUploadInput InitInput = new CInitiateMultipartUploadInput();
InitInput.Content_Type = "application/pdf";
CInitiateMultipartUploadOutput InitOutput = Bucket.InitiateMultipartUpload("Test.pdf", InitInput);
			
// Print the HTTP status code.
// Example: 200
Console.Write(InitOutput.StatusCode);

// Print the upload ID.
// Example: "9d37dd6ccee643075ca4e597ad65655c"
Console.Write(InitOutput.upload_id);
```

Upload Multipart

``` C#
CUploadMultipartInput UploadInput1 = new CUploadMultipartInput();
UploadInput1.upload_id = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
UploadInput1.part_number = 1;
UploadInput1.Body = File.Open("D:\\Test1.pdf", FileMode.Open);
CUploadMultipartOutput UploadOutput1 = Bucket.UploadMultipart("Test1.pdf", UploadInput1);
			
// Print the HTTP status code.
// Example: 201
Console.Write(UploadOutput1.StatusCode);

CUploadMultipartInput UploadInput2 = new CUploadMultipartInput();
UploadInput2.upload_id = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
UploadInput2.part_number = 2;
UploadInput2.Body = File.Open("D:\\Test2.pdf", FileMode.Open);
CUploadMultipartOutput UploadOutput2 = Bucket.UploadMultipart("Test2.pdf", UploadInput2);
			
// Print the HTTP status code.
// Example: 201
Console.Write(UploadOutput2.StatusCode);

CUploadMultipartInput UploadInput3 = new CUploadMultipartInput();
UploadInput3.upload_id = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
UploadInput3.part_number = 3;
UploadInput3.Body = File.Open("D:\\Test3.pdf", FileMode.Open);
CUploadMultipartOutput UploadOutput3 = Bucket.UploadMultipart("Test3.pdf", UploadInput3);
			
// Print the HTTP status code.
// Example: 201
Console.Write(UploadOutput3.StatusCode);
```

Complete Multipart Upload

``` C#
CCompleteMultipartUploadInput CompleteInput = new CCompleteMultipartUploadInput();
CompleteInput.upload_id = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
CObjectPartType ObjPart1 = new CObjectPartType();
ObjPart1.part_number = 1;
CObjectPartType ObjPart2 = new CObjectPartType();
ObjPart2.part_number = 2;
CObjectPartType ObjPart3 = new CObjectPartType();
ObjPart3.part_number = 3;
CompleteInput.object_parts = new CObjectPartType[] { ObjPart1, ObjPart2, ObjPart3 };
CCompleteMultipartUploadOutput CompleteOutput = Bucket.CompleteMultipartUpload("Test.pdf", CompleteInput);
			
// Print the HTTP status code.
// Example: 200
Console.Write(CompleteOutput.StatusCode);
```

Abort Multipart Upload

``` C#
CAbortMultipartUploadInput AbortInput = new CAbortMultipartUploadInput();
AbortInput.upload_id = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
CAbortMultipartUploadOutput AbortOutput = Bucket.AbortMultipartUpload("Test.pdf", AbortInput);

// Print the error message.
// Example: QingStor Error: StatusCode 400, Code...
Console.Write(AbortOutput.ErrorCode);
```
