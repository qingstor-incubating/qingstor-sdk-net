using System;
using TechTalk.SpecFlow;

namespace QingStor_SDK_CSharp_Test.Test
{
    [Binding]
    public class TheBucketExternalMirrorFeatureSteps
    {
        [When(@"put bucket external mirror:")]
        public void WhenPutBucketExternalMirror(string multilineText)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get bucket external mirror")]
        public void WhenGetBucketExternalMirror()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"delete bucket external mirror")]
        public void WhenDeleteBucketExternalMirror()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"put bucket external mirror status code is (.*)")]
        public void ThenPutBucketExternalMirrorStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket external mirror status code is (.*)")]
        public void ThenGetBucketExternalMirrorStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get bucket external mirror should have source_site ""(.*)""")]
        public void ThenGetBucketExternalMirrorShouldHaveSource_Site(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"delete bucket external mirror status code is (.*)")]
        public void ThenDeleteBucketExternalMirrorStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
