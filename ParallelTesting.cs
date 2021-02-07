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
using Selenium_MMadejski.Utilities;

namespace Selenium_MMadejski
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        } 
    }
}
