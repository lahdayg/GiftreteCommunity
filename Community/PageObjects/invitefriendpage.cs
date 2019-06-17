using Community.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.PageObjects
{
    public class invitefriendpage
    {
        public invitefriendpage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }
        

        [FindsBy(How = How.CssSelector, Using = "#drop-friend > a:nth-child(1)")]
        private IWebElement invite { get; set; }

        public void ClickInvite()
        {
            invite.Click();
        }
        [FindsBy(How = How.CssSelector, Using = "#show-friend > li:nth-child(1) > a:nth-child(1)")]
        private IWebElement invitefriends { get; set; }

        public void ClickInviteFriends()
        {
            invitefriends.Click();
        }

        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @placeholder='Enter recipient name']")]
        private IWebElement recipientname { get; set; }

        public void EnterRecipientName()
        {
            recipientname.SendKeys("Sumbo");
        }

        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @placeholder='John@example.com']")]
        private IWebElement johnexamplecom { get; set; }

        public void EnterJohnexamplecom(string myemail)
        {
            johnexamplecom.SendKeys("Sumboodukoya@yahoo.com");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn_invite']")]
        private IWebElement sendinvite { get; set; }

        public void ClickSendinvite()
        {
            sendinvite.Click();
        }

        [FindsBy(How = How.Id, Using = "dng_id")]
        private IWebElement CaptchaRequired { get; set; }

        public bool captcharequiredIsDisplayed()
        {
            
            {
                return CaptchaRequired.Displayed;
            }
            


        }
    }
}
