﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapllication.Drivers
{

    
    public class Webdrive
    {

        public IWebDriver driver;
        public ChromeDriver ChromeDriver { get; set; }
        public Webdrive() 
        {
        ChromeDriver = new ChromeDriver(@"C:\\chromedriver.exe");
 
        }


    }
}
