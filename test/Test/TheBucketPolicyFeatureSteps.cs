using System;
using TechTalk.SpecFlow;

namespace QingStor_SDK_CSharp_Test
{
    [Binding]
    public class TheBucketPolicyFeatureSteps
    {
        [When(@"put bucket policy:")]
        public void WhenPutBucketPolicy(string multilineText)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get bucket policy")]
        public void WhenGetBucketPolicy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"delete bucket policy")]
        public void WhenDeleteBucketPolicy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"put bucket policy status code is (.*)")]
        public void ThenPutBucketPolicyStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket policy status code is (.*)")]
        public void ThenGetBucketPolicyStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket policy should have Referer ""(.*)""")]
        public void ThenGetBucketPolicyShouldHaveReferer(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"delete bucket policy status code is (.*)")]
        public void ThenDeleteBucketPolicyStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
