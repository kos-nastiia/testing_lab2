/*using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace lab_2
{
    public class Tests
    {
        private IWebDriver driver;
        private const string LOGIN = "problem_user";
        private const string PASSWORD = "secret_sauce";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:/Users/kosti/.cache/selenium/chromedriver/win64/118.0.5993.70/chromedriver.exe");
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
        {
            IWebElement userNameElement = driver.FindElement(By.Id("user-name"));
            IWebElement passwordElement = driver.FindElement(By.Id("password"));
            IWebElement loginBtn = driver.FindElement(By.Id("login-button"));

            userNameElement.SendKeys(LOGIN);
            passwordElement.SendKeys(PASSWORD);
            loginBtn.Click();

            IWebElement addToCartBtn = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            addToCartBtn.Click();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/cart.html");

            IWebElement removeBtn = driver.FindElement(By.Id("remove-sauce-labs-backpack"));
            removeBtn.Click();

            Assert.IsFalse(IsElementPresent(By.Id("remove-sauce-labs-backpack")));
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}*/