using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the ChromeDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // Wait for a few seconds to see the result

            // Get the title of the page
            string pageTitle = driver.FindElement(By.TagName("title")).GetAttribute("innerText");

            // Print the title to the console
            Console.WriteLine("The title of the page is: " + pageTitle);
            driver.FindElement(By.TagName("textarea")).SendKeys("Hi Bokachoda");
            driver.FindElement(RelativeBy.WithLocator(By.Name("btnK")).Below(driver.FindElement(By.TagName("textarea")))).Click();

            string text =   driver.FindElement(RelativeBy.WithLocator(By.XPath("//div[@id='search']//following:: h3")).Below(By.TagName("title"))).GetAttribute("innerText");
            Console.WriteLine("The 1st result of the page is: " + text);

            // Close the browser
            System.Threading.Thread.Sleep(500000);
        }
    }
}
