using AngleSharp.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBATest.SourceFolder.Pages
{

    public class HomePage 
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='__next']/div[2]/div[1]/div[1]/nav[1]/ul[1]/li[1]/a[1]")]
        private IWebElement games;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign In')]")]
        public IWebElement signinLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign in with NBA ID')]")]
        public IWebElement signinLink2;



        public HomePage(IWebDriver driver)
        { 
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        
        }
        
        public AllGamesPage goTogamesPage()
        {
            games.Click(); 
            return new AllGamesPage(_driver);
        }

    }
}
