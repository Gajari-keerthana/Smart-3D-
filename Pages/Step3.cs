using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Smart3D.Pages
{
    public class Step3
    {
        private AndroidDriver<AndroidElement> driver;
        public Step3(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        
        By merge = By.XPath("//android.widget.ImageView[@content-desc=\"icon_split1_s\"]");
        By seekbar4 = By.Id("dk.resound.smart3d:id/volume_thumb_innercircle");
        By seekbar13 = By.Id("dk.resound.smart3d:id/volume_thumb_innercircle");

       // it merge surroundings volume on All-Around program
        public void clickonmerge()
        {
            driver.FindElement(merge).Click();
            
        }

        /* public void clickonmerge2()
         {
             driver.FindElement(merge1).Click();
             Actions actions = new Actions(driver);
             TouchActions actions1 = new TouchActions(driver);
             AndroidElement display2 = driver.FindElement(merge1);
             actions.ClickAndHold(display2).Perform();
         } */


        //validating merged surroundings volume is "3" on All-Around program
        public void validate4(string value)
        {
            
            Actions actions = new Actions(driver);
            AndroidElement display = driver.FindElement(seekbar4);
            actions.ClickAndHold(display).Perform();
            actions.MoveByOffset(1, 0).Perform();
            string act_value2 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(act_value2, value);
            actions.Release().Perform();
            //Assert.IsNotNull(merge, "The merge button click action did not lead to the expected behavior.");
        }


        //validate HI merged surrounding volume is "13" on All-Around program
        public Step4 validate5(string value)
        {
            Actions actions = new Actions(driver);
            AndroidElement display = driver.FindElement(seekbar13);
            actions.ClickAndHold(display).Perform();
            actions.MoveByOffset(570, 0).Perform();
            string act_value3 = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(act_value3, value);
            actions.Release().Perform();
            return new Step4(driver);
        }
        
    }
}
