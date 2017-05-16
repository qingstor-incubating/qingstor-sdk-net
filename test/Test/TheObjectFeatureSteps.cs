using System;
using TechTalk.SpecFlow;

namespace QingStor_SDK_CSharp_Test.Test
{
    [Binding]
    public class TheObjectFeatureSteps
    {
        [When(@"put object with key ""(.*)""")]
        public void WhenPutObjectWithKey(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"copy object with key ""(.*)""")]
        public void WhenCopyObjectWithKey(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"move object with key ""(.*)""")]
        public void WhenMoveObjectWithKey(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get object with key ""(.*)""")]
        public void WhenGetObjectWithKey(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get object ""(.*)"" with content type ""(.*)""")]
        public void WhenGetObjectWithContentType(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get object ""(.*)"" with query signature")]
        public void WhenGetObjectWithQuerySignature(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"head object with key ""(.*)""")]
        public void WhenHeadObjectWithKey(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"options object ""(.*)"" with method ""(.*)"" and origin ""(.*)""")]
        public void WhenOptionsObjectWithMethodAndOrigin(string p0, string p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"delete object with key ""(.*)""")]
        public void WhenDeleteObjectWithKey(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"delete the move object with key ""(.*)""")]
        public void WhenDeleteTheMoveObjectWithKey(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"put object status code is (.*)")]
        public void ThenPutObjectStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"copy object status code is (.*)")]
        public void ThenCopyObjectStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"move object status code is (.*)")]
        public void ThenMoveObjectStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get object status code is (.*)")]
        public void ThenGetObjectStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get object content length is (.*)")]
        public void ThenGetObjectContentLengthIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get object content type is ""(.*)""")]
        public void ThenGetObjectContentTypeIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get object with query signature content length is (.*)")]
        public void ThenGetObjectWithQuerySignatureContentLengthIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"head object status code is (.*)")]
        public void ThenHeadObjectStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"options object status code is (.*)")]
        public void ThenOptionsObjectStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"delete object status code is (.*)")]
        public void ThenDeleteObjectStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"delete the move object status code is (.*)")]
        public void ThenDeleteTheMoveObjectStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
