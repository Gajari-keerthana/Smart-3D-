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
    public class Step6
    {
        private AndroidDriver<AndroidElement> driver;
        public Step6(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        By Tinnitus = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneSwitchButtonTitleTinnitusManager\"]");
        By calming = By.XPath("//android.widget.Button[@content-desc=\"TsgNatureSoundsCalmingWaves\"]");
        By Breaking = By.XPath("//android.widget.Button[@content-desc=\"TsgNatureSoundsBreakingWaves\"]");
        By Sound = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneSwitchButtonTitleFinetune\"]");
        By exit = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");


        // press on Tinnitus Manager on All Around  Sound Enhancer
        public void tinnitusmanager()
        {
            driver.FindElement(Tinnitus).Click();
        }

        //press Nature sound button Calming Waves on All Around Tinnitus manager
        public void calmingwaves()
        {
            driver.FindElement(calming).Click();
        }

        //press Nature sound button Breaking Waves on All Around Tinnitus manager
        public void breakingwaves()
        {
            driver.FindElement(Breaking).Click();
        }
        
        public void Soundenhancer()
        {
            driver.FindElement(Sound).Click();
        }

        //press the exit button on All Around Sound enhancer
        public void exitbutton()
        {
            driver.FindElement(exit).Click();
        }

        By swipe = By.XPath("(//android.view.ViewGroup[@index='0'])[2]");
        By text = By.Id("dk.resound.smart3d:id/card_title");

        //swipe left to Hear in Noise program from current program
        public void hearinnoise()
        {

            AndroidElement swipeside = driver.FindElement(swipe);
            int screenWidth = swipeside.Size.Width;
             int screenHeight = swipeside.Size.Height;
             int endX = 0;
             int y = screenHeight / 2;
             TouchAction swipeAction = new TouchAction(driver);
             swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
            
        }

        //validate program card is Hear in Noise
        public String ValidateText()
        {
            return driver.FindElement(text).Text;
           
        }

        //press Sound Enhancer button on Hear in noise program
        By hearsound = By.XPath("//android.widget.TextView[@content-desc=\"HomeButtonLabelFineTune\"]");

        public void hearsoundnoise()
        {
            driver.FindElement(hearsound).Click();
        }

        //press Tinnitus Manager on Hear in noise Sound Enhancer
        By hearTinnitus = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneSwitchButtonTitleTinnitusManager\"]");

        public void heartinnitussound()
        {
            driver.FindElement(hearTinnitus).Click();
        }

        //press white noise button Slight variation on Hear in noise Tinnitus Manager
        By slightvariation = By.XPath("//android.widget.Button[@content-desc=\"TsgWhiteNoiseVariationsSlight\"]");

        public void slightvar()
        {
            driver.FindElement(slightvariation).Click();
        }


        By reset = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneButtonReset\"]");
        By sound1 = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneSwitchButtonTitleFinetune\"]");
        By exit1 = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");

        public void resetbutton() //press Reset button on All-Around Tinnitus Manager
        {
            driver.FindElement(reset).Click();
        }

        public Step7 soundenh() //press the exit button on Hear in noise Sound Enhancer
        {
            driver.FindElement(sound1).Click();
            driver.FindElement(exit1).Click();
            return new Step7(driver);
        }

       
    }
}
