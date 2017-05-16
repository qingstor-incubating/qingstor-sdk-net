using System;
using TechTalk.SpecFlow;
using QingStor_SDK_CSharp.Service;
using QingStor_SDK_CSharp.Common;
using QingStor_SDK_CSharp.Request;

namespace QingStor_SDK_CSharp_Test.Test
{
    [Binding]
    public class TheQingStorServiceSteps
    {
        private CQingStor QingStor;
        private CListBucketsInput Input;

        [When(@"initialize QingStor service")]
        public void WhenInitializeQingStorService()
        {
            CConfig Config = new CConfig("E:\\QingStor\\qingstor-sdk-c#\\Test\\Test\\Config.json");
            QingStor = new CQingStor(Config);
        }
        
        [When(@"list buckets")]
        public void WhenListBuckets()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the QingStor service is initialized")]
        public void ThenTheQingStorServiceIsInitialized()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"list buckets status code is (.*)")]
        public void ThenListBucketsStatusCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
