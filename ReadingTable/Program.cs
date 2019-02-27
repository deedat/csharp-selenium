using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ReadingTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // create aour referrence to our browser
            IWebDriver driver = new ChromeDriver(".");

            // navigate to google chrome
            driver.Navigate().GoToUrl("https://www.google.com/");
            
            //find the element
            IWebElement element = driver.FindElement(By.Name("q"));
            
            // perform Ops
            element.SendKeys("salam");

            //close the brower 
            driver.Close();

        }
    }
}
