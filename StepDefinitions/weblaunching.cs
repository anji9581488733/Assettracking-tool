using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Webapllication.Drivers;

namespace Webapllication.StepDefinitions
{
    [Binding]
    public class weblaunching
    {
        [Given(@"enter credentials one by one(.*) , Anji@(.*)")]
        public void GivenEnterCredentialsOneByOneAnji(int EmployeeId, string Passowrd)
        {
            Webdrive driver = new Webdrive();
            driver.ChromeDriver.Navigate().GoToUrl("https://friendly-davinci.72-167-36-205.plesk.page/Login");
            Assert.IsTrue(driver.ChromeDriver.Title.ToLower().Contains("google"));
            var username = driver.ChromeDriver.FindElement(By.XPath("//input[@name='txtUsername']"));
            username.SendKeys(int.Parse(EmployeeId));
        }

        [When(@"Navigate to Asset request page")]
        public void WhenNavigateToAssetRequestPage()
        {
            
        }


    }
}
