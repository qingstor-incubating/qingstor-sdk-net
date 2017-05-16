using System;
using TechTalk.SpecFlow;

namespace QingStor_SDK_CSharp_Test
{
    [Binding]
    public class TheBucketCORSFeatureSteps
    {
        [When(@"put bucket CORS:")]
        public void WhenPutBucketCORS(string multilineText)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get bucket CORS")]
        public void WhenGetBucketCORS()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"delete bucket CORS")]
        public void WhenDeleteBucketCORS()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"put bucket CORS status code is (.*)")]
        public void ThenPutBucketCORSStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket CORS status code is (.*)")]
        public void ThenGetBucketCORSStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket CORS should have allowed origin ""(.*)""")]
        public void ThenGetBucketCORSShouldHaveAllowedOrigin(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"delete bucket CORS status code is (.*)")]
        public void ThenDeleteBucketCORSStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
