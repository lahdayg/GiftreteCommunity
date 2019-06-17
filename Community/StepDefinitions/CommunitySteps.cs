using Community.PageObjects;
using Community.Utilities;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;


namespace Community.StepDefinitions
{
    [Binding]
    public class CommunitySteps
    {
        CommuntyPage community;

        public CommunitySteps()
       
        {
            community = new CommuntyPage();
            
        }
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks1.Driver.Navigate().GoToUrl("Https://pprod.giftrete.com");
            Hooks1.Driver.Manage().Window.Maximize();
            Hooks1.Driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(180);
        }
        
        [When(@"i click  login")]
        public void WhenIClickLogin()
        {
            
            community.ClickLogin();
        }
        
        [When(@"I enter Email ""email address")]
        public void WhenIEnterEmailEmailAddress()
        {
           
            community.EnterEmailAddress("okunolabola12@gmail.com");
        }
        
        [When(@"i enter password")]
        public void WhenIEnterPassword()
        {
            
            community.Enterpassword("bolaji");
        }
        
        [When(@"i click Signin")]
        public void WhenIClickSignin()
        {
           
            community.Clicksignin();
        }
        
        [When(@"i click on community")]
        public void WhenIClickOnCommunity()
        {
            
            community.Clickoncommunity();
        }
        
        [When(@"i clickon create new")]
        public void WhenIClickonCreateNew()
        {
           
            community.ClickonAddenew();
        }
        
        [When(@"i enter community name")]
        public void WhenIEnterCommunityName()
        {
            
            community.Entername("BJ CHARITY");
        }
        
        [When(@"i enter Community description")]
        public void WhenIEnterCommunityDescription()
        {
            
            community.EnterCommunitydescription("FEEDING THE WIDOW");
        }
        
        [When(@"I click on dropdown")]
        public void WhenIClickOnDropdown()
        {
           
            community.ClickDropdown();
        }
        
        [When(@"i click on community type")]
        public void WhenIClickOnCommunityType()
        {
           
            community.SelectCharity();
        }
        
        [When(@"i click on Location")]
        public void WhenIClickOnLocation()
        {
            
            community.ClickDropdown();
        }
        
        [When(@"i enter Location")]
        public void WhenIEnterLocation()
        {
           
            community.Enterlocation();
        }
        [When(@"i switch to Public")]
        public void WhenISwitchToPublic()
        {
            community.ClickSwitch();
        }

        [When(@"i click choose file")]
        public void WhenIClickChooseFile()
        {
            community.ClickChoosefile();
        }

        [When(@"i click on create Community")]
        public void WhenIClickOnCreateCommunity()
        {
          
            community.clickcreatecommunity();
        }
        
        [Then(@"i should be able to create community")]
        public void ThenIShouldBeAbleToCreateCommunity()
        {
            
            Assert.IsTrue(community.alertsuccessIsDisplayed());
        }
    }
}
