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
    public class AutomationTest
    {
        IWebDriver driver;

        [Test]
        [Author("Michał Madejski","michal.madejski@microsoft.wsei.edu.pl")]
        [Description("EBay search verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='gh-ac']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\micha\\source\\repos\\Selenium_MMadejski\\ss\\s1.png", ScreenshotImageFormat.Png);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver!=null)
                {
                    driver.Quit();
                }
            }
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            //list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");
            list.Add("https://www.ebay.com/");
            return list;
        }

    }
}
