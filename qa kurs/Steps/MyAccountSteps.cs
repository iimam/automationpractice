using qa_kurs.Helpers;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using qa_kurs.Pages;
using NUnit.Framework;

namespace qa_kurs.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        private IWebDriver driver;

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.singIn);
        }

        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTxtInElement(ap.username, TestConstats.Username);
            ut.EnterTxtInElement(ap.password, TestConstats.password);

        }

        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
         {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            string email = ut.GenerateRandomMail();
            ut.EnterTxtInElement(ap.emailfield, email);
            ut.ClickOnElement(ap.createAcc);
        }

        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signInBtn);

        }
        [When(@"user opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage ma = new MyAccountPage(Driver);
            ut.ClickOnElement(ma.wishlist);
        }

        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage ma = new MyAccountPage(Driver);
            Assert.True(ut.ElementDisplayed(ma.logOut), "User is not logged in");
        }

        [Then(@"user can add new wishlist")]
        public void ThenUserCanAddNewWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyWishlistPage ma = new MyWishlistPage(Driver);
            Assert.True(ut.ElementDisplayed(ma.newWish), "User is not on Wishlist");

        }

        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            Utilities ut = new Utilities(Driver);
            SignUpPage sup = new SignUpPage(Driver);
            ut.EnterTxtInElement(sup.FirstName, TestConstats.FirstName);
            ut.EnterTxtInElement(sup.LastName, TestConstats.LastName);
            string fullname = TestConstats.FirstName + " " + TestConstats.LastName;
            ScenarioContext.Current.Add(TestConstats.FullName, fullname);
            ut.EnterTxtInElement(sup.PassWord, TestConstats.password);
            ut.EnterTxtInElement(sup.FirstNameAddress, TestConstats.FirstName);
            ut.EnterTxtInElement(sup.LastNameAdress, TestConstats.LastName);
            ut.EnterTxtInElement(sup.Address, TestConstats.Address);
            ut.EnterTxtInElement(sup.City, TestConstats.City);
            ut.DropdownSelect(sup.State, TestConstats.State);
            ut.EnterTxtInElement(sup.Postalcode, TestConstats.ZipCode);
            ut.EnterTxtInElement(sup.MobilePhone, TestConstats.MobilePhone);
            ut.EnterTxtInElement(sup.AliasAddr, TestConstats.AddressAlias);
        }

        [When(@"sbumits the sign up form")]
        public void WhenSbumitsTheSignUpForm()
        {
            Utilities ut = new Utilities(Driver);
            SignUpPage sup = new SignUpPage(Driver);
            ut.ClickOnElement(sup.RegisterButton);
        }
        [Then(@"User's full name will be displayed")]
        public void ThenUserSFullNameWillBeDisplayed()
        {
            Utilities ut = new Utilities(Driver);
            string fullName = ScenarioContext.Current.Get<string>(TestConstats.FullName);
            Assert.True(ut.TextPresentInElement(fullName).Displayed, "User's full name is not displayed");
        }

    }
}
