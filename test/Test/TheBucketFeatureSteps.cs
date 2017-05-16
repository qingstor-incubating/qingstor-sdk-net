using System;
using TechTalk.SpecFlow;

namespace QingStor_SDK_CSharp_Test
{
    [Binding]
    public class TheBucketFeatureSteps
    {
        [Given(@"an object created by initiate multipart upload")]
        public void GivenAnObjectCreatedByInitiateMultipartUpload()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"initialize the bucket")]
        public void WhenInitializeTheBucket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"put bucket")]
        public void WhenPutBucket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"put same bucket again")]
        public void WhenPutSameBucketAgain()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"list objects")]
        public void WhenListObjects()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"head bucket")]
        public void WhenHeadBucket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"delete multiple objects:")]
        public void WhenDeleteMultipleObjects(string multilineText)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get bucket statistics")]
        public void WhenGetBucketStatistics()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"delete bucket")]
        public void WhenDeleteBucket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"list multipart uploads")]
        public void WhenListMultipartUploads()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the bucket is initialized")]
        public void ThenTheBucketIsInitialized()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"put bucket status code is (.*)")]
        public void ThenPutBucketStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"put same bucket again status code is (.*)")]
        public void ThenPutSameBucketAgainStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"list objects status code is (.*)")]
        public void ThenListObjectsStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"list objects keys count is (.*)")]
        public void ThenListObjectsKeysCountIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"head bucket status code is (.*)")]
        public void ThenHeadBucketStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"delete multiple objects code is (.*)")]
        public void ThenDeleteMultipleObjectsCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket statistics status code is (.*)")]
        public void ThenGetBucketStatisticsStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket statistics status is ""(.*)""")]
        public void ThenGetBucketStatisticsStatusIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"delete bucket status code is (.*)")]
        public void ThenDeleteBucketStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"list multipart uploads count is (.*)")]
        public void ThenListMultipartUploadsCountIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
