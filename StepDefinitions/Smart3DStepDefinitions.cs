using Microsoft.AspNetCore.Diagnostics.Views;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using Smart3D.Pages;
using TechTalk.SpecFlow.Configuration.AppConfig;

namespace Smart3D.StepDefinitions
{
    [Binding]   
    public sealed class Smart3DStepDefinitions
    {
         private AndroidDriver<AndroidElement> driver;
        Welcomepage welcomepage;
        PopupPage popupPage;
        Programpage programpage;
        Step2 step;
        Step3 step3;
        Step4 step4;
        Step5 step5;
        Step6 step6;
        Step7 step7;

       
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
            welcomepage = new Welcomepage(driver);
            welcomepage.displaytext("No, take me to demo mode");
        }

        [When(@"opens the app displays the popup button and click on the button\.")]
        public void WhenOpensTheAppDisplaysThePopupButtonAndClickOnTheButton_()
        {
            popupPage = new PopupPage(driver);
            programpage = popupPage.clickonpopup();
            
        }


        [When(@"HI program in All-Around")]
        public void WhenHIProgramInAll_Around()
        {
            programpage = new Programpage(driver);
            //programpage.nameText("All-Around");
           // Assert.AreEqual("All-Around",programpage.());

            string expectedTitle = "All-Around";
            string actualTitle = programpage.GetTitle();

            Assert.AreEqual(expectedTitle, actualTitle, "The page title does not match the expected title.");
        }

        [When(@"display the Right HI and Left HI volumes")]
        public void WhenDisplayTheRightHIAndLeftHIVolumes()
        {
            programpage = new Programpage(driver);
            programpage.clickonsplit();
        }

        [When(@"validate the Right HI and Left HI values is ""([^""]*)""")]
        public void ThenValidateTheRightHIAndLeftHIValuesIs(string p0)
        {
            /*AndroidElement seekBar1 = driver.FindElementById("dk.resound.smart3d:id/seekBar_top");
            AndroidElement seekBar2 = driver.FindElementById("dk.resound.smart3d:id/seekBar_bottom");

              int start1 = seekBar1.Location.X;
               int end1 = seekBar1.Size.Width;
               int y1 = seekBar1.Location.Y;

               int start2 = seekBar2.Location.X;
               int end2 = seekBar2.Size.Width;
               int y2 = seekBar2.Location.Y;

               TouchAction action1 = new TouchAction(driver);
               TouchAction action2 = new TouchAction(driver);

               int moveToXDirectionAt1 = (int)(686);
               int moveToXDirectionAt2 = (int)(686);

               // Seek Bar 1
               action1.LongPress(start1, y1).MoveTo(moveToXDirectionAt1, y1).Release().Perform();

               // Seek Bar 2
               action2.LongPress(start2, y2).MoveTo(moveToXDirectionAt2, y2).Release().Perform();*/

            programpage = new Programpage(driver);
            programpage.slider1(p0);
            programpage.slider2(p0);
        }

        [When(@"set surrounding volume is ""([^""]*)"" on Right HI and  ""([^""]*)"" on Left HI")]
        public void WhenSetSurroundingVolumeIsOnRightHIAndOnLeftHI(string p0, string p1)
        {
            step = new Step2(driver);
            step.slider3(p0);
            step.slider10(p1);
        }

        [When(@"validate the surrounding volume is ""([^""]*)"" on Right HI and ""([^""]*)"" on Left HI")]
        public void WhenValidateTheSurroundingVolumeIsOnRightHIAndOnLeftHI(string p0, string p1)
        {
            step = new Step2(driver);
            step.validate3(p0);
            step.validate10(p1);
        }

        [When(@"merge surroundings volume on All-Around program")]
        public void WhenMergeSurroundingsVolumeOnAll_AroundProgram()
        {
            step3 = new Step3(driver);
            step3.clickonmerge();
        }

        /*[When(@"validate HI volume is '([^']*)'")]
        public void WhenValidateHIVolumeIs(string p0)
        {
            throw new PendingStepException();
        }*/

        [When(@"validate merged surroundings volume is ""([^""]*)"" on All-Around program")]
        public void WhenValidateMergedSurroundingsVolumeIsOnAll_AroundProgram(string p0)
        {
            step3 = new Step3(driver);
            step3.validate4(p0);
        }

        [When(@"validate HI merged surrounding volume is ""([^""]*)"" on All-Around program")]
        public void WhenValidateHIMergedSurroundingVolumeIsOnAll_AroundProgram(string p0)
        {
            step3 = new Step3(driver);
            step3.validate10(p0);
        }

        [When(@"press speech clarity button on All Around program and validate speech clarity button is enabled")]
        public void WhenPressSpeechClarityButtonOnAllAroundProgramAndValidateSpeechClarityButtonIsEnabled()
        {
            step4 = new Step4(driver);
            step4.press();
           
            string expectedTitle = "Speech clarity";
            string actualTitle = step4.ValidateText();
             actualTitle = actualTitle.Replace("\r", "").Replace("\n", " ");


            Assert.AreEqual(expectedTitle, actualTitle, "validate 'Speech clarity' quick button is enabled on 'All-Around' program");
        }

        
       

        [When(@"press on Noise filter button on All Around program")]
        public void WhenPressOnNoiseFilterButtonOnAllAroundProgram()
        {
            step4 = new Step4(driver);
            step4.press1();
        }

        [When(@"validate Noise filter button is enabled and speech clarity button is disabled\.")]
        public void WhenValidateNoiseFilterButtonIsEnabledAndSpeechClarityButtonIsDisabled_()
        {
            step4 = new Step4(driver);
            step4.ValidateText1();
        }

        
        [When(@"press on speech clarity button on All Around program")]
        public void WhenPressOnSpeechClarityButtonOnAllAroundProgram()
        {
            step4 = new Step4(driver);
            step4.press();
        }

