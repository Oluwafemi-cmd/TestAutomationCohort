using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationCohort.Utilities;

namespace TestAutomationCohort.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage() 
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignuP => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        IWebElement SignUpButton => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));
        IWebElement NewArticle => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(3) > li:nth-child(2) > a"));

        public void ClickOnSignUp() 
        {
           SignuP.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys("Goldeboy1");
        }

        public void EnterPassword() 
        {
            Password.SendKeys("Omojesu23");
        }

        public void EnterEmail()
        {
            Email.SendKeys("lountobi@yahoo.com");
        }

        public void ClickSignUpButton() 
        { 
           SignUpButton.Click();
        }

        public void NavigateToWebsite() 
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/");
        }

        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }





    }
}
