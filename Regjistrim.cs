using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.IO;
using System.Threading;

namespace ProjectBukinisti
{
    [TestClass]
    public class ProjectBukinisti
    {
        [TestMethod]
        public void ProjectBukinistii1()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://bukinist.al/sq/");

           


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            //IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"onesignal-slidedown-cancel-button\"]"));
            //cookies.Click();


            IWebElement Hyr = driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div/div/nav/div[1]/div/a"));
            Hyr.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(300));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.Id("SubmitCreate")));



            IWebElement AdresaEmail = driver.FindElement(By.Id("email_create"));
            AdresaEmail.Click();
            AdresaEmail.SendKeys("elmaxhelcfdbfto@gmail.com");

            IWebElement KrijoLlogari = driver.FindElement(By.Id("SubmitCreate"));
            KrijoLlogari.Click();

            Thread.Sleep(7000);

            //WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"id_gender2\"]")));
            //*[@id=\"account-creation_form\"]


            //IWebElement INFORMACIONPERSONAL = driver.FindElement(By.ClassName("account_creation"));
            //INFORMACIONPERSONAL.Click();


            //
            // IWebElement Gender = new WebDriverWait(driver, TimeSpan.FromSeconds(35))
            // .Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"id_gender2\"]")));
            // Gender.Click();

            //IWebElement Mrs = driver.FindElement(By.XPath("//*[@id=\"id_gender2\"]"));
            //Mrs.Click();

            //var radio = driver.FindElement(By.Id("id_gender2"));
            //radio.Click();
            //*[@id="uniform-id_gender2"]
            //IWebElement Mrs = driver.FindElement(By.XPath("//*[@id=\"uniform-id_gender2\"]"));
            //SelectElement selector1 = new SelectElement(driver.FindElement(By.Id("uniform-id_gender2")));
            //selector1.SelectByValue("2");

            Thread.Sleep(7000);

            IWebElement Emri = driver.FindElement(By.Id("customer_firstname"));
            Emri.Click();
            Emri.SendKeys("Elma");

            IWebElement Mbiemri = driver.FindElement(By.Id("customer_lastname"));
            Mbiemri.Click();
            Mbiemri.SendKeys("Xhelo");

            IWebElement Email = driver.FindElement(By.Id("email"));
            Email.Click();
            Email.SendKeys("elmaxhelow3rr@gmail.com");

            IWebElement Fjalekalimi = driver.FindElement(By.Id("passwd"));
            Fjalekalimi.Click();
            Fjalekalimi.SendKeys("elmaXHELO@");



            //WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //IWebElement = wait2.Until(ExpectedConditions.ElementIsVisible(By.ClassName("is_required validate form-control")));


            IWebElement days = driver.FindElement(By.Id("days"));
            days.Click();
            SelectElement selector = new SelectElement(driver.FindElement(By.Id("days")));
            selector.SelectByValue("21");

            IWebElement months = driver.FindElement(By.Id("months"));
            months.Click();
            SelectElement selector2 = new SelectElement(driver.FindElement(By.Id("months")));
            selector2.SelectByValue("8");

            IWebElement years = driver.FindElement(By.Id("years"));
            years.Click();
            SelectElement selector3 = new SelectElement(driver.FindElement(By.Id("years")));
            selector3.SelectByValue("2001");

            IWebElement checker = driver.FindElement(By.ClassName("checker"));
            checker.Click();
            
            IWebElement Regjistrohu = driver.FindElement(By.XPath("//*[@id=\"submitAccount\"]"));
            Regjistrohu.Click();

            //WAIT


            Thread.Sleep(5000);
            driver.Dispose();
        }
    }
}
