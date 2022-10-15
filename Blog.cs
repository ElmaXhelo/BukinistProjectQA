using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BukinistProject
{
    [TestClass]
    public class Blog
    {


        [TestMethod]

        public void Blog1()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://bukinist.al/sq/");



            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("second-menu")));

            IWebElement Blog = driver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div/div[2]/a[2]"));
            Blog.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"masthead\"]")));


            IWebElement TheniePerLibra = driver.FindElement(By.XPath("//*[@id=\"menu-item-33\"]/a"));
            TheniePerLibra.Click();

            Thread.Sleep(7000);
            driver.Dispose();
        }

    }
}   