using Community.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class AdminAcceptSteps
    {
        AdminAcceptPage AdminAccept;
        public AdminAcceptSteps()
        {
            AdminAccept = new AdminAcceptPage();
        }
        [When(@"i click on approve")]
        public void WhenIClickOnApprove()
        {
            AdminAccept.Clickapprove();
        }
        
        [Then(@"status should be member")]
        public void ThenStatusShouldBeMember()
        {
            Assert.IsTrue(AdminAccept.MemberIsDisplayed());
        }
    }
}
