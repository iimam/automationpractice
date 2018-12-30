using NUnit.Framework;
using OpenQA.Selenium;
using qa_kurs.Helpers;
using qa_kurs.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace qa_kurs.Steps
{
    [Binding]
   public class PDPSteps : Base
    {

        
        [Given(@"user opens dresses section")]
        public void GivenUserOpensSection()
        {
          // Utilities ut = new Utilities(driver);
            HomePage hp = new HomePage(Driver);
            IList<IWebElement> dresses = Driver.FindElements(hp.dresses);
            dresses[1].Click();
        }
      
        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            Utilities ut = new Utilities(Driver);
            PLPPage pd = new PLPPage(Driver);
            ut.ClickOnElement(pd.firstdress);
        }
        [Given(@"increases quantity to (.*)")]
        public void GivenIncreasesQuantityTo(string qty)
        {
            Utilities ut =  new Utilities (Driver);
            Driver.SwitchTo().Frame(Driver.FindElement(By.ClassName("fancybox-iframe")));
            PDPPage pd = new PDPPage(Driver);
            Driver.FindElement(pd.quantity).Clear();
            ut.EnterTxtInElement(pd.quantity, qty);
            string productName = ut.ReturnTextFromElement(pd.productName);
            ScenarioContext.Current.Add(TestConstats.ProductName, productName);
           
        }
        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {

            Utilities ut = new Utilities(Driver);
            PDPPage pd = new PDPPage(Driver);
            ut.ClickOnElement(pd.addToCart);
        }

        [Then(@"product is added to cart")]
        public void ThenProductIsAddedToCart()
        {
            Utilities ut = new Utilities(Driver);
            CartOverlayPage cop = new CartOverlayPage(Driver);
            ut.ClickOnElement(cop.ProceedToCheckout);
            SummaryPage sp = new SummaryPage(Driver);
            string productName = ScenarioContext.Current.Get<string>(TestConstats.ProductName);
            Assert.AreEqual(ut.ReturnTextFromElement(sp.prdName), productName, "Expected product is not in the cart");
        }


        }


}
