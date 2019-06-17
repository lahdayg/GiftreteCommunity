using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.PageObjects
{
    public class AssignAnotherAdminPage
    {
        public AssignAnotherAdminPage()
        {
            PageFactory.InitElements(Utilities.Hooks1.Driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div/div/div/div/div[1]/a[2]")]
        private IWebElement members { get; set; }

        public void ClickMembers()
        {
            members.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='dtBasicExample']/tbody/tr[1]/td[3]/a")]
        private IWebElement dropdown{ get; set; }

        public void ClickDropdown()
        {
            dropdown.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='dtBasicExample']/tbody/tr[1]/td[3]/a")]
        private IWebElement MakeAdmin { get; set; }

        public void Clickmakeadmin()
        {
            MakeAdmin.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='dtBasicExample']/thead/tr/th[2]")]
        private IWebElement Status { get; set; }

        public bool statusIsDisplayed()
        {

            {
                return Status.Displayed;
            }


            

        }


    }
}
