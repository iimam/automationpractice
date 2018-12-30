using qa_kurs.Helpers;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using qa_kurs.Pages;

namespace qa_kurs.Steps
{
    [Binding]
    public class FooterSteps : Base
    {
        //private IWebDriver driver;
        
        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string p0)
        {
         //   Utilities ut = new Utilities(Driver);
            FooterPage fp = new FooterPage(Driver);
            fp.ClickOnMyAccountLink(p0);
        }
        
        [Then(@"correct '(.*)' is displayed")]
        public void ThenCorrectIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
