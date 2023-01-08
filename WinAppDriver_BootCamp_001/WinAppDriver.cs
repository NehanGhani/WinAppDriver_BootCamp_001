using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Threading;
using System.Timers;
using OpenQA.Selenium;
using System.Runtime.InteropServices;

namespace WinAppDriver_BootCamp_001
{
    [TestClass]
    public class WinAppDriver
    {
        /* [TestMethod(), TestCategory("Calculator task1")]
         public void WinApp_ValidateCalculatorAddition_TC01()
         {
             System.Diagnostics.Process.Start
                  (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

             AppiumOptions options = new AppiumOptions();
             options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
             options.AddAdditionalCapability("deviceName", "WindowsPC");
             using (var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options))

             {
                 driver.FindElementByName("OpenNavigation").Click();
                 driver.FindElementByName("Settings").Click();
                 Assert.AreEqual("Calculator 11.2210.0.0\r\n© 2022 Microsoft. All rights reserved.)", driver.FindElementByAccessibilityId("AboutContentBody").Text);

                 driver.CloseApp();
             }*/

        //******* new way

        //[TestMethod(), TestCategory("Calculator task4")]
        //public void WinApp_ValidateCalculatorAddition_TC04()
        //{

        //    System.Diagnostics.Process.Start
        //         (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

        //    AppiumOptions options = new AppiumOptions();
        //    options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    options.AddAdditionalCapability("deviceName", "WindowsPC");
        //    var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

        //    driver.FindElementByName("Open Navigation").Click();
        //    driver.FindElementByName("Settings").Click();
        //    var t = driver.FindElementByAccessibilityId("AboutContentBody").Text;
        //    //        Assert.AreEqual("525", calculatorResult);
        //    Assert.AreEqual("Calculator 11.2210.0.0 \r\n© 2022 Microsoft. All rights reserved.", t);

        //   driver.CloseApp();




        //}


        //[TestMethod(), TestCategory("Calculator task2")]

        //public void WinApp_ValidateCalculatorAddition_TC02()
        //{
        //    System.Diagnostics.Process.Start
        //         (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

        //    AppiumOptions options = new AppiumOptions();
        //    options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    options.AddAdditionalCapability("deviceName", "WindowsPC");
        //    using (var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options))
        //    {
        //        driver.FindElementByName("Five").Click();
        //        driver.FindElementByName("Plus").Click();
        //        driver.FindElementByName("One").Click();
        //        driver.FindElementByName("Zero").Click();
        //        driver.FindElementByName("Zero").Click();
        //        driver.FindElementByName("Equals").Click();
        //        driver.FindElementByName("Divide by").Click();
        //        driver.FindElementByName("Two").Click();
        //        driver.FindElementByName("Equals").Click();
        //        driver.FindElementByName("Multiply by").Click();
        //        driver.FindElementByName("One").Click();
        //        driver.FindElementByName("Zero").Click();
        //        driver.FindElementByName("Equals").Click();


        //        var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
        //        Assert.AreEqual("525", calculatorResult);




        //        driver.CloseApp();
        //    }
        //}

        //[TestMethod(), TestCategory("Calculator task3")]
        //public void WinApp_ValidateCalculatorAddition_TC03()
        //{
        //    System.Diagnostics.Process.Start
        //         (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

        //    AppiumOptions options = new AppiumOptions();
        //    options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    options.AddAdditionalCapability("deviceName", "WindowsPC");
        //    using (var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options))

        //    {
        //        driver.FindElementByName("One").Click();
        //        driver.FindElementByName("Four").Click();
        //        driver.FindElementByName("Four").Click();
        //        driver.FindElementByName("Square root").Click();
        //        driver.FindElementByName("Equals").Click();

        //        var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
        //        Assert.AreEqual("12", calculatorResult);

        //        driver.CloseApp();


