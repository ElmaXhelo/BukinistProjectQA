using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BukinistProject
{
    [TestClass]
    public class MikuIBukinistit
    {


        [TestMethod]

        public void MikuIBukinistit1()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://bukinist.al/sq/");



            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("second-menu")));

            IWebElement MikuIBukinistit = driver.FindElement(By.CssSelector("#header > div.menu-other > div > div > div.second-menu > a:nth-child(3)"));
            MikuIBukinistit.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"center_column\"]/div/div/div[2]")));


            IWebElement Home = driver.FindElement(By.ClassName("icon-home"));
            Home.Click();

            Thread.Sleep(7000);
            driver.Dispose();
        }

    }
}    











    

