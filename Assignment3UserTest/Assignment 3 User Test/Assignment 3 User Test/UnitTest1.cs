using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment_3_User_Test
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly string DriverDirectory = "C:\\webdrivers";

        private const string festsang = "vi sejler op af Âen, vi sejler ned af igen. Det var vel nok en dejlig sang, den mÂ vi ha endnu engang, og";

        private static IWebDriver driver;

        //string url = "http://127.0.0.1:5500/index.html";
        string url = "https://niemannassignment3.azurewebsites.net/";

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            driver = new FirefoxDriver(DriverDirectory);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            driver.Dispose();
        }

        [TestMethod]
        public void OpAf≈enTreGange()
        {
            driver.Navigate().GoToUrl(url);
            Assert.AreEqual("Assignment 3", driver.Title);

            IWebElement inputMessage = driver.FindElement(By.Id("message"));
            IWebElement inputTimes = driver.FindElement(By.Id("times"));
            IWebElement executeButton = driver.FindElement(By.Id("execute"));
            IWebElement resultMessage = driver.FindElement(By.Id("result"));

            inputMessage.SendKeys(festsang);
            inputTimes.SendKeys("3");
            executeButton.Click();
            Assert.AreEqual(festsang + " " + festsang + " " + festsang, resultMessage.Text);
        }

        [TestMethod]
        public void OpAf≈enNulGange()
        {
            driver.Navigate().GoToUrl(url);
            Assert.AreEqual("Assignment 3", driver.Title);

            IWebElement inputMessage = driver.FindElement(By.Id("message"));
            IWebElement inputTimes = driver.FindElement(By.Id("times"));
            IWebElement executeButton = driver.FindElement(By.Id("execute"));
            IWebElement resultMessage = driver.FindElement(By.Id("result"));

            inputMessage.SendKeys(festsang);
            inputTimes.SendKeys("0");
            executeButton.Click();
            Assert.AreEqual("", resultMessage.Text);
        }

        [TestMethod]
        public void IngenSangTreGange()
        {
            driver.Navigate().GoToUrl(url);
            Assert.AreEqual("Assignment 3", driver.Title);

            IWebElement inputMessage = driver.FindElement(By.Id("message"));
            IWebElement inputTimes = driver.FindElement(By.Id("times"));
            IWebElement executeButton = driver.FindElement(By.Id("execute"));
            IWebElement resultMessage = driver.FindElement(By.Id("result"));

            inputMessage.SendKeys("");
            inputTimes.SendKeys("3");
            executeButton.Click();
            Assert.AreEqual("null" + " " + "null" + " " + "null", resultMessage.Text);
        }

        [TestMethod]
        public void IngenSangNulGange()
        {
            driver.Navigate().GoToUrl(url);
            Assert.AreEqual("Assignment 3", driver.Title);

            IWebElement inputMessage = driver.FindElement(By.Id("message"));
            IWebElement inputTimes = driver.FindElement(By.Id("times"));
            IWebElement executeButton = driver.FindElement(By.Id("execute"));
            IWebElement resultMessage = driver.FindElement(By.Id("result"));

            inputMessage.SendKeys("");
            inputTimes.SendKeys("0");
            executeButton.Click();
            Assert.AreEqual("", resultMessage.Text);
        }
    }
}