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
        //By Strongtitle = By.XPath("(//android.widget.LinearLayout[@index='1'])[4]");

        public void windvalue(string value)
        {
            TouchAction touchaction = new TouchAction(driver);
            AndroidElement slide1 = driver.FindElement(windnoise);
            touchaction.Press(831, 1902)
                       .MoveTo(831, 1902)
                       .Release()
                       .Perform();
        }
        public void StrongValidateText(string expectedvalue)
        {
            // return driver.FindElement(Strongtitle).Text;


            Actions actions = new Actions(driver);
            AndroidElement slide1 = driver.FindElement(windnoise);
            actions.ClickAndHold(slide1).Perform();
            actions.MoveByOffset(1, 1).Perform();
            string actualvalue = driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup[2]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout[4]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.TextView")).Text;
            Assert.AreEqual(expectedvalue,actualvalue);
            actions.Release().Perform();
        }

        By exit = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");
        
        public Step8 soundexit()
        {
            driver.FindElement(exit).Click();
            return new Step8(driver);
        }

    }
}
