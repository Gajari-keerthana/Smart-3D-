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

        //press more menu item Support
        By support = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralSupportText\"]");
        public void moresupport()
        {
            driver.FindElement(support).Click();
        }

        //validate html view is displayed on Support page
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

        //validate page title is displayed on Support page
        By supporttitle = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralSupportText\"]");
        public string titlepagesupport()
        {
            return driver.FindElement(supporttitle).Text;
        }

        //press back from Support page
        By backsupport = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void pressbacksupportpage()
        {
            driver.FindElement(backsupport).Click();
        }

        //press menu item Home on bottom ribbon bar
        By presshome = By.Id("dk.resound.smart3d:id/home_tab");
        public void homebackpage()
        {
            driver.FindElement(presshome).Click();
        }
    }
}
