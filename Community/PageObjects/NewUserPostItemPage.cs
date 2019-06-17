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
    public class NewUserPostItemPage

    {
        public NewUserPostItemPage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a.nav-link:nth-child(5)")]
        private IWebElement PostItems { get; set; }

        public void Clickpostitems()
        {
            PostItems.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='title']")]
        private IWebElement ItemName { get; set; }

        public void Enteritemname(string itemname)
        {
            ItemName.SendKeys(itemname);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='description']")]
        private IWebElement ItemDescription { get; set; }

        public void Enteritemdescription(string Description)
        {
            ItemDescription.SendKeys(Description);
        }

        
        [FindsBy(How = How.CssSelector, Using = "#uploadProduct > div:nth-child(6) > div > i")]
        private IWebElement multiselect { get; set; }

        public void ClickMultiselect()
        {
            multiselect.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='uploadProduct']/div[4]/div/div[2]/div[7]")]
        private IWebElement item7 { get; set; }

        public void Selectitem7()
        {
            item7.Click();
        }

        [FindsBy(How = How.Id, Using = "type")]
        private IWebElement Wanted { get; set; }

        public void SelectWanted()
        {
            Wanted.Click();
        }
        [FindsBy(How = How.Id, Using = "weight")]
        private IWebElement Weight { get; set; }

        public void EnterWeight()
        {
            Weight.SendKeys("10");
        }

        [FindsBy(How = How.Name, Using = "location")]
        private IWebElement EnterLocation { get; set; }

        public void Enterlocation()

        {
            EnterLocation.SendKeys("London Uk");

        }
        [FindsBy(How = How.Id, Using = "files")]
        private IWebElement ChooseFile { get; set; }

        public void ClickChoosefile()

        {
            ChooseFile.SendKeys("C:\\Users\\user\\Desktop\\Brownbag.jpg");

        }

        [FindsBy(How = How.ClassName, Using  ="add-p")]
        private IWebElement Addproduct { get; set; }

        public void Clickaddproduct()

        {
            Addproduct.Click();

        }

        [FindsBy(How = How.XPath, Using = "//*[@id='by - friends']/center/div/strong")]
        private IWebElement Succesfully { get; set; }

        public bool SucesfullyIsDisplayed()

        {
            {
                return Succesfully.Displayed;

            }



        }


    }
}