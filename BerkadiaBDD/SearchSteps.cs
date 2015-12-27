using System;
using TechTalk.SpecFlow;

namespace BerkadiaBDD
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"user enter Destination as ""(.*)""")]
        public void GivenUserEnterDestinationAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"user enter Destination as ""(.*)"" and origin is ""(.*)""")]
        public void GivenUserEnterDestinationAsAndOriginIs(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click on ""(.*)""")]
        public void WhenClickOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Display all matching rides")]
        public void ThenDisplayAllMatchingRides()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"System display ""(.*)""")]
        public void ThenSystemDisplay(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
