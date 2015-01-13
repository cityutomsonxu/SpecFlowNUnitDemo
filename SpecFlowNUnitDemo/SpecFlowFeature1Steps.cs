using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace SpecFlowNUnitDemo
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Assert.AreEqual(1, 1);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Assert.AreEqual(1, 1);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.bing.com/");
            IWebElement searchInput = driver.FindElement(By.Id("sb_form_q"));
            searchInput.SendKeys("Hello World");

            string searchKeyWord = driver.FindElement(By.Id("sb_form_q")).GetAttribute("value");

            //close browser
            driver.Close();

            Assert.AreEqual("Hello World1", searchKeyWord);
        }
    }
}
