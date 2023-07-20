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
    public class Step8
    {
        private AndroidDriver<AndroidElement> driver;
        public Step8(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        By music = By.XPath("(//android.view.View[@index='0'])[2]");
        By musictitle = By.Id("dk.resound.smart3d:id/card_title");

        //swipe left to Music program from current program
        public void musicslide()
        {

            AndroidElement swipeside = driver.FindElement(music);
            int screenWidth = swipeside.Size.Width;
            int screenHeight = swipeside.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction swipeAction = new TouchAction(driver);
            swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
        }

        //validate program card is Music
        public String ValidateText()
        {
            return driver.FindElement(musictitle).Text;
        }

        //press Music program on the top ribbon bar
        By ribbon = By.XPath("//android.widget.ImageView[@content-desc=\"prg_music_m\"]");
        

        public void topribbon()
        {
            driver.FindElement(ribbon).Click();
        }

        //validate program card is Musicribbon
        public String ValidateText1()
        {
            return driver.FindElement(musictitle).Text;
        }

        By topoutdoor = By.XPath("//android.widget.ImageView[@content-desc=\"prg_outdoor_m\"]");
        By outdoortitle = By.Id("dk.resound.smart3d:id/card_title");

        //press Outdoor program on the top ribbon bar
        public void topribbon1()
        {
            driver.FindElement(topoutdoor).Click();
        }

        // validate program card is Outdoorribbon
        public string validateText2()
        {
            return driver.FindElement(outdoortitle).Text;
        }

        By tophear = By.XPath("//android.widget.ImageView[@content-desc=\"prg_hearinnoise_m\"]");
        By textnoise = By.Id("dk.resound.smart3d:id/card_title");

        //press Hear in noise program on the top ribbon bar
        public void topribbon2()
        {
            driver.FindElement(tophear).Click();
        }

        //validate program card is Hear in Noiseribbon
        public String validateText3()
        {
            return driver.FindElement(textnoise).Text;
        }

        By topAllaround = By.XPath("//android.widget.ImageView[@content-desc=\"prg_allaround_m\"]");
        By textallaround = By.Id("dk.resound.smart3d:id/card_title");

        //press All-Around program on the top ribbon bar
        public void topribbon3()
        {
            driver.FindElement(topAllaround).Click();
        }

        //validate program card is All-Around
        public string validateText4()
        {
            return driver.FindElement(textallaround).Text;
        }

        //press Program overview button on topribbonbar
        By programoverview = By.XPath("//android.widget.ImageView[@content-desc=\"ProgramOverviewDragButton\"]");

        public void programdrag()
        {
            driver.FindElement(programoverview).Click();
        }

        //press Hear in noise program on Program overview
        By hearoverview = By.XPath("//android.widget.ImageView[@content-desc=\"prg_hearinnoise_m\"]");
        public void programhear()
        {
            driver.FindElement(hearoverview).Click();
        }

        //press Outdoor program on Program overview
        By outdoorreview = By.XPath("//android.widget.ImageView[@content-desc=\"prg_outdoor_m\"]");
        public void programoutdoor()
        {
            driver.FindElement(outdoorreview).Click();
        }

        //press Music program on Program overview
        By musicreview = By.XPath("//android.widget.ImageView[@content-desc=\"prg_music_m\"]");
        public void programmusic()
        {
            driver.FindElement(musicreview).Click();
        }

        //press All-Around program on Program overview
        By Allaroundreview = By.XPath("//android.widget.ImageView[@content-desc=\"prg_allaround_m\"]");
        public void programAllaround()
        {
            driver.FindElement(Allaroundreview).Click();
        }

        //press the Close button on Program overview
        By close = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");
        public Step9 programclose()
        {
            driver.FindElement(close).Click();
            return new Step9(driver);
        }
    }
}
