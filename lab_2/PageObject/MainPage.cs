using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.PageObjects
{
    internal class MainPage
    {
        private IWebDriver driver;
        private By addToCartBtn = By.ClassName("btn_inventory");
        private By cartBtn = By.ClassName("shopping_cart_link");

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnAddToCart()
        {
            driver.FindElement(addToCartBtn).Click();
        }

        public void GoToCart()
        {
            driver.FindElement(cartBtn).Click();
        }
    }
}
