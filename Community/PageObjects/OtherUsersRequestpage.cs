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
    public class OtherUsersRequestpage
    {
        public OtherUsersRequestpage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }
        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement emailaddress { get; set; }

        public void EnterEmailAddress(string myemail)
        {
            emailaddress.SendKeys(myemail);
        }

        [FindsBy(How = How.Id, Using = "user_password")]
        private IWebElement password { get; set; }

        public void Enterpassword(string passwordtext)
        {
            password.SendKeys(passwordtext);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='all-communities']/div[2]/div[3]/div/a")]
        private IWebElement Communitiesasmembers { get; set; }

        public void Clickcommunitiesasmemebers()
        {
            Communitiesasmembers.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='discover']/div[2]/a[1]/div[2]/div")]
        private IWebElement Davidsport { get; set; }

        public void Clickcdavidsport()
        {
            Davidsport.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "a.nav-link:nth-child(6)")]
        private IWebElement invite { get; set; }

        public void ClickInvite()
        {
            invite.Click();
        }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='field1']/div[1]/input")]
        private IWebElement recipientname { get; set; }

        public void EnterRecipientName()
        {
            recipientname.SendKeys("Sumbo");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='field1']/div[2]/input")]
        private IWebElement EmailAddress { get; set; }

        public void Enteremailaddress(string myemail)
        {
            EmailAddress.SendKeys("Sumboodukoya@yahoo.comm");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn_invite']")]
        private IWebElement sendinvite { get; set; }

        public void ClickSendinvite()
        {
            sendinvite.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='invite']/form/div[2]")]
        private IWebElement successmessage { get; set; }

        public bool successMessageIsDisplayed()
        {

            {
                return successmessage.Displayed;
            }










        }




    }   }
