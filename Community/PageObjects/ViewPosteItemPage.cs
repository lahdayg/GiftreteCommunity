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
    public class ViewPosteItemPage
    {
        public ViewPosteItemPage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }
        [FindsBy(How = How.XPath, Using ="//*[@id='discover']/div[2]/a[1]/div[2]/div")]
        private IWebElement DavidSport { get; set; }

        public void Clickdavidsport()
        {
            DavidSport.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='uploadProduct']/div[3]/div/h5")]
        private IWebElement Item { get; set; }

        public bool ItemIsDisplayed()
        {

            {
                return Item.Displayed;
            }



        }
    }
}
