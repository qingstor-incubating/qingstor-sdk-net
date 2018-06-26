using System;
using TechTalk.SpecFlow;

namespace test.Test
{
    [Binding]
    public class TheBucketLifecycleFeatureSteps
    {
        [When(@"put bucket lifecycle:")]
        public void WhenPutBucketLifecycle(string multilineText)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get bucket lifecycle")]
        public void WhenGetBucketLifecycle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"delete bucket lifecycle")]
        public void WhenDeleteBucketLifecycle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"put bucket lifecycle status code is (.*)")]
        public void ThenPutBucketLifecycleStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket lifecycle status code is (.*)")]
        public void ThenGetBucketLifecycleStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket lifecycle should have filter prefix ""(.*)""")]
        public void ThenGetBucketLifecycleShouldHaveFilterPrefix(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"delete bucket lifecycle status code is (.*)")]
        public void ThenDeleteBucketLifecycleStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
