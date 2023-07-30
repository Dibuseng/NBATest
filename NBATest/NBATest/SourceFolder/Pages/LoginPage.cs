using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.DevTools;

namespace NBATest.SourceFolder.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait wait;


        
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign In')]")]
        private IWebElement signinLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign in with NBA ID')]")]
        private IWebElement signinLink2;




        [ FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        private IWebElement email;

       [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[@id='submit']")]
        private IWebElement submit;



        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
  
        }

        public void Login(string username, string pass)
        {
            HomePage hp = new HomePage(_driver);
            hp.signinLink.Click();
            hp.signinLink2.Click();
           
            email.SendKeys(text: username);
            password.SendKeys(text: pass);

            IJavaScriptExecutor jse = (IJavaScriptExecutor)_driver;
            jse.ExecuteScript("arguments[0].click()", submit);
            

       }
    }
}

