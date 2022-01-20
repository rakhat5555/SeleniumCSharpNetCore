using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCoreC
{
    public class Tests
    {

        //Hooks in NUnit

       public IWebDriver Driver;
        [SetUp]
        public void Setup()
        {

             Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            // Open browser
            
            
            //Navigate to site
            Driver.Navigate().GoToUrl("http://eaapp.somee.com");

            //Login
            IWebElement login = Driver.FindElement(By.Id("loginLink"));
            login.Click();

            var userNameInput = Driver.FindElement(By.Id("UserName"));

            Assert.That(userNameInput.Displayed, Is.True);

            userNameInput.SendKeys("admin");

            Driver.FindElement(By.XPath("//input[@id='Password']")).SendKeys("password");

            Driver.FindElement(By.XPath("//input[@value='Log in']")).Submit();

            var linkText = Driver.FindElement(By.XPath("//a[text() = 'Employee Details']"));

            Assert.That(linkText.Displayed, Is.True);
            
            //Driver.Quit();

        }
    }
}