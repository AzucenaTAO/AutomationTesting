using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting
{
    public class Login
    {
        public void LoginUser(string email, string password)
        {
            DriverHelper.Click(Locators.Button.CSS_loginButton);
            DriverHelper.SetText(Locators.Text.CSS_emailLogin, email);
            DriverHelper.SetText(Locators.Text.CSS_passLogin,password);
            DriverHelper.Click(Locators.Button.CSS_SignInButton);

        }
        public void GoToHome()
        {
            DriverHelper.Click(By.CssSelector("#header_logo a"));
                

        }

    }
}
