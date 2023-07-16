using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumClientDemo
{
    public class Tests
    {

        private AppiumDriver<AndroidElement> _driver;

        [SetUp]
        public void Setup()
        {
            var appPath = @"C:\Users\******\APK's\nimbl Pocket Money App & Card_1.5.37_apkcombo.com.apk";

            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability("platformName", "Android");
            driverOption.AddAdditionalCapability("appium:deviceName", "Pixel 4 API 31 Android 12 INTEL");
            driverOption.AddAdditionalCapability("appium:app", @"C:\Users\******\APK's\Deco UI - Ionic 6 App Template_3.4.8_apkcombo.com.apk");
            driverOption.AddAdditionalCapability("appium:automationName", "UiAutomator2");

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/"), driverOption);

            var openTabMenu = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.view.View/android.view.View[2]/android.view.View[1]/android.view.View/android.widget.Button");            
            openTabMenu.Click();
            var signUpTabButton = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[2]/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View");
            signUpTabButton.Click();
            var loginOption = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View[1]/android.view.View/android.widget.Button");
            loginOption.Click();
            var emailAddressField = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[1]/android.view.View[1]/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.EditText");
            emailAddressField.SendKeys("hello.world@gmail.com");
            var emailaddressFieldValue2 = emailAddressField.Text.ToString();
            var passWordField = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[1]/android.view.View[2]/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.EditText");
            passWordField.SendKeys("12334554657667");
            var loginField = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[1]/android.view.View[2]/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.EditText");
            loginField.Click();

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}