using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumLoginAutomation
{
    class SeleniumTest
    {
        static void Main(string[] args)
        {
            
            using (IWebDriver driver = new ChromeDriver())
            {
                try
                {
                    
                    driver.Navigate().GoToUrl("https://example.com/login");

                    
                    IWebElement usernameField = driver.FindElement(By.Name("username"));
                    IWebElement passwordField = driver.FindElement(By.Name("password")); 

                    usernameField.SendKeys("testuser");
                    passwordField.SendKeys("password123");

                    
                    IWebElement loginButton = driver.FindElement(By.XPath("//button[@type='submit']")); 
                    loginButton.Click();

                    
                    Thread.Sleep(5000); 

                    
                    if (driver.Url == "https://example.com/dashboard") 
                    {
                        Console.WriteLine("Login successful! URL is correct.");
                    }
                    else
                    {
                        Console.WriteLine("Login failed! Current URL: " + driver.Url);
                    }

                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("Element not found: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
