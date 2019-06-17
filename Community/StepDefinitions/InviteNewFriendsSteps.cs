using Community.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class InviteNewFriendsSteps
    {
        invitefriendpage invitefriends;
        public InviteNewFriendsSteps()
        {
            invitefriends = new invitefriendpage();
        }

        
        [When(@"i click on invite")]
        public void WhenIClickOnInvite()
        {
            
            invitefriends.ClickInvite();
             
        }
        [When(@"i click invite friends")]
        public void WhenIClickInviteFriends()
        {
            invitefriends.ClickInviteFriends();
        }

        [When(@"i enter name")]
        public void WhenIEnterName()
        {
            invitefriends.EnterRecipientName();
           
        }

        [When(@"i enter email ""(.*)""")]
        public void WhenIEnterEmail(string p0)
        {
            invitefriends.EnterJohnexamplecom("myemail");
            
        }


        [When(@"i click send invite")]
        public void WhenIClickSendInvite()
        {
            invitefriends.ClickSendinvite();
            
        }
        
        [Then(@"i should be able to to invite friends")]
        public void ThenIShouldBeAbleToToInviteFriends()
        {
            
            Assert.IsFalse(invitefriends.captcharequiredIsDisplayed());
        }
    }
}
