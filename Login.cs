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
using OpenQA.Selenium.Interactions;

namespace BukinistTestAutomation
{
      public class Login
      {
             [TestMethod]
             public void TA_Login()
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

                IWebElement HyrNeLlogari = driver.FindElement(By.XPath("//*[@id=\"SubmitLogin\"]"));
                HyrNeLlogari.Click();

                Thread.Sleep(5000);
                driver.Dispose();

}
             }
      }        



             

