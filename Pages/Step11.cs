using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3D.Pages
{
    public class Step11
    {
        private AndroidDriver<AndroidElement> driver;
        public Step11(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        By support = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralSupportText\"]");
        public void moresupport()
        {
            driver.FindElement(support).Click();
        }

        By supporthtml = By.XPath("(//android.webkit.WebView[@index='0'])[1]");
        public bool supporthtmlpage()
        {
            try
            {
                return driver.FindElement(supporthtml).Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        By supporttitle = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralSupportText\"]");
        public string titlepagesupport()
        {
            return driver.FindElement(supporttitle).Text;
        }

        By backsupport = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void pressbacksupportpage()
        {
            driver.FindElement(backsupport).Click();
        }

        By presshome = By.Id("dk.resound.smart3d:id/home_tab");
        public void homebackpage()
        {
            driver.FindElement(presshome).Click();
        }
    }
}
