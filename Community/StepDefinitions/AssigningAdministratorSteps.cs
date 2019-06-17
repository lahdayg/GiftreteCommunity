using Community.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class AssigningAdministratorSteps
    {
        AssigningAdministratorpage AssigningAdministrator;
        public AssigningAdministratorSteps()
        {
            AssigningAdministrator = new AssigningAdministratorpage();
           
        }
        [When(@"i click on view communities")]
        public void WhenIClickOnViewCommunities()
        {
            AssigningAdministrator.Clickviewcommunities();
        }
        [When(@"i click on BJ CHARITY")]
        public void WhenIClickOnBJCHARITY()
        {
            AssigningAdministrator.ClickBjcharity();
        }


        [When(@"i click on Members")]
        public void WhenIClickOnMembers()
        {
            AssigningAdministrator.ClickMembers();
            
        }
        [When(@"i click on color dark")]
        public void WhenIClickOnColorDark()
        {
            AssigningAdministrator.ClickonDropdown();
            
        }


        [When(@"i click on make admin")]
        public void WhenIClickOnMakeAdmin()
        {
            AssigningAdministrator.Clickonmakeadmin();
          
        }
        
        [Then(@"i am able to assign administartor")]
        public void ThenIAmAbleToAssignAdministartor()
        {
           
            Assert.IsTrue(AssigningAdministrator.AdminstatusIsDisplayed());

        }
    }
}
