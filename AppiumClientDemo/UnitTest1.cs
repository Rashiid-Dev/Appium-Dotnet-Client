using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System.IO;

namespace AppiumClientDemo
{
    public class Tests
    {

        private AppiumDriver<AndroidElement> _driver;
        private string _username;

        [SetUp]
        public void Setup()
        {
            var directory = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(directory, @"..\..\..\"));
            try
            {
                using (var sr = new StreamReader($@"{newPath}\Username.txt"))
                {
                    _username = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Username.txt is not present, create your own file with only your windows username in it");
                Console.WriteLine(e.Message);
            }

            var appPath = $@"C:\Users\{_username}\APK's\Deco UI - Ionic 6 App Template_3.4.8_apkcombo.com.apk";

            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability("platformName", "Android");
            driverOption.AddAdditionalCapability("appium:deviceName", "Pixel 4 API 31 Android 12 INTEL");
            driverOption.AddAdditionalCapability("appium:app", appPath);
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