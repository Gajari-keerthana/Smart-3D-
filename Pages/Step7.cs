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
using static System.Net.Mime.MediaTypeNames;

namespace Smart3D.Pages
{
    public class Step7
    {
        private AndroidDriver<AndroidElement> driver;
        public Step7(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        By outdoor = By.XPath("(//android.view.View[@index='0'])[2]");
        By outdoortitle = By.Id("dk.resound.smart3d:id/card_title");

        public void outdoornoise()
        {

            AndroidElement swipeside = driver.FindElement(outdoor);
            int screenWidth = swipeside.Size.Width;
            int screenHeight = swipeside.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction swipeAction = new TouchAction(driver);
            swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
        }
        public String ValidateText()
        {
            return driver.FindElement(outdoortitle).Text;

        }

        By outdoorsound = By.XPath("//android.widget.TextView[@content-desc=\"HomeButtonLabelFineTune\"]");

        public void outdoorsoundnoise()
        {
            driver.FindElement(outdoorsound).Click();
        }

        By windnoise = By.XPath("(//android.view.View[@index='0'])[5]");
        By Strongtitle = By.ClassName("android.widget.TextView");

        public void windvalue(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
            AndroidElement slide1 = driver.FindElement(windnoise);
            touchaction.Press(858, 1931)
                       .MoveTo(858, 1931)
                       .Release()
                       .Perform();
        }
        public String StrongValidateText()
        {
            return driver.FindElement(Strongtitle).Text;

        }

    }
}
