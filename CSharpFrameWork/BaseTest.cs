using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace CSharpFrameWork
{
    public class BaseTest
    {
        public IWebDriver Driver;  // { get; set; }

        public IWebDriver InitializeChrome()
        {
            Driver = new ChromeDriver();

            Driver.Manage().Window.Maximize();

            Driver.Navigate().GoToUrl("https://customerform.qualitytestinghub.com/");

            Driver.Manage().Cookies.DeleteAllCookies();

            return Driver;
        }

        //public WebDriverWait WaitTime(IWebDriver driver, double timeout = 30)
        //{
        //    return new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        //}
    }
}
