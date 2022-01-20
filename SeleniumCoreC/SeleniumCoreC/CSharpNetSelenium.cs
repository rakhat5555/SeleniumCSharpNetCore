using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCoreC
{
    public class Tests1
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
            //Driver.Navigate().GoToUrl("https://executeautomation.com");
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Potato");
            Driver.FindElement(By.XPath("(//div[@class='o-chkico'])[1]")).Click();
           

        }
    }
}