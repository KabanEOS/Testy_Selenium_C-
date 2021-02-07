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

namespace Selenium_MMadejski
{
    [TestFixture]
    public class TestClass : BaseTest
    {

        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");            
            IWebElement categorySelect = driver.FindElement(By.XPath(".//*[@id='gh-cat']"));
            SelectElement element = new SelectElement(categorySelect);
            element.SelectByIndex(5);
            element.SelectByText("Books");
            element.SelectByValue("15032");
        } 
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(2000);
        }
    }
}
