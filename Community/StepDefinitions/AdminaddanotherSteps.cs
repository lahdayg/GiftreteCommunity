using Community.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class AdminaddanotherSteps
    {
        AssignAnotherAdminPage Adminaddanother;
        public AdminaddanotherSteps()
        {
            Adminaddanother = new AssignAnotherAdminPage();
        }
        [When(@"i click on members")]
        public void WhenIClickOnMembers()
        {
            Thread.Sleep(3000);
            Adminaddanother.Clickmakeadmin();
        }

        [When(@"i click on drop down")]
        public void WhenIClickOnDropDown()
        {
            Adminaddanother.ClickDropdown();
        }
        [When(@"i click on makeadmin")]
        public void WhenIClickOnMakeadmin()
        {
            Adminaddanother.Clickmakeadmin();
        }

        [Then(@"i am able to assign another member as administartor")]
        public void ThenIAmAbleToAssignAnotherMemberAsAdministartor()
        {
            
            Assert.IsTrue(Adminaddanother.statusIsDisplayed());

        }
    }
}
