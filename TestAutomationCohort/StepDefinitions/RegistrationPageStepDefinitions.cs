using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationCohort.PageObject;

namespace TestAutomationCohort.StepDefinitions
{
    [Binding]
    public class RegistrationPageStepDefinitions
    {
        RegistrationPage registrationPage;

        public RegistrationPageStepDefinitions() 
        {
            registrationPage= new RegistrationPage();
        }



        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
           registrationPage.ClickOnSignUp ();
        }

        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"I enter email")]
        public void GivenIEnterEmail()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }

        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            registrationPage.ClickSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }
    }
}
