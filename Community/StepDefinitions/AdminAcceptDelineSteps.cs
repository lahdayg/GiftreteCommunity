using Community.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class AdminAcceptDelineSteps
    {
        AdminAcceptDeclinePage AdminAcceptdecline;

        public AdminAcceptDelineSteps()

        {
            AdminAcceptdecline = new AdminAcceptDeclinePage();
        }
        [When(@"i click on David sport")]
        public void WhenIClickOnDavidSport()
        {
            AdminAcceptdecline.ClickDavidsport();
        }
        
        [When(@"i click on dropdown")]
        public void WhenIClickOnDropdown()
        {
            AdminAcceptdecline.Clickdropdown();
        }
        
        [When(@"i click on Disaprove")]
        public void WhenIClickOnDisaprove()
        {
            AdminAcceptdecline.Clickdisaprove();
        }
        
        [Then(@"request should be pending")]
        public void ThenRequestShouldBePending()
        {
            Assert.IsTrue(AdminAcceptdecline.statusIsDisplayed());
        }
    }
}
