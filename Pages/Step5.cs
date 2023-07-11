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
    public class Step5
    {
        private AndroidDriver<AndroidElement> driver;
        public Step5(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        By soundEnhancer = By.XPath("//android.widget.TextView[@content-desc=\"HomeButtonLabelFineTune\"]");

        public void sound()
        {
            driver.FindElement(soundEnhancer).Click();
        }

        public void value1(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
            touchaction.Press(x: 101, y: 638).Release().Perform();
            AndroidElement element = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelBass\"]"));
        }

        public void value2(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
            touchaction.Press(x: 360, y: 218).Release().Perform();
            AndroidElement element1 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelMiddle\"]"));
        }

        public void value3(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
            touchaction.Press(x: 821, y: 565).Release().Perform();
            AndroidElement element2 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelTreble\"]"));
        }

        public void validatespeech1(string value)
        {
            Actions actions = new Actions(driver);
            actions.MoveByOffset(1, 0).Perform();
            string action_value1 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
            Assert.AreEqual(action_value1, value);
            actions.Release().Perform();
        }

        public void validatespeech2(string value)
        {
            Actions actions = new Actions(driver);
            actions.MoveByOffset(1, 0).Perform();
            string action_value2 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
            Assert.AreEqual(action_value2, value);
            actions.Release().Perform();
        }

        public void validatespeech3(string value)
        {
            Actions actions = new Actions(driver);
            actions.MoveByOffset(1, 0).Perform();
            string action_value3 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
            Assert.AreEqual(action_value3, value);
            actions.Release().Perform();
        }

    }
}
