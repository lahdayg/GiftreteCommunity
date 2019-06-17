using Community.StepDefinitions;
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
    public class Multiplecommunitypage
    {
        public Multiplecommunitypage()


        {
            PageFactory.InitElements(Hooks1.Driver, this);
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
        private IWebElement Sport { get; set; }

        public void Selectsport()

        {
            Sport.SendKeys("Sport");

        }
        [FindsBy(How = How.Name, Using = "location")]
        private IWebElement EnterLocation { get; set; }

        public void Enterlocation()

        {
            EnterLocation.SendKeys("Nigeria");

        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div > div > div > div > div.user-dashboard-tab__content.tab-content.d-flex.justify-content-center.mt--10.width-90.md-width-85.sm-width-100 > div > div > form > div:nth-child(7) > div > div > label")]
        private IWebElement Switch { get; set; }

        public void ClickSwitch()

        {
            Switch.Click();

        }
        [FindsBy(How = How.Id, Using = "files")]
        private IWebElement ChooseFile { get; set; }

        public void ClickChoosefile()

        {
            ChooseFile.SendKeys("C:\\Users\\user\\Desktop\\sport.jpg");

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
