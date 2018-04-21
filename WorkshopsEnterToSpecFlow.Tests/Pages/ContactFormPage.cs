using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using WorkshopsEnterToSpecFlow.Helpers;
using WorkshopsEnterToSpecFlow.Tests.Helpers;

namespace WorkshopsEnterToSpecFlow.Tests.Pages
{
    public class ContactFormPage
    {
        private IWebDriver driver;
        private WaitHelper waitHelper;
        [FindsBy(How = How.CssSelector,Using= "#g2-name")]
        public IWebElement Name { get; set; }
        [FindsBy(How = How.CssSelector,Using= "#g2-email")]
        public IWebElement Email { get; set; }
        [FindsBy(How = How.CssSelector,Using= "#contact-form-comment-g2-comment")]
        public IWebElement CommentValue { get; set; }
        [FindsBy(How = How.CssSelector,Using= ".pushbutton-wide")]
        public IWebElement SubmitButton { get; set; }
        [FindsBy(How = How.CssSelector,Using= "h3")]
        public IWebElement ConfirmationMessage { get; set; }

        public ContactFormPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
            waitHelper=new WaitHelper(driver);
        }

        public void FillContactForm()
        {
            waitHelper.WaitForClickable(Name);
            Name.SendKeys(RandDataHelper.RandomStringByLength(10));
            waitHelper.WaitForClickable(Email);
            Email.SendKeys(RandDataHelper.RandMail());
            waitHelper.WaitForClickable(CommentValue);
            CommentValue.SendKeys(RandDataHelper.RandomStringByLength(50));
            waitHelper.WaitForClickable(SubmitButton);
            SubmitButton.Click();
        }
    }
}
