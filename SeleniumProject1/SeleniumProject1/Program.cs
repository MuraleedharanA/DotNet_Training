using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://saucedemo.com/v1/");


            IWebElement elementNAme1 = driver.FindElement(By.Id("login_credentials"));
            string usernames=elementNAme1.Text.Split("\n",StringSplitOptions.RemoveEmptyEntries).ElementAt(1);
            Console.WriteLine(usernames);

            IWebElement passwrd = driver.FindElement(By.ClassName("login_password"));
            string pass = passwrd.Text.Split("\n", StringSplitOptions.RemoveEmptyEntries).ElementAt(1); ;
            Console.WriteLine(pass);

            IWebElement element3 = driver.FindElement(By.Id("user-name"));
            element3.SendKeys(usernames);

            IWebElement element4 = driver.FindElement(By.Id("password"));
            element4.SendKeys(pass);

            element4.Submit();

            //elementmsg1.SendKeys("msg1");
            //elementmsg1.Submit();

            //IWebElement element4 = driver.FindElement(By.Id("et_pb_contact_message_1"));
            //element4.SendKeys("msg2");
            //IWebElement element = driver.FindElement(By.Name("et_pb_contact_captcha_1"));
            //element.SendKeys("27");
            //element.Submit();
            //IWebElement element5 = driver.FindElement(By.ClassName("et_pb_contact_submit et_pb_button"));
            //element5.Click();










            //Console.WriteLine(element.GetAttribute("value"));
            //element.SendKeys("T-Shirt");
            //element.Submit();
            //IWebElement elementT = driver.FindElement(By.Id("twotabsearchtextbox"));

            //driver.Manage().Window.FullScreen();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //driver.
            //driver.Quit();
        }
    }
}