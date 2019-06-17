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
  public  class AdminAcceptPage
    {
        public AdminAcceptPage()

        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }

         [FindsBy(How = How.XPath, Using = "//*[@id='dtBasicExample']/tbody/tr[2]/td[3]/div/a[2]")]
        private IWebElement Approve { get; set; }

        public void Clickapprove()
        {
            Approve.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='dtBasicExample']/tbody/tr[2]/td[2]")]
        private IWebElement member { get; set; }

        public bool MemberIsDisplayed()
        {
            return member.Displayed;
        }


    }
}
