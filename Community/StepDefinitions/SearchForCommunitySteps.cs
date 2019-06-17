using Community.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class SearchForCommunitySteps
    {
        SearchforcommunityPage SearchForCommunity;

       public  SearchForCommunitySteps()
        {
            SearchForCommunity = new SearchforcommunityPage();       
        }

        [When(@"i click on Discover")]
        public void WhenIClickOnDiscover()
        {
            Thread.Sleep(3000);
            SearchForCommunity.Clickdiscover();
        }
        
        [When(@"i enter community Name")]
        public void WhenIEnterCommunityName()
        {
            
            SearchForCommunity.EnterCommunityname();
        }
        
        [When(@"i click on Search")]
        public void WhenIClickOnSearch()
        {
            Thread.Sleep(3000);
            SearchForCommunity.Clicksearch();
        }
        
        [Then(@"i should be able to see the community")]
        public void ThenIShouldBeAbleToSeeTheCommunity()
        {
            
            Assert.IsTrue(SearchForCommunity.DavidSuportIsDisplayed());
        }
    }
}
