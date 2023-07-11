using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3D.Pages
{
    public class PopupPage
    {
        private AndroidDriver<AndroidElement> driver;
        public PopupPage(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        By poptext = By.XPath("//android.widget.TextView[@content-desc=\"ConsentPopupButtonOK\"]");
        By poptext1 = By.XPath("//android.widget.TextView[@content-desc=\"ConsentPopupButtonNoThanks\"]");

        public Programpage clickonpopup()
        {
            driver.FindElement(poptext).Click();
            driver.FindElement(poptext1).Click();
            return new Programpage(driver);
        }

        
    }
}
