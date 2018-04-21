using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace WorkshopsEnterToSpecFlow.Tests.Helpers
{
    public class WaitHelper
    {
        private IWebDriver driver;
        public WaitHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public WebDriverWait Wait()
        {
            return new WebDriverWait(driver,TimeSpan.FromSeconds(10));
        }

        public void WaitForClickable(IWebElement element)
        {
            Wait().Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
