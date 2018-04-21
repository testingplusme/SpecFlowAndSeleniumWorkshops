using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using WorkshopsEnterToSpecFlow.Helpers;
using WorkshopsEnterToSpecFlow.Tests.Pages;

namespace WorkshopsEnterToSpecFlow.Tests.TestsCases
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
        //Refactor To POM
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



        [Test]
        public void EnterToContactFormByUrl_PutRandomDataToContactForm_CheckConfirmationMessageAfterFilledContactForm()
        {
            driver.Navigate().GoToUrl("https://shopforautomation.wordpress.com/contact");
            var contactFormPage = new ContactFormPage(driver);
            contactFormPage.Name.SendKeys(RandDataHelper.RandomStringByLength(10));
            contactFormPage.Email.SendKeys(RandDataHelper.RandMail());
            contactFormPage.CommentValue.SendKeys(RandDataHelper.RandomStringByLength(50));
            contactFormPage.SubmitButton.Click();
            var expectedMessage = "MESSAGE SENT (GO BACK)";
            Assert.AreEqual(contactFormPage.ConfirmationMessage.Text, expectedMessage,$"It's looks like that your test has a bug. Test should has value {contactFormPage.ConfirmationMessage.Text} but has {expectedMessage}");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
