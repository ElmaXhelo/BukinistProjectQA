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
    public class LinksH
    {


        [TestMethod]

        public void TA_LinkH()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://bukinist.al/sq/");



            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("btn-kategori")));

            IWebElement RrethNesh = driver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div/div[2]/a[1]"));
            RrethNesh.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"center_column\"]/div/div/div[2]/div[1]")));


            IWebElement home = driver.FindElement(By.XPath("//*[@id=\"header_logo\"]/a/img"));
            home.Click();



            Thread.Sleep(7000);
            driver.Dispose();

        }
    }
}