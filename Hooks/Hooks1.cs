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
    public sealed class Hooks1 :ExtentReport //inherit the extent report
    {
        private readonly IObjectContainer _container;
        public   AndroidDriver<AndroidElement> driver;

        public  Hooks1(IObjectContainer container)  //paramaterized constructor
        {
            _container = container;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Running before test run...");
            ExtentReportInit(); //calling the  ExtentReportInit method
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
                _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title); // this returns the title of the feature file
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("Running after feature...");
        }

        [BeforeScenario("@Smart3D")] //this is used for creating the test data
        public void BeforeScenarioWithTag() 
        {
            Console.WriteLine("Running inside tagged hooks in specflow");
        }

        [BeforeScenario(Order = 1)] /*order =1 parameter specifies the executed first before any other method marker with [Before scenario] attribute */
        public void FirstBeforeScenario(ScenarioContext scenarioContext)  //scenario context object provides information about the current test scenario
                                                                    
        {
            var appiumOptions = new AppiumOptions();
           
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("platformVersion", "13");
            appiumOptions.AddAdditionalCapability("deviceName", "R5CN317NG7W");
            appiumOptions.AddAdditionalCapability("automationName", "UiAutomator2");
            appiumOptions.AddAdditionalCapability("appium:appiumServerAddress", "http://127.0.0.1:4723/wd/hub");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            // appiumOptions.AddAdditionalCapability("appActivity", "crc644480832bc8628b4d.MainActivity");
            appiumOptions.AddAdditionalCapability(CapabilityType.Timeouts, TimeSpan.FromSeconds(20)); /*This line sets a timeout of 20 seconds for the driver
                                                                                                       * to wait for an element to appear on the page.*/

            appiumOptions.AddAdditionalCapability("app", "C:/Users/I-Ray/AppData/Local/Android/Sdk/platform-tools/dk.resound.smart3d-Signed.apk");
            appiumOptions.AddAdditionalCapability("androidInstallTimeout", 120000); // Increase install timeout if necessary
            appiumOptions.AddAdditionalCapability("permissions", "permission1,permission2");
            // Add more Appium options as needed

            var httpClient = new HttpClient(); // This line of code initializes a new instance of the HttpClient class
            httpClient.Timeout = TimeSpan.FromSeconds(120);
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(120)); /*this line created a new
                                               * httpcommand executor instance, specifying the URL of the Appium server a "http://localhost:4723/wd/hub" */
                                              
           
            IWebDriver driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions); //The AndroidDriver class is use to interact with an Android device using appium 
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120); /*The implicit wait instructs the driver to wait for a specified amount of time 
                                                                * when trying to find an element before throwing an exception if the element is not found.*/

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _container.RegisterInstanceAs(driver);  /* use container refernce variable for store the particular driver instance  into a container, 
                                                     * which can be later accessed by other parts of the test framework..*/

            _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title); /* this is creating a new node(test scenario) using information 
                                                        * from the 'Scenario context', which is used for reporting or tracking purposes in the test framework */
                                                                                          
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Running after step......");
           var driver = _container.Resolve<IWebDriver>(); //get the driver by using resolve method

            if(driver != null)  //if browser is open then only close
            {
                driver.Quit();      
                driver.Dispose();
            }
        }
        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running after step....");
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString(); //this returns the type of the gerhkin keyword that particular step has
            string stepName = scenarioContext.StepContext.StepInfo.Text; //this will return the step name

            var driver = _container.Resolve<IWebDriver>();

            //When scenario passed
            if (scenarioContext.TestError == null) //checking is there any test data
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
                    _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message,MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                        
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                       
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                        
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                       
                }
            }
        }

    }
}
    
