using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3D.Pages
{
    public class Step2
    {
        private AndroidDriver<AndroidElement> driver;
        public Step2(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        By seekbar3 = By.Id("dk.resound.smart3d:id/seekBar_top");
        By seekbar10 = By.Id("dk.resound.smart3d:id/seekBar_bottom");

        //set surrounding volume is "3" on Right HI and  "10" on Left HI
        public void slider3(string value)
        {
            Actions actions = new Actions(driver);
            TouchAction action = new TouchAction(driver);
            AndroidElement element3 = driver.FindElement(seekbar3);
            actions.ClickAndHold(element3).Perform();
            actions.MoveByOffset(-339, 0).Release().Perform();
        }


        public void slider10(string value)
        {
            Actions actions = new Actions(driver);
            TouchAction action = new TouchAction(driver);
            AndroidElement element4 = driver.FindElement(seekbar10);
            actions.ClickAndHold(element4).Perform();
            actions.MoveByOffset(66, 0).Release().Perform();
            
        }

        // validating the surrounding volume is "3" on Right HI and "10" on Left HI
        public void validate3(string value)
        {
            Actions actions = new Actions(driver);
            AndroidElement element3 = driver.FindElement(seekbar3);
            actions.ClickAndHold(element3).Perform();
            actions.MoveByOffset(1, 0).Perform();
            string act_value1 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(act_value1, value);
            actions.Release().Perform();
        }

        public Step3 validate10(string value)
        {
            Actions actions = new Actions(driver);
            AndroidElement element4 = driver.FindElement(seekbar10);
            actions.ClickAndHold(element4).Perform();
            actions.MoveByOffset(1, 0).Perform();
            String act_value2 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(value, act_value2);
            actions.Release().Perform();
            return new Step3(driver);
        }

    }
}
