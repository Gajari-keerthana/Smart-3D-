using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3D.Pages
{
    public class Programpage
    {
        private AndroidDriver<AndroidElement> driver;
        public Programpage(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        By displaytext = By.Id("dk.resound.smart3d:id/card_title");
        By split = By.Id("dk.resound.smart3d:id/SplitImageView_bottom");
        By seekbar1 = By.Id("dk.resound.smart3d:id/seekBar_top");
        By seekbar2 = By.Id("dk.resound.smart3d:id/seekBar_bottom");

        public string GetTitle()
        {
            return driver.FindElement(displaytext).Text;
        }

        public void clickonsplit()
        {
            driver.FindElement(split).Click();
        }

        public void slider1(string value)
        {
            Actions actions = new Actions(driver);
            TouchAction action = new TouchAction(driver);
            AndroidElement element1 = driver.FindElement(seekbar1);
            actions.ClickAndHold(element1).MoveByOffset(2, 0).Perform();
            string act_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(act_value, value);
            actions.Release().Perform();
        }

        public Step2 slider2(string value)
        {
            Actions actions = new Actions(driver);
            TouchAction action = new TouchAction(driver);
            AndroidElement element2 = driver.FindElement(seekbar2);
            actions.ClickAndHold(element2).Perform();
            actions.MoveByOffset(2, 0).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actual_value, value);
            actions.Release().Perform();
            return new Step2(driver);
        }
        

    }
}
