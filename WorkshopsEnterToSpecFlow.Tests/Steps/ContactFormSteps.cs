using NUnit.Framework;
using TechTalk.SpecFlow;

namespace WorkshopsEnterToSpecFlow.Tests.Steps
{
    [Binding]
    public sealed class ContactFormSteps:BaseStep
    {


        [Given(@"I enter to contact form")]
        public void GivenIEnterToContactForm()
        {
            Driver.Navigate().GoToUrl("https://shopforautomation.wordpress.com/contact/");   
        }

        [Given(@"I fill by random data")]
        public void GivenIFillByRandomData()
        {
            contactFormPage.FillContactForm();
        }

        [Then(@"I check message ""(.*)""")]
        public void ThenICheckMessage(string p0)
        {
            var expectedMessage = "MESSAGE SENT (GO BACK)";
            Assert.AreEqual(contactFormPage.ConfirmationMessage.Text, expectedMessage, $"It's looks like that your test has a bug. Test should has value {contactFormPage.ConfirmationMessage.Text} but has {expectedMessage}");
        }

    }
}
