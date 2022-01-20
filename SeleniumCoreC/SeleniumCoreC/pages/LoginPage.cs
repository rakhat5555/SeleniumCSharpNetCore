using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCoreC.pages
{
    class LoginPage {
        public LoginPage(IWebDriver driver) {
            Driver = driver;
        }
        public IWebDriver Driver { get; }

        IWebElement userNameInput =>  Driver.FindElement(By.Id("UserName"));
        IWebElement passwordInput => Driver.FindElement(By.Id("Password"));
        IWebElement submitBtn => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string username, string password) {
            userNameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            submitBtn.Submit();
        }

    }
}
