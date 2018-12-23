using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_kurs.Pages
{
    class PDPPage
    {
        readonly IWebDriver driver;

        public By pdDialog = By.ClassName("primary_block");
        public By addToCart = By.Id("add_to_cart");
        public By productName = By.XPath("//h1[@itemprop='name']");
        public By quantity = By.Id("quantity_wanted");

        public PDPPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(pdDialog));
        }      

    }
}
