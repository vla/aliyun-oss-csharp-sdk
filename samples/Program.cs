﻿using System;
using System.Text;
#if NETSTANDARD || NET40
using System.Threading.Tasks;
#endif
using Aliyun.OSS.Common;

namespace Aliyun.OSS.Samples
{
    public class Program
    {
        const string bucketName = "<your bucket name>";

        /// <summary>
        /// SDK的示例程序
        /// </summary>
        public static void Main(string[] args)
        {
#if NETSTANDARD
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#endif

            Console.WriteLine("Aliyun SDK for .NET Samples!");

            try
            {
                //CreateBucketSample.CreateBucket(bucketName);

                //ListBucketsSample.ListBuckets();

                //SetBucketCorsSample.SetBucketCors(bucketName);

                //GetBucketCorsSample.GetBucketCors(bucketName);

                //DeleteBucketCorsSample.DeleteBucketCors(bucketName);

                //SetBucketLoggingSample.SetBucketLogging(bucketName);

                //GetBucketLoggingSample.GetBucketLogging(bucketName);

                //DeleteBucketLoggingSample.DeleteBucketLogging(bucketName);

                //SetBucketAclSample.SetBucketAcl(bucketName);

                //GetBucketAclSample.GetBucketAcl(bucketName);

                //SetBucketWebsiteSample.SetBucketWebsite(bucketName);

                //GetBucketWebsiteSample.GetBucketWebsite(bucketName);

                //DeleteBucketWebsiteSample.DeleteBucketWebsite(bucketName);

                //SetBucketRefererSample.SetBucketReferer(bucketName);

                //GetBucketRefererSample.GetBucketReferer(bucketName);

                //SetBucketLifecycleSample.SetBucketLifecycle(bucketName);

                //GetBucketLifecycleSample.GetBucketLifecycle(bucketName);

                //DoesBucketExistSample.DoesBucketExist(bucketName);

                //PutObjectSample.PutObject(bucketName);

                //ResumbaleSample.ResumableUploadObject(bucketName);

                //CreateEmptyFolderSample.CreateEmptyFolder(bucketName);

                //AppendObjectSample.AppendObject(bucketName);

                //ListObjectsSample.ListObjects(bucketName);

                //UrlSignatureSample.UrlSignature(bucketName);

                //GetObjectSample.GetObjects(bucketName);
                //GetObjectByRangeSample.GetObjectPartly(bucketName);

                //DeleteObjectsSample.DeleteObject(bucketName);
                //DeleteObjectsSample.DeleteObjects(bucketName);

                //const string sourceBucket = bucketName;
                //const string sourceKey = "ResumableUploadObject";
                //const string targetBucket = bucketName;
                //const string targetKey = "ResumableUploadObject2";
                //CopyObjectSample.CopyObject(sourceBucket, sourceKey, targetBucket, targetKey);
                //CopyObjectSample.AsyncCopyObject(sourceBucket, sourceKey, targetBucket, targetKey);

                //ResumbaleSample.ResumableCopyObject(sourceBucket, sourceKey, targetBucket, targetKey);

                //ModifyObjectMetaSample.ModifyObjectMeta(bucketName);

                //DoesObjectExistSample.DoesObjectExist(bucketName);

                //MultipartUploadSample.UploadMultipart(bucketName);
                //MultipartUploadSample.AsyncUploadMultipart(bucketName);

                //MultipartUploadSample.UploadMultipartCopy(targetBucket, targetKey, sourceBucket, sourceKey);

                //MultipartUploadSample.AsyncUploadMultipartCopy(targetBucket, targetKey, sourceBucket, sourceKey);

                //MultipartUploadSample.ListMultipartUploads(bucketName);

                //CNameSample.CNameOperation(bucketName);

                //PostPolicySample.GenPostPolicy(bucketName);

                //DeleteBucketSample.DeleteNoEmptyBucket(bucketName);

                //SetObjectAclSample.SetObjectAcl(bucketName);

                //GetObjectAclSample.GetBucketAcl(bucketName);

                //ImageProcessSample.ImageProcess(bucketName);

                //ProgressSample.Progress(bucketName);

                //UploadCallbackSample.UploadCallback(bucketName);
#if NETSTANDARD || NET40
                AsyncDemo().Wait();
#endif  
            }
            catch (OssException ex)
            {
                Console.WriteLine("Failed with error code: {0}; Error info: {1}. \nRequestID:{2}\tHostID:{3}",
                                 ex.ErrorCode, ex.Message, ex.RequestId, ex.HostId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed with error info: {0}", ex.Message);
            }

            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
#if NETSTANDARD || NET40
        static async Task AsyncDemo()
        {
            await AsyncSample.PutObjectFromFile(bucketName);
            await AsyncSample.ListObjectsWithRequest(bucketName);
            await AsyncSample.SimpleListObjects (bucketName);
            await AsyncSample.GetObject(bucketName);
            await AsyncSample.AppendObject(bucketName);
        }
#endif
    }
}