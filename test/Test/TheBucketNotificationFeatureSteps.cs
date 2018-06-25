using System;
using TechTalk.SpecFlow;

namespace test.Test
{
    [Binding]
    public class TheBucketNotificationFeatureSteps
    {
        [When(@"put bucket notification:")]
        public void WhenPutBucketNotification(string multilineText)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get bucket notification")]
        public void WhenGetBucketNotification()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"delete bucket notification")]
        public void WhenDeleteBucketNotification()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"put bucket notification status code is (.*)")]
        public void ThenPutBucketNotificationStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket notification status code is (.*)")]
        public void ThenGetBucketNotificationStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"delete bucket notification status code is (.*)")]
        public void ThenDeleteBucketNotificationStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
