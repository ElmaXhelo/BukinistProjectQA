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
    public class WishList
    {


        [TestMethod]

        public void WishList1()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://bukinist.al/sq/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("btn-kategori")));

            IWebElement hyr = driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/nav/div[1]/div/a"));
            hyr.Click();


            IWebElement EmailAddres = driver.FindElement(By.Id("email"));
            EmailAddres.Click();
            EmailAddres.SendKeys("elmaxhelo@gmail.com");


            IWebElement Fjalëkalimi = driver.FindElement(By.Id("passwd"));
            Fjalëkalimi.Click();
            Fjalëkalimi.SendKeys("elmaxhelo@");

            IWebElement HyrNeLlogari = driver.FindElement(By.Id("SubmitLogin"));
            HyrNeLlogari.Click();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"columns\"]/div[1]")));



            IWebElement HistorikuIPorosive = driver.FindElement(By.XPath("//*[@id=\"center_column\"]/div/div/ul/li[1]/a"));
            HistorikuIPorosive.Click();



            Thread.Sleep(50000);
            driver.Dispose();


        }

    }
}    