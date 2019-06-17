using Community.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Community.PageObjects
{
    public class CommuntyPage
    {
        public CommuntyPage()


        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login { get; set; }

        public void ClickLogin()
        {
            login.Click();
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

        [FindsBy(How = How.Id, Using = "btn_signin")]
        private IWebElement signin { get; set; }

        public void Clicksignin()
        {
            signin.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "a.nav-link:nth-child(3)")]
        private IWebElement community { get; set; }

        public void Clickoncommunity()
        {
            community.Click();
        }

        [FindsBy(How = How.CssSelector, Using = ".add-new")]
        private IWebElement addnew { get; set; }

        public void ClickonAddenew()
        {
            addnew.Click();
        }
        [FindsBy(How = How.Id, Using = "name")]
        private IWebElement Name { get; set; }

        public void Entername(string Nametext)
        {
            Name.SendKeys(Nametext);
        }
        [FindsBy(How = How.Id, Using = "group_description")]
        private IWebElement communitydescription { get; set; }

        public void EnterCommunitydescription(string groupNametext)
        {
            communitydescription.SendKeys(groupNametext);
        }

        [FindsBy(How = How.Id, Using = "multi-select")]
        private IWebElement dropdown { get; set; }

        public void ClickDropdown()

        {
            dropdown.Click();

        }

        [FindsBy(How = How.Name, Using = "group_type_id")]
        private IWebElement charity { get; set; }

        public void SelectCharity()

        {
            charity.SendKeys("charity");

        }
        [FindsBy(How = How.Id, Using = "autocomplete")]
        private IWebElement autocomplete { get; set; }

        public void ClickAutocomplete()

        {
            autocomplete.SendKeys("L");
        }
        [FindsBy(How = How.Name, Using = "location")]
        private IWebElement EnterLocation { get; set; }

        public void Enterlocation()

        {
            EnterLocation.SendKeys("London Uk");

        }
        [FindsBy(How = How.CssSelector, Using = "#content > div > div > div > div > div > div.user-dashboard-tab__content.tab-content.d-flex.justify-content-center.mt--10.width-90.md-width-85.sm-width-100 > div > div > form > div:nth-child(7) > div > div > label")]
        private IWebElement Switch { get; set; }

        public void ClickSwitch()

        {
            Switch.Click();

        }
        [FindsBy(How = How.Id, Using = "files")]
        private IWebElement ChooseFile{ get; set; }

        public void  ClickChoosefile()

        {
            ChooseFile.SendKeys("C:\\Users\\user\\Desktop\\food.jpg");

        }


        [FindsBy(How = How.CssSelector, Using = ".add-p")]
        private IWebElement createcommunity { get; set; }

        public void clickcreatecommunity()

        {

            createcommunity.Click();

        }

        [FindsBy(How = How.CssSelector, Using = ".alert")]
        private IWebElement Alertsuccess { get; set; }

        public bool alertsuccessIsDisplayed()
        {

            {
                return Alertsuccess.Displayed;
            }













        }


    }
}