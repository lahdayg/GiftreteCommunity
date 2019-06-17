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
    public class SearchforcommunityPage
    {
        public SearchforcommunityPage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div > div > div > div > ul > a:nth-child(3)")]
        private IWebElement Discover { get; set; }

        public void Clickdiscover()
        {
            Discover.Click();
        }

        [FindsBy(How = How.Id, Using = "search")]
        private IWebElement searchcommunity { get; set; }

        public void EnterCommunityname()
        {
            searchcommunity.SendKeys("Bj Helping Hands");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchcommunities']/button/i")]
        private IWebElement Search { get; set; }

        public void Clicksearch()
        {
            Search.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='discover']/div[2]/table/tbody/tr/td[2]")]
        private IWebElement Davidsport { get; set; }

        public bool DavidSuportIsDisplayed()
        {

            {
                return Davidsport.Displayed;
            }
        }



    }
}
