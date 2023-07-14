using Microsoft.Extensions.Options;
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
using System.Xml.Linq;

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
        By element1 = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelBass\"]");
        By element2 = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelMiddle\"]");
        
        By element3 = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelTreble\"]");

        public void sound()
        {
            driver.FindElement(soundEnhancer).Click();
        }

        public void value1(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
           AndroidElement slide1 = driver.FindElement(element1);
            touchaction.Press(101,978)
                       .MoveTo(101, 640)
                       .Release()
                       .Perform();
        } 

        public void value2(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
            
            AndroidElement slide2 = driver.FindElement(element2);

            touchaction.Press(461, 978)
                       .MoveTo(461, 1298)
                       .Release()
                       .Perform();

        }

        public void value3(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
            AndroidElement slide3 = driver.FindElement(element3);
            touchaction.Press(821, 978)
                       .MoveTo(821, 547)
                       .Release()
                       .Perform();
        }

        public void validatespeech1(string bass)
        {
            Actions action = new Actions(driver);
            AndroidElement slide1 = driver.FindElement(element1);
            action.ClickAndHold(slide1).MoveByOffset(0, 2).Perform();
            string actual_value1 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
            Assert.AreEqual(actual_value1,bass);
        }

            public void validatespeech2(string middle)
            {
            Actions action = new Actions(driver);
            AndroidElement slide2 = driver.FindElement(element2);
            action.ClickAndHold(slide2).MoveByOffset(0,0).Perform();
            string actual_value1 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelMiddle\"]")).Text;
            Assert.AreEqual(actual_value1,middle);
            }

       public Step6 validatespeech3(string treble)
        {
            Actions action = new Actions(driver);
            AndroidElement slide3 = driver.FindElement(element3);
            action.ClickAndHold(slide3).MoveByOffset(0, 0).Perform();
            string actual_value1 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelTreble\"]")).Text;
            Assert.AreEqual(actual_value1, treble);
            return new Step6(driver);
        }

    }
}
