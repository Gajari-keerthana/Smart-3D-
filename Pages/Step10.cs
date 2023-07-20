using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3D.Pages
{
    public class Step10
    {
        private AndroidDriver<AndroidElement> driver;
        public Step10(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        By more = By.XPath("//android.widget.ImageView[@content-desc=\"bottom_menu_icon_menu\"]");
        public void moreribbon()
        {
            driver.FindElement(more).Click();
        }

        By autoactive = By.XPath("//android.widget.Switch[@content-desc=\"AppAutoActivateSwitch\"]");
        public bool activefavorite()
        {
            try
            {
                return driver.FindElement(autoactive).GetAttribute("clickable") == "true";

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void switchon()
        {
            driver.FindElement(autoactive).Click();
        }

        By autoswitchoff = By.XPath("//android.widget.Switch[@content-desc=\"AppAutoActivateSwitch\"]");

        public bool activefavorite1()
        {
            try
            {
                return driver.FindElement(autoswitchoff).GetAttribute("clickable") == "true";

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        By about = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralAboutText\"]");

        public void generalabout()
        {
            driver.FindElement(about).Click();
        }

        By abouttitle = By.XPath("//android.widget.TextView[@content-desc=\"AboutHeaderTitle\"]");
        public string titleonabout()
        {
           return driver.FindElement(abouttitle).Text;
        }
        By content = By.ClassName("android.webkit.WebView");
        public bool viewtext()
        {
            try
            {
                return driver.FindElement(content).Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        By aboutback = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void backbutton()
        {
            driver.FindElement(aboutback).Click();
        }

        By legal = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalInformationText\"]");
        public void morelegalinfo()
        {
            driver.FindElement(legal).Click();
        }

        By manufacture = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuManufacturerText\"]");
        public void moremanufacture()
        {
            driver.FindElement(manufacture).Click();
        }

        By manuftitle = By.XPath("//android.widget.TextView[@content-desc=\"ManufacturerHeaderTitle\"]");
        public string manufacturetitle()
        {
            return driver.FindElement(manuftitle).Text;
        }

        By manufback = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void manufactureback()
        {
            driver.FindElement(manufback).Click();
        }

        By termspage = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuTermsOfUseText\"]");
        public void moretermspage()
        {
            driver.FindElement(termspage).Click();
        }

        By termtitle = By.XPath("//android.widget.TextView[@content-desc=\"EntryflowTitleTermsOfUse\"]");
        public string termstitlepage()
        {
            return driver.FindElement(termtitle).Text;
        }

        By termback = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void backtermspage()
        {
            driver.FindElement(termback).Click();
        }

        By privacypage = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuPrivacyPolicyText\"]");
        public void pageprivacy()
        {
            driver.FindElement(privacypage).Click();
        }

        By htmlprivacy = By.ClassName("android.webkit.WebView");
        public bool htmlprivacypage()
        {
            try
            {
                return driver.FindElement(htmlprivacy).Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        By privacytitle = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuPrivacyPolicyText\"]");
        public string pageprivacytitle()
        {
            return driver.FindElement(privacytitle).Text;
        }

        By backprivacy = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void clickbackprivacy()
        {
            driver.FindElement(backprivacy).Click();
        }

        By backlegal = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public Step11  pressbacklegal()
        {
            driver.FindElement(backlegal).Click();
            return new Step11(driver);
        }
    }
}
