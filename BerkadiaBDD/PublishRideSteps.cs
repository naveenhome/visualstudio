using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BerkadiaBDD
{
    [Binding]
    public class PublishRideSteps
    {
        Ride ride = new Ride();
        string button;

        [Given(@"Employee enter all data correctly")]
        public void GivenEmployeeEnterAllDataCorrectly()
        {
            //ScenarioContext.Current.Pending();
            ride.Name = "Naveen";
            ride.Email = "naveen.singh@leanpitch.com";
        }
        
        [Given(@"Employee enter name as ""(.*)"", Phone is ""(.*)"" email as ""(.*)"" origin is ""(.*)"" destination is ""(.*)"" and time is ""(.*)""")]
        public void GivenEmployeeEnterNameAsPhoneIsEmailAsOriginIsDestinationIsAndTimeIs(string p0, Decimal p1, string p2, string p3, string p4, string p5)
        {
            //ScenarioContext.Current.Pending();
            ride.Name = p0;
            //ride.Phone = p1;
            ride.Email = p2;
            

        }
        
        [When(@"click on ""(.*)"" button")]
        public void WhenClickOnButton(string p0)
        {
            button = p0;
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"System should display a message ""(.*)""")]
        public void ThenSystemShouldDisplayAMessage(string p0)
        {

            //ScenarioContext.Current.Pending();
            RideBLL rideBLL = new RideBLL();
            Assert.AreEqual(p0, rideBLL.validate(ride));
        }
    }
}
