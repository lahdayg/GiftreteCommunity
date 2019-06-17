using Community.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class NewUsersPostItemsSteps
    {
        NewUserPostItemPage NewUserPostItem;
        
        public NewUsersPostItemsSteps()
        {
            NewUserPostItem = new NewUserPostItemPage();
        }
        [When(@"i click Post items")]
        public void WhenIClickPostItems()
        {
            NewUserPostItem.Clickpostitems();
        }
        
        [When(@"i enter item name")]
        public void WhenIEnterItemName()
        {
            NewUserPostItem.Enteritemname("Tote Bag");
        }
        
        [When(@"i enter item description")]
        public void WhenIEnterItemDescription()
        {
            NewUserPostItem.Enteritemdescription("NEW BROWN BAG");
        }
        

        [When(@"i click dropdowm")]
        public void WhenIClickDropdowm()
        {
            NewUserPostItem.ClickMultiselect();
        }


        [When(@"i select item category")]
        public void WhenISelectItemCategory()
        {
           
            NewUserPostItem.Selectitem7();
        }
        
        

        [When(@"i slect item type")]
        public void WhenISlectItemType()
        {
            
            NewUserPostItem.SelectWanted();
        }
        
        [When(@"i enter weight")]
        public void WhenIEnterWeight()
        {
            NewUserPostItem.EnterWeight();
        }
        
        [When(@"i ente location")]
        public void WhenIEnteLocation()
        {
            NewUserPostItem.Enterlocation();
        }

        [When(@"i click on Choose file")]
        public void WhenIClickOnChooseFile()
        {
           NewUserPostItem.ClickChoosefile();
        }


        [When(@"i click on Add product")]
        public void WhenIClickOnAddProduct()
        {
            NewUserPostItem.Clickaddproduct();
        }
    }
}
