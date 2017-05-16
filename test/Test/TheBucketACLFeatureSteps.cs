using System;
using TechTalk.SpecFlow;

namespace QingStor_SDK_CSharp_Test.Test
{
    [Binding]
    public class TheBucketACLFeatureSteps
    {
        [When(@"put bucket ACL:")]
        public void WhenPutBucketACL(string multilineText)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get bucket ACL")]
        public void WhenGetBucketACL()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"put bucket ACL status code is (.*)")]
        public void ThenPutBucketACLStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket ACL status code is (.*)")]
        public void ThenGetBucketACLStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket ACL should have grantee name ""(.*)""")]
        public void ThenGetBucketACLShouldHaveGranteeName(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
