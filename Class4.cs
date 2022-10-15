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

namespace ProjectBukinisti
{


    [TestClass]
    public class Purchase
    {


        [TestMethod]

        public void TA_Purchase1()
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
            EmailAddres.SendKeys("ndffnfjtrfjrkl@gmail.com");


            IWebElement Fjalëkalimi = driver.FindElement(By.Id("passwd"));
            Fjalëkalimi.Click();
            Fjalëkalimi.SendKeys("elmaxhelo@");

            IWebElement HyrNeLlogari = driver.FindElement(By.XPath("//*[@id=\"SubmitLogin\"]"));
            HyrNeLlogari.Click();

            WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"header\"]/div[2]/div/div")));

            //
            IWebElement KATEGORITE = driver.FindElement(By.ClassName("btn-kategori"));
            KATEGORITE.Click();

            IWebElement Libra = driver.FindElement(By.XPath("//*[@id=\"custom-menu-ar\"]/ul/li[1]/a"));
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







            
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"center_column\"]/div")));
                       

             IWebElement Emri = driver.FindElement(By.Id("firstname"));
             Emri.Click();
            Emri.SendKeys("Elma");

            IWebElement Mbiemri = driver.FindElement(By.Id("lastname"));
            Mbiemri.Click();
             Mbiemri.SendKeys("Xhelo");

            IWebElement Kompania = driver.FindElement(By.Id("company"));
            Kompania.Click();
            Kompania.SendKeys("bukinist");


            IWebElement Adresa = driver.FindElement(By.Id("address1"));
            Adresa .Click();
            Adresa.SendKeys("rruga Durrsit");

            IWebElement Adresarreshti2 = driver.FindElement(By.Id("address2"));
            //Adresarreshti2.Click();
            Adresarreshti2.SendKeys("rruga Durrsit");

            IWebElement Qyteti = driver.FindElement(By.XPath("//*[@id=\"city\"]"));
            //Qyteti.Click();
            Qyteti.SendKeys("Tirana");

            IWebElement Vendi = driver.FindElement(By.XPath("//*[@id=\"id_state\"]"));
            //Vendi.Click();
            SelectElement selector3 = new SelectElement(driver.FindElement(By.Id("id_country")));
            selector3.SelectByValue("230");

            

            IWebElement shteti = driver.FindElement(By.XPath("//*[@id=\"id_state\"]"));
            //shteti.Click();
            SelectElement selector2 = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"id_state\"]")));
            selector2.SelectByValue("313");

            


            IWebElement KodiZipKodipostar = driver.FindElement(By.Id("postcode"));
            KodiZipKodipostar.Click();
            KodiZipKodipostar.SendKeys("1001");

            //IWebElement Vendi = driver.FindElement(By.XPath("//*[@id=\"id_state\"]"));
            //Vendi.Click();
            //SelectElement selector3 = new SelectElement(driver.FindElement(By.Id("id_country")));
            //selector3.SelectByValue("230");

            IWebElement Numërfiks = driver.FindElement(By.Id("phone"));
            Numërfiks.Click();
            Numërfiks.SendKeys("+355696180315");

            IWebElement Numërcelulari = driver.FindElement(By.Id("phone_mobile"));
            Numërcelulari.Click();
            Numërcelulari.SendKeys("+355696180315");

            IWebElement Informacionshtesë = driver.FindElement(By.Id("other"));
            Informacionshtesë.Click();
            Informacionshtesë.SendKeys("djxrhjnjfuerjnhfje");

            IWebElement Adresa2 = driver.FindElement(By.Id("alias"));
            Adresa2.Click();
            Adresa2.SendKeys("Adresa ime");

            IWebElement Ruaj = driver.FindElement(By.XPath("//*[@id=\"submitAddress\"]"));
            Ruaj.Click();

            Thread.Sleep(7000);
            driver.Dispose();











        }
    }

}
















