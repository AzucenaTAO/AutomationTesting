using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting
{
    public class Purchase
    {
        public bool IsCurrentStatus(string status)
        { 
            return DriverHelper.GetText(By.CssSelector(".step_current span")).Contains(status);
        }
        public void PurchaseCheckout()
        {
            DriverHelper.Click(By.CssSelector(".button-container a[title='Proceed to checkout'] span"));
        }

        public void SummaryCheckout()
        {
            DriverHelper.Click(By.CssSelector(".cart_navigation a[title='Proceed to checkout']"));
        }
        public void AddressCheckout()
        {
            DriverHelper.Click(By.CssSelector("button[name='processAddress']"));
        }
        public void ShippingCheckout()
        {
            DriverHelper.Click(By.CssSelector("button[name='processCarrier']"));
        }
        public void TermsAndServicesCheck()
        {
            DriverHelper.Click(By.CssSelector("p.checkbox span"));
        }

    }
}
