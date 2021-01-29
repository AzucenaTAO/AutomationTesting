using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTesting
{
    
    [TestClass]
    public class Driver
    {
        public static IWebDriver driver = null;
        static void Main(string[] args)
        {
            Driver.initbrowser();
            Login login = new Login();
            login.LoginUser("azucena.alvarez@hotmail.com", "Azu1234.");
            login.GoToHome();
            Products products = new Products();
            products.AddToCart(3);
            Purchase purchase = new Purchase();
            purchase.PurchaseCheckout();
            Assert.IsTrue(purchase.IsCurrentStatus("Summary"));
            purchase.SummaryCheckout();
            purchase.AddressCheckout();
            purchase.TermsAndServicesCheck();
            purchase.ShippingCheckout();

           
        }
        [TestMethod]
        public void TestMethod1()
        {
            initbrowser();
            GoTo("http://automationpractice.com/index.php?");
        }

        public static void initbrowser()
        {
            var webDriverPath = Path.GetFullPath(ConfigurationManager.AppSettings["WebDriverPath"]);
            var webBrowserType = ConfigurationManager.AppSettings["WebBrowserType"];
            driver = new ChromeDriver(webDriverPath);
            driver.Url = ConfigurationManager.AppSettings["Url"];
        }
        public void GoTo(string url)
        {
            driver.Url = url;
        }
        public void closeBrowser()
        {
            driver.Close();
        }
    }

    public static class Locators
    {
        public static class Button
        {
            public static By CSS_loginButton = By.CssSelector(".header_user_info .login");
            public static By CSS_SignInButton = By.CssSelector( "#SubmitLogin");
        }
        public static class Text
        {
            public static By CSS_emailLogin = By.CssSelector("input#email");
            public static By CSS_passLogin = By.CssSelector("input#passwd");
            //mouse over
            ////ul[@class="product_list grid row"] /li[2] //a[@class="product_img_link"]
            ///hacer click
            /////ul[@class="product_list grid row"] /li[2] //a[@title="Add to cart"]
        }




    }
}


