using Castle.Components.DictionaryAdapter;
using Microsoft.VisualBasic;
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

        //press menu item More on bottom ribbon bar
        By more = By.XPath("//android.widget.ImageView[@content-desc=\"bottom_menu_icon_menu\"]");
        public void moreribbon()
        {
            driver.FindElement(more).Click();
        }

        //validate Auto-activate favorite locations switch is on
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

        //press Auto-activate favorite locations switch on More menu
        public void switchon()
        {
            driver.FindElement(autoactive).Click();
        }

        //validate Auto-activate favorite locations switch is off
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

        //press more menu item About
        By about = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralAboutText\"]");

        public void generalabout()
        {
            driver.FindElement(about).Click();
        }

        //validate page title is displayed on About page
        By abouttitle = By.XPath("//android.widget.TextView[@content-desc=\"AboutHeaderTitle\"]");
        public string titleonabout()
        {
           return driver.FindElement(abouttitle).Text;
        }

        //validate html view is displayed on About page
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

        //press back from About page
        By aboutback = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void backbutton()
        {
            driver.FindElement(aboutback).Click();
        }

        //press more menu item Legal information
        By legal = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalInformationText\"]");
        public void morelegalinfo()
        {
            driver.FindElement(legal).Click();
        }

        //press Legal information item MANUFACTURER
        By manufacture = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuManufacturerText\"]");
        public void moremanufacture()
        {
            driver.FindElement(manufacture).Click();
        }

        //validate page title is displayed on Manufacturer page
        By manuftitle = By.XPath("//android.widget.TextView[@content-desc=\"ManufacturerHeaderTitle\"]");
        public string manufacturetitle()
        {
            return driver.FindElement(manuftitle).Text;
        }

        //press back from Manufacturer page
        By manufback = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void manufactureback()
        {
            driver.FindElement(manufback).Click();
        }


        //press Legal information item TERMS AND CONDITIONS
        By termspage = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuTermsOfUseText\"]");
        public void moretermspage()
        {
            driver.FindElement(termspage).Click();
        }

        //validate page title is displayed on Terms and Conditions page
        By termtitle = By.XPath("//android.widget.TextView[@content-desc=\"EntryflowTitleTermsOfUse\"]");
        public string termstitlepage()
        {
            return driver.FindElement(termtitle).Text;
        }

        //press back from Terms and Conditions page
        By termback = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void backtermspage()
        {
            driver.FindElement(termback).Click();
        }

        //press Legal information item PRIVACY POLICY
        By privacypage = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuPrivacyPolicyText\"]");
        public void pageprivacy()
        {
            driver.FindElement(privacypage).Click();
        }

        //validate html view is displayed on PRIVACY POLICY page
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

        //validate page title is displayed on PRIVACY POLICY page
        By privacytitle = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuPrivacyPolicyText\"]");
        public string pageprivacytitle()
        {
            return driver.FindElement(privacytitle).Text;
        }

        //press back from PRIVACY POLICY page
        By backprivacy = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void clickbackprivacy()
        {
            driver.FindElement(backprivacy).Click();
        }

        //press back from Legal information page
        By backlegal = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public Step11  pressbacklegal()
        {
            driver.FindElement(backlegal).Click();
            return new Step11(driver);
        }
    }
}
