using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Webapllication.Drivers;

namespace Webapllication.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        public IWebDriver driver;
        public ChromeDriver ChromeDriver { get; set; }
        //public Hooks1() 
        //{
          
        //}

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //Webdrive webdrive = new Webdrive();
            Console.WriteLine("ChromeDriver is launched");
        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            
            
            Console.WriteLine("Asset tarcking is launching");

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}