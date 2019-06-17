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
    public class AdminAcceptDeclinePage
    {
        public AdminAcceptDeclinePage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//*[@id='discover']/div[2]/a[1]/div[2]/div")]
        private IWebElement Davidsport{ get; set; }

        public void ClickDavidsport()
        {
            Davidsport.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='dtBasicExample']/tbody/tr[2]/td[3]/a")]
        private IWebElement dropdown { get; set; }

        public void Clickdropdown()
        {
            dropdown.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='dtBasicExample']/tbody/tr[2]/td[3]/div/a[3]")]
        private IWebElement Disaprove { get; set; }

        public void Clickdisaprove()
        {
            Disaprove.Click();
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
