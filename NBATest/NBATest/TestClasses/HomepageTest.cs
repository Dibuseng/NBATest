
using NBATest.Drivers;
using NBATest.SourceFolder.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NBATest.TestClasses
{
    public class HomepageTest : Driver
    {

        [Test]
        public void Home()

        //Automated tests to navigate throught diffrent pages
        {

            //Test to see if you land in on the NBA HomePage
            HomePage home = new HomePage(_driver);
            _driver.Navigate().GoToUrl(("https://www.nba.com/"));
            Assert.NotNull(home);

            //Test if the All Games is clickable and lands on the right page
            AllGamesPage allGames = home.goTogamesPage();
            Assert.True(allGames != null);

            AllGamesPage gamesPage = new AllGamesPage(_driver);
            //Test if the Tickets is clickable and lands on the right page
            SeasonTickets seasonTickets = gamesPage.goToTickets();
            Assert.IsTrue(seasonTickets != null);

        }
    }
}