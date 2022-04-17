using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Find_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            string name = "abcd";
            string email = "abcd@gmail.com";
            string Cadd = "aaaaaaaaa";
            string Padd = "bbbbbbbbbb";

            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.Id("userName")).SendKeys(name);

            Driver.FindElement(By.Id("userEmail")).SendKeys(email);

            Driver.FindElement(By.Id("currentAddress")).SendKeys(Cadd);

            Driver.FindElement(By.Id("permanentAddress")).SendKeys(Padd);

            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,400)");

            Driver.FindElement(By.Id("submit")).Click();

            Task.Delay(10000).Wait();

            Console.Write("Test Case Closed:");

            Driver.Close();
            Driver.Quit();

        }
    }
}