        [When(@"validate speech clarity button is enabled and Noise filter button is disabled\.")]
        public void WhenValidateSpeechClarityButtonIsEnabledAndNoiseFilterButtonIsDisabled_()
        {
            step4 = new Step4(driver);
            step4.validateText2();
        }


        [When(@"press on Sound Enhancer button on All Around program")]
        public void WhenPressOnSoundEnhancerButtonOnAllAroundProgram()
        {
            step5 = new Step5(driver);
            step5.sound();
        }

        [When(@"set Bass gain to '([^']*)' Middle gain to '([^']*)' Treble gain to '([^']*)'")]
        public void WhenSetBassGainToMiddleGainToTrebleGainTo(string p0, string p1, string p2)
        {
            step5 = new Step5(driver);
            step5.value1(p0);
            step5.value2(p1);
            step5.value3(p2);
        }


        [When(@"Then validate Bass gain to '([^']*)' Middle gain to '([^']*)' Treble gain to '([^']*)'")]
        public void WhenThenValidateBassGainToMiddleGainToTrebleGainTo(string p0, string p1, string p2)
        {
            step5 = new Step5(driver);
            step5.validatespeech1(p0);
            step5.validatespeech2(p1);
            step5.validatespeech3(p2);
        }


        [When(@"I press on Tinnitus Manager on All Around  Sound Enhancer")]
        public void WhenIPressOnTinnitusManagerOnAllAroundSoundEnhancer()
        {
            step6 = new Step6(driver);
            step6.tinnitusmanager();
        }

        [When(@"I press Nature sound button Calming Waves on All Around Tinnitus manager")]
        public void WhenIPressNatureSoundButtonCalmingWavesOnAllAroundTinnitusManager()
        {
            step6 = new Step6(driver);
            step6.calmingwaves();
        }

        [When(@"I press Nature sound button Breaking Waves on All Around Tinnitus manager")]
        public void WhenIPressNatureSoundButtonBreakingWavesOnAllAroundTinnitusManager()
        {
            step6 = new Step6(driver);
            step6.breakingwaves();
        }


        [When(@"I press the exit button on All Around Sound enhancer")]
        public void WhenIPressTheExitButtonOnAllAroundSoundEnhancer()
        {
            step6 = new Step6(driver);
            step6.Soundenhancer();
            step6.exitbutton();
        }

        [When(@"I swipe left to Hear in Noise program from current program")]
        public void WhenISwipeLeftToHearInNoiseProgramFromCurrentProgram()
        {
            step6 = new Step6(driver);
            step6.hearinnoise();
        }

        [When(@"validate program card is Hear in Noise")]
        public void WhenValidateProgramCardIsHearInNoise()
        {
            step6 = new Step6(driver);
            string expectedTitle = "Hear in noise";
            string actualTitle = step6.ValidateText();
            Assert.AreEqual(expectedTitle, actualTitle, "Then validate program card is Hear in Noise");

        }

        [When(@"I press Sound Enhancer button on Hear in noise program")]
        public void WhenIPressSoundEnhancerButtonOnHearInNoiseProgram()
        {
            step6 = new Step6(driver);
            step6.hearsoundnoise();
        }

        [When(@"I press Tinnitus Manager on Hear in noise Sound Enhancer")]
        public void WhenIPressTinnitusManagerOnHearInNoiseSoundEnhancer()
        {
            step6 = new Step6(driver);
            step6.heartinnitussound();
        }

        [When(@"I press white noise button Slight variation on Hear in noise Tinnitus Manager")]
        public void WhenIPressWhiteNoiseButtonSlightVariationOnHearInNoiseTinnitusManager()
        {
            step6 = new Step6(driver);
            step6.slightvar();
        }


        [When(@"I press Reset button on All-Around Tinnitus Manager")]
        public void WhenIPressResetButtonOnAll_AroundTinnitusManager()
        {
            step6 = new Step6(driver);
            step6.resetbutton();

        }

        [When(@"I press the exit button on Hear in noise Sound Enhancer")]
        public void WhenIPressTheExitButtonOnHearInNoiseSoundEnhancer()
        {
            step6 = new Step6(driver);
            step6.soundenh();
           
        }

        [When(@"I swipe left to Outdoor program from current program")]
        public void WhenISwipeLeftToOutdoorProgramFromCurrentProgram()
        {
            step7 = new Step7(driver);
            step7.outdoornoise();
        }

        [Then(@"validate program card is Outdoor")]
        public void ThenValidateProgramCardIsOutdoor()
        {
            step7 = new Step7(driver);
            string expectedTitle = "Outdoor";
            string actualTitle = step7.ValidateText();
            Assert.AreEqual(expectedTitle, actualTitle, "validate program card is Outdoor");
        }

        [When(@"I press Sound Enhancer button on Outdoor program")]
        public void WhenIPressSoundEnhancerButtonOnOutdoorProgram()
        {
            step7 = new Step7(driver);
            step7.outdoorsoundnoise();
        }

        [When(@"I drag Wind Noise Reduction to '([^']*)' on Outdoor Sound Enhancer")]
        public void WhenIDragWindNoiseReductionToOnOutdoorSoundEnhancer(string strong)
        {
            step7 = new Step7(driver);
            step7.windvalue(strong);
        }

        [Then(@"validate HI PNR value is Strong")]
        public void ThenValidateHIPNRValueIsStrong()
        {
            step7 = new Step7(driver);
            string expectedTitle = "Strong";
            string actualTitle = step7.StrongValidateText();
            Assert.AreEqual(expectedTitle, actualTitle, "validate HI is in Strong");
        }


    }
}