        //    }
        //}
        //cos50
        [TestMethod(), TestCategory("Calculator task4")]
        public void WinApp_ValidateCalculatorAddition_TC04()
        {

            System.Diagnostics.Process.Start
                 (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

            driver.FindElementByName("Open Navigation").Click();
            Thread.Sleep(2000);
            driver.FindElementByName("Scientific Calculator").Click();
            driver.FindElementByName("Five").Click();
            driver.FindElementByName("Zero").Click();
            Thread.Sleep(2000);
            driver.FindElementByAccessibilityId("trigButton").Click();
            //driver.FindElementByName("Trigonometry").Click();
            Thread.Sleep(2000);
            driver.FindElementByName("Cosine").Click();
            var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
            Assert.AreEqual("0.64278760968653932632264340990726", calculatorResult);

            driver.CloseApp();
        }




        //BODMAS (2+7) * 3+9
        //[TestMethod(), TestCategory("Calculator task5")]
        //public void WinApp_ValidateCalculatorAddition_TC05()
        //{
        //    System.Diagnostics.Process.Start
        //         (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

        //    AppiumOptions options = new AppiumOptions();
        //    options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    options.AddAdditionalCapability("deviceName", "WindowsPC");
        //    using (var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options))

        //    {
        //    
        //        driver.FindElementByName("Left parenthesis").Click();
        //        driver.FindElementByName("Two").Click();
        //        driver.FindElementByName("Plus").Click();
        //        driver.FindElementByName("Seven").Click();
        //        driver.FindElementByName("Right parenthesis").Click();
        //        driver.FindElementByName("Equals").Click();
        //        driver.FindElementByName("Multiply by").Click();
        //        driver.FindElementByName("Three").Click();
        //        driver.FindElementByName("Plus").Click();
        //        driver.FindElementByName("Nine").Click();
        //        driver.FindElementByName("Equals").Click();


        //        var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
        //        Assert.AreEqual("36", calculatorResult);

        //        driver.CloseApp();
        //    }
        //}

        //2 sin 2theta = 1
        //[TestMethod(), TestCategory("Calculator task6")]
        //public void WinApp_ValidateCalculatorAddition_TC06()
        //{
        //    System.Diagnostics.Process.Start
        //         (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

        //    AppiumOptions options = new AppiumOptions();
        //    options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    options.AddAdditionalCapability("deviceName", "WindowsPC");
        //    var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

        //    {
        //        driver.FindElementByName("Two").Click();
                  driver.FindElementByName("One").Click();

        //        var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
        //        Assert.AreEqual("12", calculatorResult);

        //        driver.CloseApp();

        //    }
        //}
        ////3 sec 2theta =2 root 3
        //[TestMethod(), TestCategory("Calculator task7")]
        //public void WinApp_ValidateCalculatorAddition_TC07()
        //{
        //    System.Diagnostics.Process.Start
        //         (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

        //    AppiumOptions options = new AppiumOptions();
        //    options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    options.AddAdditionalCapability("deviceName", "WindowsPC");
        //    var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

        //    {
        //        driver.FindElementByName("One").Click();

        //        var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
        //        Assert.AreEqual("12", calculatorResult);

        //        driver.CloseApp();

        //    }
        //}

        ////4 cot 3 theta -4 = 0
        //[TestMethod(), TestCategory("Calculator task8")]
        //public void WinApp_ValidateCalculatorAddition_TC08()
        //{
        //    System.Diagnostics.Process.Start
        //         (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

        //    AppiumOptions options = new AppiumOptions();
        //    options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    options.AddAdditionalCapability("deviceName", "WindowsPC");
        //    var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

        //    {
        //        driver.FindElementByName("One").Click();
        //        var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
        //        Assert.AreEqual("12", calculatorResult);

        //        driver.CloseApp();

        //    }
        //}

        //[TestMethod(), TestCategory("Notepad")]
        //public void WinApp_ValidateNotePad_TC01()
        //{
        //    System.Diagnostics.Process.Start
        //         (@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

        //    AppiumOptions options = new AppiumOptions();
        //    options.AddAdditionalCapability("app", @"C:\Windows\notepad.exe");
        //    options.AddAdditionalCapability("deviceName", "WindowsPC");
        //    var driver = new WindowsDriver<WindowsElement>
        //        (new Uri("http://127.0.0.1:4723"), options);

        //    driver.FindElementByName("Help").Click();
        //    driver.FindElementByName("About Notepad").Click();
        //    Assert.AreEqual("Version 21H2 (OS Build 19044.2251)", driver.FindElementByAccessibilityId("13579").Text);
        //    driver.FindElementByName("OK").Click();

        //    driver.FindElementByClassName("Edit").SendKeys(DateTime.Now.ToString());
        //    driver.FindElementByClassName("Edit").Clear();

        //    driver.FindElementByName("Edit").Click();
        //    driver.FindElementByAccessibilityId("26").Click();
        //    Assert.IsNotNull(driver.FindElementByClassName("Edit"));
        //    driver.FindElementByClassName("Edit").Clear();

        //    string data = DateTime.Now.ToString() + " Amir Imam";

        //    driver.FindElementByClassName("Edit").SendKeys(data);
        //    driver.FindElementByName("File").Click();
        //    driver.FindElementByAccessibilityId("3").Click();
        //    Thread.Sleep(1000);

        //    driver.FindElementByAccessibilityId("FileNameControlHost").SendKeys("C:\\" + DateTime.Now.ToString("yyyymmdd hmmtt") + "_AmirImam.txt");
        //    driver.FindElementByAccessibilityId("1").Click();

        //    Thread.Sleep(1000);
        //    driver.CloseApp();
        //}
    }
}



