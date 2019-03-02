using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Pages
{

    
    public class FacebookMainPage
        
    {
        IWebDriver driver;

        By emailField = By.XPath("//input[@name='email']");
        By passwordField = By.XPath("//input[@id='pass']");
        By goButton = By.XPath("//input[@id='u_0_2']");

        public FacebookMainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void typeLogin()
        {
            driver.FindElement(emailField).SendKeys("hanoshenkomail@gmail.com");
        }

        public void typePassword()
        {
            driver.FindElement(passwordField).SendKeys("wertyasd123");
        }

        public void clickGoButton()
        {
            driver.FindElement(goButton).Submit();
        }

       


    }
}
