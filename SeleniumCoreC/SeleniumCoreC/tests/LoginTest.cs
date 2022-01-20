using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCoreC.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCoreC.tests
{
    internal class LoginTest {
        IWebDriver webDriver = new ChromeDriver();
        [SetUp] 
        public void SetUp()
        {
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com");
        }
        [Test]
        public void Login()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("admin", "password");

            var linkText = webDriver.FindElement(By.XPath("//a[text() = 'Employee Details']"));

            Assert.That(linkText.Displayed, Is.True);

        }
        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}
