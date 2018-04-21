using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using WorkshopsEnterToSpecFlow.Helpers;

namespace WorkshopsEnterToSpecFlow.Tests
{
    [TestFixture]
    class ContactFormTests
    {
        private ChromeDriver driver;

        [SetUp]
        public void Setup()
        {
            driver=new ChromeDriver();
           
        }
        [Test]
        public void EnterToContactFormByUrl_PutRandomDataToContactForm_CheckMessageAfterFillContactFormAndSent()
        {
            //Go to contact form
            driver.Navigate().GoToUrl("https://shopforautomation.wordpress.com/contact");
            //take elements and fill by random data
            var name = driver.FindElementByCssSelector("#g2-name");
            name.SendKeys(RandDataHelper.RandomStringByLength(10));
            var email = driver.FindElementByCssSelector("#g2-email");
            email.SendKeys(RandDataHelper.RandMail());
            var commentValue = driver.FindElementByCssSelector("#contact-form-comment-g2-comment");
            commentValue.SendKeys(RandDataHelper.RandomStringByLength(50));
            var submitButton = driver.FindElementByCssSelector(".pushbutton-wide");
            submitButton.Click();
            var confirmationMessege = driver.FindElementByCssSelector("h3");
            Assert.AreEqual(confirmationMessege.Text, "MESSAGE SENT (GO BACK)", "It's looks like that test has bug");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
