using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using Task2.Pages;
using System.Threading;

namespace Task2
{
    [TestFixture]
    public class TestClass
    {
        static IWebDriver driver;
        [Test]
        public void TestMethod()

        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://uk-ua.facebook.com/";
            FacebookMainPage page1 = new FacebookMainPage(driver);
            page1.typeLogin();
            page1.typePassword();
            page1.clickGoButton();

            Thread.Sleep(8000);
            driver.Quit();


            

            

            



           
            

       

             

            



        }
    }
}
