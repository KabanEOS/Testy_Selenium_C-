using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_MMadejski.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.ebay.com//";
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }


    }
}
