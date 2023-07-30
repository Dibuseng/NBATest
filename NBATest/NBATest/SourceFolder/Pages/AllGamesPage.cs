using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace NBATest.SourceFolder.Pages
{
    public class AllGamesPage
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='__next']/div[2]/div[1]/div[3]/nav[1]/ul[1]/li[3]/a[1]")]
        private IWebElement gameTickets;

        public AllGamesPage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        public SeasonTickets goToTickets()
        {
            gameTickets.Click();
            return new SeasonTickets(_driver);
        }
    }
}
