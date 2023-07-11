using BoDi;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using Smart3D.Utility;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using OpenQA.Selenium.Remote;
using Microsoft.Extensions.Options;

namespace Smart3D.Hooks
{
    [Binding]
    public sealed class Hooks1 :ExtentReport
    {
        private readonly IObjectContainer _container;
        public   AndroidDriver<AndroidElement> driver;

        public  Hooks1(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Running before test run...");
            ExtentReportInit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Running after test run...");
            ExtentReportTearDown();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Running before feature...");
                _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("Running after feature...");
        }

        [BeforeScenario("@Smart3D")]
        public void BeforeScenarioWithTag() 
        {
            Console.WriteLine("Running inside tagged hooks in specflow");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
            var appiumOptions = new AppiumOptions();
           
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("platformVersion", "13");
            appiumOptions.AddAdditionalCapability("deviceName", "R5CN317NG7W");
            appiumOptions.AddAdditionalCapability("automationName", "UiAutomator2");
            appiumOptions.AddAdditionalCapability("appium:appiumServerAddress", "http://127.0.0.1:4723/wd/hub");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            // appiumOptions.AddAdditionalCapability("appActivity", "crc644480832bc8628b4d.MainActivity");
            appiumOptions.AddAdditionalCapability(CapabilityType.Timeouts, TimeSpan.FromSeconds(20));

            appiumOptions.AddAdditionalCapability("app", "C:/Users/I-Ray/AppData/Local/Android/Sdk/platform-tools/dk.resound.smart3d-Signed.apk");
            appiumOptions.AddAdditionalCapability("androidInstallTimeout", 120000); // Increase install timeout if necessary
            appiumOptions.AddAdditionalCapability("permissions", "permission1,permission2");
            // Add more Appium options as needed

            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(120);
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(120));
            IWebDriver driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _container.RegisterInstanceAs(driver);

            _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
           var driver = _container.Resolve<IWebDriver>();

            if(driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running after step....");
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;

            var driver = _container.Resolve<IWebDriver>();

            //When scenario passed
            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName);
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName);
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName);
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName);
                }
            }

            //When scenario fails
            if (scenarioContext.TestError != null)
            {

                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message);
                        
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message);
                       
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message);
                        
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message);
                       
                }
            }
        }

    }
}
    
