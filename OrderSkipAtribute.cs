// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_MMadejski.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Selenium_MMadejski
{
    [TestFixture]
    public class OrderSkipAtribute
    {

        [Test, Order(2), Category("OdrderAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.ebay.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test, Order(1), Category("OdrderAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.ebay.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test, Order(0), Category("OdrderAttribute")]
        public void TestMethod3()
        {
            Assert.Ignore("IE to ZUO");
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.ebay.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
