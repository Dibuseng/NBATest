using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace NBATest.Drivers
{ 
    public class Driver
{
    [ThreadStatic]
    public static WebDriver _driver;

    [SetUp]
    public void InitScript()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        {
            _driver.Close();
        }
    }
}
}
