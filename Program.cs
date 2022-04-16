using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testing_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/");

            Thread.Sleep(2000);

            IWebElement SearchElement = driver.FindElement(By.Name("q"));

            SearchElement.SendKeys("Bassetti India");

            IWebElement buttonElement = driver.FindElement(By.Name("btnK"));
            buttonElement.Click();

            driver.Close();
        }
    }
}
