using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using qa_kurs.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_kurs.Pages
{
    class SummaryPage
    {
        readonly IWebDriver driver;
        public By prdName = By.CssSelector(".cart_description .product-name");


        public SummaryPage(IWebDriver driver)
         {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("cart_summary")));
        
        }
    }



}
