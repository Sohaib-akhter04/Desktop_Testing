﻿using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace WinAppDriver_001
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatorAddition_TC01()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", @"Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"),options);
            Thread.Sleep(3000);
            driver.FindElementByName("Five").Click();
            driver.FindElementByName("Plus").Click();
            driver.FindElementByName("Seven").Click();
            driver.FindElementByName("Equals").Click();

            var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text;
            Assert.AreEqual("12", calculatorResult.Replace("Display is", string.Empty).Trim());
            driver.CloseApp();
        }
        [TestMethod]
        public void CalculatorSubtraction_TC02()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", @"Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            Thread.Sleep(3000);
            driver.FindElementByName("Nine").Click();
            driver.FindElementByName("Minus").Click();
            driver.FindElementByName("Seven").Click();
            driver.FindElementByName("Equals").Click();

            var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text;
            Assert.AreEqual("2", calculatorResult.Replace("Display is", string.Empty).Trim());
            driver.CloseApp();
        }

        [TestMethod]
        public void CalculatorMultiplication_TC03()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", @"Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            Thread.Sleep(3000);
            driver.FindElementByName("Three").Click();
            driver.FindElementByName("Multiply by").Click();
            driver.FindElementByName("Four").Click();
            driver.FindElementByName("Equals").Click();

            var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text;
            Assert.AreEqual("12", calculatorResult.Replace("Display is", string.Empty).Trim());
            driver.CloseApp();
        }
    }
}
