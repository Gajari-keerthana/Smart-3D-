using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Smart3D.Pages
{
    public class Step9
    {
        private AndroidDriver<AndroidElement> driver;
        public Step9(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        //press menu item My ReSound on bottom ribbon bar
        By Myresound = By.XPath("//android.widget.ImageView[@content-desc=\"bottom_menu_icon_person\"]");
        public void resound()
        {
            driver.FindElement(Myresound).Click();
        }

        //press Learn about the app on My ReSound
        By learn = By.XPath("//android.widget.TextView[@content-desc=\"MyResoundLearningMenuTitleApp\"]");
        public void learnaboutapp()
        {
            driver.FindElement(learn).Click();
        }

        //press Volume control on Learn about the app
        By volume = By.XPath("//android.widget.TextView[@content-desc=\"HelpChapterTitleVolumeControls\"]");
        public void volumecontrol()
        {
            driver.FindElement(volume).Click();
        }

        //swipe left to 2 / 3 page on Learn about the app and validate Left and right volume animation is shown on Volume control
        By volumelr = By.XPath("(//android.widget.FrameLayout[@index='0'])[4]");
        By leftright = By.XPath("//android.widget.TextView[@content-desc=\"HelpVolumeControlsSplitTitle\"]");
        public void volumeleftright()
        {
            AndroidElement swipeside = driver.FindElement(volumelr);
            int screenWidth = swipeside.Size.Width;
            int screenHeight = swipeside.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction swipeAction = new TouchAction(driver);
            swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
        }

        public string validatebutton()
        {
            return driver.FindElement(leftright).Text;
        }

        //swipe mute left to 3 / 3 page on Learn about the app and validate Mute animation is shown on Volume control
        By mute = By.XPath("(//android.widget.LinearLayout[@index='0'])[4]");
        By animation = By.XPath("//android.widget.TextView[@content-desc=\"HelpVolumeControlsMuteTitle\"]");
        public void swipemute()
        {
            AndroidElement swipeside = driver.FindElement(mute);
            int screenWidth = swipeside.Size.Width;
            int screenHeight = swipeside.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction swipeAction = new TouchAction(driver);
            swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
        }

        public string animationmute()
        {
            return driver.FindElement(animation).Text;
        }

        //close on Learn about the app and back to My Resound page
        By closevolume = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");
        public void volumeclose()
        {
            driver.FindElement(closevolume).Click();
        }

        By close = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void learningclose()
        {
            driver.FindElement(close).Click();
        }

        //press Guiding tips on My ReSound
        By guiding = By.XPath("//android.widget.TextView[@content-desc=\"MyMenuNudgingTipsText\"]");
        public void guidingtips()
        {
            driver.FindElement(guiding).Click();
        }

        //press OK on Please notice dialog
        By notice = By.XPath("//android.widget.TextView[@content-desc=\"NudgingArchiveDialogConfirm\"]");
        public void clicknotice()
        {
            driver.FindElement(notice).Click();
        }

        //validate title is Guiding tips on Guiding tips page
        By title = By.XPath("//android.widget.TextView[@content-desc=\"MyMenuNudgingTipsText\"]");
        public string guidingtitle()
        {
           return driver.FindElement(title).Text;
        }

        //press Noise filter on Guiding tips
        By noiseguide = By.XPath("//android.widget.TextView[@content-desc=\"NudgingFunctionalTip1Week5Header\"]");
        public void noisefilterguid()
        {
            driver.FindElement(noiseguide).Click();
        }

        //press Got it on Noise filter nudging dialog
        By gotitnoise = By.XPath("//android.widget.TextView[@content-desc=\"NudgingTipConfirmButton\"]");
        public void noisegoit()
        {
            driver.FindElement(gotitnoise).Click();
        }

        //press My Resound on bottom ribbon bar and back to Guiding tips on My Resound
        By pressresound = By.XPath("//android.widget.ImageView[@content-desc=\"bottom_menu_icon_person\"]");
        public void myresoundpress()
        {
            driver.FindElement(pressresound).Click();
        }

        //press Music program on Guiding tips
        By musicguide = By.XPath("//android.widget.TextView[@content-desc=\"NudgingFunctionalTip1Week3Header\"]");
        public void guidingmusic()
        {
            driver.FindElement(musicguide).Click();
        }

        //validate Got it button enabled on Music program nudging dialog
        By gotitmusic = By.XPath("//android.widget.TextView[@content-desc=\"NudgingTipConfirmButton\"]");
        public bool MusicGotIt()
        {
            try
            {
                 return driver.FindElement(gotitmusic).Enabled;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }

        //validate Back to tips button enabled on Music program nudging dialog
        By backitmusic = By.XPath("//android.widget.TextView[@content-desc=\"NudgingTipBackToArchiveButton\"]");
        public bool backittipsmusic()
        {
            try
            {
                return driver.FindElement(backitmusic).Enabled;
                
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        //press Got it on Music program nudging dialog
        public Step10 pressgotit()
        {
            driver.FindElement(gotitmusic).Click();
            return new Step10(driver);
        }
    }
}
