using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCoreC.pages
{
    internal class HomePage {
        public HomePage(IWebDriver webDriver) {
            Driver = webDriver;
        }
        private IWebDriver Driver { get; }


        public IWebElement inkLogin => Driver.FindElement(By.Id("loginLink"));
        
        public void ClickLogin() => inkLogin.Click();



    }
}
