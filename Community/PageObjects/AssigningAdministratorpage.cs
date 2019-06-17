using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.PageObjects
{
    public class AssigningAdministratorpage
    {
        public AssigningAdministratorpage()
        {
            PageFactory.InitElements(Utilities.Hooks1.Driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "div.card:nth-child(1) > div:nth-child(1) > a:nth-child(4)")]
        private IWebElement Viewcommunities { get; set; }

        public void Clickviewcommunities()
        {
            Viewcommunities.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='discover']/div[2]/a[2]/div[2]/div")]
        private IWebElement bjcharity { get; set; }

        public void ClickBjcharity()
        {
            bjcharity.Click();
        }


        [FindsBy(How = How.CssSelector, Using = "a.nav-link:nth-child(2)")]
        private IWebElement members { get; set; }

        public void ClickMembers()
        {
            members.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='dtBasicExample']/tbody/tr[3]/td[3]/a")]
        private IWebElement dropdown { get; set; }

        public void ClickonDropdown()
        {
            dropdown.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='dtBasicExample']/tbody/tr[3]/td[2]")]
        private IWebElement Makeadmin { get; set; }

        public void Clickonmakeadmin()
        {
            Makeadmin.Click();
        }
        [FindsBy(How = How.ClassName, Using = "odd")]
        private IWebElement AdminStatus { get; set; }

        public bool AdminstatusIsDisplayed()
        {

            {
                return AdminStatus.Displayed;
            }

        }

    }
}
