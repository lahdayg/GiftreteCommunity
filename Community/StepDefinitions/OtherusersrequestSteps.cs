using Community.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class OtherusersrequestSteps
    {
        OtherUsersRequestpage otherusersrequest;
        public OtherusersrequestSteps()
        {
            otherusersrequest = new OtherUsersRequestpage();
        }
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            otherusersrequest.EnterEmailAddress("mobolajiokunola19@gmail.com");
        }
        [When(@"i enter my password")]
        public void WhenIEnterMyPassword()
        {
            otherusersrequest.Enterpassword("bolape");
        }
        [When(@"i click on view communities under members")]
        public void WhenIClickOnViewCommunitiesUnderMembers()
        {
            
            otherusersrequest.Clickcommunitiesasmemebers();
        }
        [When(@"i click on DavidSPORT")]
        public void WhenIClickOnDavidSPORT()
        {
            otherusersrequest.Clickcdavidsport();
        }


        [When(@"i click on Invite")]
        public void WhenIClickOnInvite()
        {
            otherusersrequest.ClickInvite();
        }
        
        [When(@"i enter Name")]
        public void WhenIEnterName()
        {
            otherusersrequest.EnterRecipientName();
        }
        
        [When(@"i enter email Address")]
        public void WhenIEnterEmailAddress()
        {
            otherusersrequest.Enteremailaddress("my email");
        }
        
        [When(@"i click Send Invite")]
        public void WhenIClickSendInvite()
        {
            
           otherusersrequest.ClickSendinvite();
        }
        
        [Then(@"my invite is sent")]
        public void ThenMyInviteIsSent()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(otherusersrequest.successMessageIsDisplayed());
        }
    }
}
