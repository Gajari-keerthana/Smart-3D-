using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Smart3D.StepDefinitions
{
    [Binding]
    public sealed class Smart3DStepDefinitions
    {
        AndroidDriver<AndroidElement> driver;

        public Smart3DStepDefinitions(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        [Given(@"open the app\.")]
        public void GivenOpenTheApp()
        {
           // var appiumOptions = new AppiumOptions();
            //appiumOptions.AddAdditionalCapability("platformName", "Galaxy S22+");
            //appiumOptions.AddAdditionalCapability("platformVersion", "13");
            //appiumOptions.AddAdditionalCapability("deviceName", "R3CT302GE0F");
            //appiumOptions.AddAdditionalCapability("automationName", "UiAutomator2");
            //appiumOptions.AddAdditionalCapability("appium:appiumServerAddress", "http://127.0.0.1:4723/wd/hub");
            //appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            // appiumOptions.AddAdditionalCapability("appActivity", "crc644480832bc8628b4d.MainActivity");

            //appiumOptions.AddAdditionalCapability("app", "C:/Users/I-Ray/AppData/Local/Android/Sdk/platform-tools/dk.resound.smart3d-Signed.apk");
            //appiumOptions.AddAdditionalCapability("androidInstallTimeout", 120000); // Increase install timeout if necessary
            //appiumOptions.AddAdditionalCapability("permissions", "permission1,permission2");
            // Add more Appium options as needed


            //driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appiumOptions);
            //Thread.Sleep(10000);
        }

        [When(@"click on the take me to demo app")]
        public void WhenClickOnTheTakeMeToDemoApp()
        {
            AndroidElement button = driver.FindElementById("dk.resound.smart3d:id/demo_button");
            button.Click();
        }

        [When(@"opens the app displays the popup button and click on the button\.")]
        public void WhenOpensTheAppDisplaysThePopupButtonAndClickOnTheButton_()
        {
            AndroidElement button1 = driver.FindElementByClassName("android.view.ViewGroup");
            button1.Click();
        }

        [Then(@"again opens the another popup button and then click on the button\.")]
        public void ThenAgainOpensTheAnotherPopupButtonAndThenClickOnTheButton_()
        {
            Thread.Sleep(10000);
            AndroidElement button2 = driver.FindElementByClassName("android.view.ViewGroup");
            button2.Click();
        }

    }
}