﻿using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3D.Pages
{
    public class Welcomepage
    {
        private AndroidDriver<AndroidElement> driver;
        public Welcomepage(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
        By nametext = By.Id("dk.resound.smart3d:id/demo_button");  //it clicks on the take me to demo app

        public  PopupPage displaytext(string text)
        {
            driver.FindElement(nametext).Click();
            return new PopupPage(driver);
        }

            
    }
}
