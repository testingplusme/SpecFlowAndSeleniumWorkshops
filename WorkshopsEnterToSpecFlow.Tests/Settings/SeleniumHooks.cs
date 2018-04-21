using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace WorkshopsEnterToSpecFlow.Tests.Settings
{
    [Binding]
    public sealed class SeleniumHooks
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver=new ChromeDriver();
            ScenarioContext.Current["Driver"] = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
