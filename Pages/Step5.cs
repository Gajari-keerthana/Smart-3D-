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


        //press on Sound Enhancer button on All Around program
        public void sound()
        {
            driver.FindElement(soundEnhancer).Click();
        }

        //set Bass gain to '4' Middle gain to '-3' Treble gain to '5'
        public void value1(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
           AndroidElement slide1 = driver.FindElement(element1);
            touchaction.Press(90,1035)
                       .MoveTo(90, 681)
                       .Release()
                       .Perform();
        } 

        public void value2(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
            
            AndroidElement slide2 = driver.FindElement(element2);

            touchaction.Press(450, 1035)
                       .MoveTo(450, 1356)
                       .Release()
                       .Perform();

        }

        public void value3(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
            AndroidElement slide3 = driver.FindElement(element3);
            touchaction.Press(810, 1035)
                       .MoveTo(810, 588)
                       .Release()
                       .Perform();
        }

        //Then validate Bass gain to '4' Middle gain to '-3' Treble gain to '5'
        public void validatespeech1(string bass) 
        {
            try
            {
                Actions actions = new Actions(driver);
                AndroidElement slide1 = driver.FindElement(element1);
                actions.ClickAndHold(slide1).Perform();
                actions.MoveByOffset(0, 239).Perform();
                string actualvalue1 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
                Assert.AreEqual(bass, actualvalue1);
                actions.Release().Perform();
            }
            catch (Exception ex)
            {
                // Handle the exception (you can log it or perform other actions if needed)
                Console.WriteLine("Validation 1 failed: " + ex.Message);
            }
        }

        public void validatespeech2(string middle)
        {
            try
            {
                Actions actions = new Actions(driver);
                AndroidElement slide2 = driver.FindElement(element2);
                actions.ClickAndHold(slide2).Perform();
                actions.MoveByOffset(360, 239).Perform();
                string actualvalue2 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
                Assert.AreEqual(middle, actualvalue2);
                actions.Release().Perform();
            }
            catch (Exception ex)
            {
                // Handle the exception (you can log it or perform other actions if needed)
                Console.WriteLine("Validation 2 failed: " + ex.Message);
            }


        }

       public Step6 validatespeech3(string treble)
        {
            try
            {
                Actions actions = new Actions(driver);
                AndroidElement slide3 = driver.FindElement(element3);
                actions.ClickAndHold(slide3).Perform();
                actions.MoveByOffset(720, 239).Perform();
                string actualvalue3 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
                Assert.AreEqual(treble, actualvalue3);
                actions.Release().Perform();
                
            }
            catch (Exception ex)
            {
                // Handle the exception (you can log it or perform other actions if needed)
                Console.WriteLine("Validation 2 failed: " + ex.Message);
            }
            return new Step6(driver);

        }

    }
}
