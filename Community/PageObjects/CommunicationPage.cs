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
    public class CommunicationPage
    {
        public CommunicationPage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='discover']/div[2]/a[2]/div[2]/div")]
        private IWebElement Bjcharity { get; set; }

        public void ClickBjcharity()
        {
            Bjcharity.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div/div/div/div/div[1]/a[4]")]
        private IWebElement Discussion { get; set; }

        public void Clickdiscussion()
        {
            Discussion.Click();
        }
        [FindsBy(How = How.CssSelector, Using = "#toggle-create-post > a")]
        private IWebElement Createpost { get; set; }

        public void ClickCreatePost()
        {
            Createpost.Click();
        }

        [FindsBy(How = How.Id, Using = "subject")]
        private IWebElement title { get; set; }

        public void EnterTitile()
        {
            title.SendKeys("Feeding");
        }
        [FindsBy(How = How.Id, Using = "description")]
        private IWebElement Message { get; set; }

        public void Entermessage()
        {
            Message.SendKeys("I will be feeding the Widows in church on Esater Sunday. Please let me know if you are available. Time- 2.00pm");
        }
        [FindsBy(How = How.ClassName, Using ="btn-upld")]
        private IWebElement Choosefile { get; set; }

        public void ClickChoosefile()
        {
            Choosefile.SendKeys("C:\\Users\\user\\Desktop\\buffet.jpg");
        }

        [FindsBy(How = How.CssSelector, Using = "input.add-p")]
        private IWebElement publishhpost{ get; set; }

        public void ClickPublishpost()
        {
            publishhpost.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div/div/div/div")]
        private IWebElement content { get; set; }

        public bool ContentIsDisplayed()
        {

            {
                return content.Displayed;
            }




        }




    }

}