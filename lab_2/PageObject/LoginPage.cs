using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.PageObjects
{
    internal class LoginPage
    {
        private IWebDriver driver;
        private By loginBtn = By.Id("login-button");
        private const string LOGIN = "problem_user";
        private const string PASSWORD = "secret_sauce";

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnLoginButton()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            IWebElement userNameElement = driver.FindElement(By.Id("user-name"));
            IWebElement passwordElement = driver.FindElement(By.Id("password"));

            userNameElement.SendKeys(LOGIN);
            passwordElement.SendKeys(PASSWORD);

            driver.FindElement(loginBtn).Click();
        }
    }
}
