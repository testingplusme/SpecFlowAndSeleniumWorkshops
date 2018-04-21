using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WorkshopsEnterToSpecFlow.Tests.Pages;

namespace WorkshopsEnterToSpecFlow.Tests.Steps
{
    public class BaseStep
    {
        protected IWebDriver Driver => (IWebDriver) ScenarioContext.Current["Driver"];
        protected ContactFormPage contactFormPage => new ContactFormPage(Driver);
    }
}