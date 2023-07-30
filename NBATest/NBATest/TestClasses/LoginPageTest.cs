using NBATest.SourceFolder.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using NBATest.Drivers;

namespace NBATest.TestClasses
{
    [Parallelizable(ParallelScope.All)]
    public class LoginPageTest : Driver
    {

        [Test]

        public void InvalidLogin()
        {
            LoginPage loginPage = new LoginPage(_driver);
            _driver.Navigate().GoToUrl(("https://www.nba.com/"));


            //Test if the user leaves the Password text empty
            loginPage.Login(username: "test@gmail.com", pass: "");
            Assert.False(_driver.Title.Contains("Password is required."));
        }


        [Test]
        public void InvalidLogin2()
        {
            LoginPage loginPage = new LoginPage(_driver);
            _driver.Navigate().GoToUrl(("https://www.nba.com/"));

            //Test if the user leaves the Username is empty
            loginPage.Login(username: "", pass: "pass123");
            Assert.False(_driver.Title.Contains("Email address is required."));
        }
    }
}