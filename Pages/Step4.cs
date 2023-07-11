using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3D.Pages
{
    public class Step4
    {
        private AndroidDriver<AndroidElement> driver;
        public Step4(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
        By speech = By.XPath("//android.widget.TextView[@content-desc=\"SmartButtonAllAroundSpeechClarity\"]");
        //By text = By.Id("SmartButtonAllAroundSpeechClarity");
        By noise = By.XPath("//android.widget.TextView[@content-desc=\"SmartButtonAllAroundNoiseFilter\"]");

        public void press()
        {
            driver.FindElement(speech).Click();
           
        }

        public String ValidateText()
        {
            return driver.FindElement(speech).Text;
            //return driver.FindElement(speech).Text.Replace("\n", " ");
        }

        public void press1()
        {
            driver.FindElement(noise).Click();
        }
        public void ValidateText1()
        {

           // IWebElement speechElement = driver.FindElement(speech);
            IWebElement noiseElement = driver.FindElement(noise);

            bool isNoiseElementEnabled = noiseElement.Enabled;
            //bool isSpeechElementDisabled = !speechElement.Enabled;

            Console.WriteLine("'Noise filter' button enabled status: " + isNoiseElementEnabled);
           // Console.WriteLine("'Speech clarity' button enabled status: " + !isSpeechElementDisabled);

            Assert.IsTrue(isNoiseElementEnabled, "'Noise filter' button is not enabled.");
           // Assert.IsTrue(isSpeechElementDisabled, "'Speech clarity' button is not disabled.");
        }

        public Step5 validateText2()
        {
            IWebElement speechElement = driver.FindElement(speech);
            bool isSpeechElementEnabled = speechElement.Enabled;
            Console.WriteLine("'Speech clarity' button enabled status: " + isSpeechElementEnabled);
            Assert.IsTrue(isSpeechElementEnabled, "'Speech clarity' button is not disabled.");
            return  new Step5(driver);
        }


    }

}

