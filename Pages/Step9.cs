using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Linq;
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
        By Myresound = By.XPath("//android.widget.ImageView[@content-desc=\"bottom_menu_icon_person\"]");
        public void resound()
        {
            driver.FindElement(Myresound).Click();
        }

        By learn = By.XPath("//android.widget.TextView[@content-desc=\"MyResoundLearningMenuTitleApp\"]");
        public void learnaboutapp()
        {
            driver.FindElement(learn).Click();
        }

        By volume = By.XPath("//android.widget.TextView[@content-desc=\"HelpChapterTitleVolumeControls\"]");
        public void volumecontrol()
        {
            driver.FindElement(volume).Click();
        }

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

        By guiding = By.XPath("//android.widget.TextView[@content-desc=\"MyMenuNudgingTipsText\"]");
        public void guidingtips()
        {
            driver.FindElement(guiding).Click();
        }

        By notice = By.XPath("//android.widget.TextView[@content-desc=\"NudgingArchiveDialogConfirm\"]");
        public void clicknotice()
        {
            driver.FindElement(notice).Click();
        }

        By title = By.XPath("//android.widget.TextView[@content-desc=\"MyMenuNudgingTipsText\"]");
        public string guidingtitle()
        {
           return driver.FindElement(title).Text;
        }

    }
}
