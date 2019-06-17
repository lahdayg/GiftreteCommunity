using Community.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class MultipleCommunitySteps
    {
        Multiplecommunitypage MultipleCommunity;

        public MultipleCommunitySteps()
        {
            MultipleCommunity = new Multiplecommunitypage();
        }



        [When(@"i enter community name""(.*)""")]
        public void WhenIEnterCommunityName(string p0)
        {
            MultipleCommunity.Entername("DAVID SPORT");
           
        }

        [When(@"i enter Community description""(.*)""")]
        public void WhenIEnterCommunityDescription(string p0)
        {
            MultipleCommunity.EnterCommunitydescription("KEEPING FIT");
            
        }

        [When(@"i click on community type""(.*)""")]
        public void WhenIClickOnCommunityType(string p0)
        {
            MultipleCommunity.Selectsport();
            
        }

        [When(@"i enter Location""(.*)""")]
        public void WhenIEnterLocation(string p0)
        {
            MultipleCommunity.Enterlocation();
            
        }
        [When(@"i switch to Public status")]
        public void WhenISwitchToPublicStatus()
        {
            MultipleCommunity.ClickSwitch();
        }
        [When(@"i click on choosefile")]
        public void WhenIClickOnChoosefile()
        {
            MultipleCommunity.ClickChoosefile();
        }


        [Then(@"i should have more than one comunity on my account")]
        public void ThenIShouldHaveMoreThanOneComunityOnMyAccount()
        {
            Assert.IsTrue(MultipleCommunity.alertsuccessIsDisplayed());
           
        }
    }
}
