using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace ProjectBukinisti
{
    [TestClass]
    public class AddToCardd

    {


        [TestMethod]
        public void AddToCardd1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://bukinist.al/sq/");

          

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("btn-kategori")));

            IWebElement KATEGORITE = driver.FindElement(By.ClassName("btn-kategori"));
            KATEGORITE.Click();

            IWebElement Libra  = driver.FindElement(By.XPath("//*[@id=\"custom-menu-ar\"]/ul/li[1]/a"));
            Libra.Click();

            IWebElement Mëtëshiturit = driver.FindElement(By.XPath("//*[@id=\"subcategories\"]/ul/li[2]/h5/a"));
            Mëtëshiturit.Click();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main-category\"]/ul/li[1]/div/div[1]/div/a[1]/img")));

            IWebElement BabaIPasurBabaIVarfër = driver.FindElement(By.XPath("//*[@id=\"main-category\"]/ul/li[1]/div/div[1]/div/a[1]/img"));
            BabaIPasurBabaIVarfër.Click();







            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            // wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main-category\"]/ul/li[27]/div/div[1]/div/a[1]")));


            IWebElement AddToCart = driver.FindElement(By.XPath("//*[@id=\"add_to_cart\"]/button"));
            AddToCart.Click();

            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a")));

            IWebElement FinishOrder = driver.FindElement(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a"));
            FinishOrder.Click();


           





            Thread.Sleep(5000);
            driver.Dispose();






        }







    }






}

   
  
        




        
        









