using Community.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class CommunicationSteps
    {
        CommunicationPage Communication;
        public CommunicationSteps()
        {
            Communication = new CommunicationPage();
        }
        [When(@"i click on  BJCHARITY")]
        public void WhenIClickOnBJCHARITY()
        {
            Communication.ClickBjcharity();
        }
        
        [When(@"i click on Discussion")]
        public void WhenIClickOnDiscussion()
        {
           Communication.Clickdiscussion();
        }
        
        [When(@"i click on create post")]
        public void WhenIClickOnCreatePost()
        {
           Communication.ClickCreatePost();
        }
        
        [When(@"i enter title")]
        public void WhenIEnterTitle()
        {
            Communication.EnterTitile();
        }
        
        [When(@"i write a message")]
        public void WhenIWriteAMessage()
        {
            Communication.Entermessage();
        }
        
        [When(@"i click on choose file to add image")]
        public void WhenIClickOnChooseFileToAddImage()
        {
            
            Communication.ClickChoosefile();
        }
        
        [When(@"i click on publish")]
        public void WhenIClickOnPublish()
        {
            
            Communication.ClickPublishpost();
        }
        
        [Then(@"my post is published")]
        public void ThenMyPostIsPublished()
        {
            Assert.IsTrue(Communication.ContentIsDisplayed());
        }
    }
}
