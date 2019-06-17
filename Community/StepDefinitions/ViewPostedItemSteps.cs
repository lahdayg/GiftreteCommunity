using Community.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class ViewPostedItemSteps
    {
        ViewPosteItemPage ViewPosteditem;
        public ViewPostedItemSteps()
        {
            ViewPosteditem = new ViewPosteItemPage();
        }
        [When(@"i click on David Sport")]
        public void WhenIClickOnDavidSport()
        {
            ViewPosteditem.Clickdavidsport();
        }

        [Then(@"i can see items posted")]
        public void ThenICanSeeItemsPosted()
        {
           
            Assert.IsTrue(ViewPosteditem.ItemIsDisplayed());
        }
    }
}
