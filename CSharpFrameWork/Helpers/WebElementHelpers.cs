using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace CSharpFrameWork.Helpers
{
    public class WebElementHelpers
    {
        public IWebDriver driver; //{ get; set; }
        public WebDriverWait wait; //{ get; set; }

        //public WebElementHelpers(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        //}

        public void WaitForElementToBeClickable(By field)
        {
            //wait.Until(ElementToBeClickable(field));
        }

        public void WaitForElementToBeVisible(By field)
        {
           // wait.Until(ElementIsVisible(field));
        }

        public void WaitForPageLoad()
        {

        }

        public void ClickOnField(By webElementPath)
        {
            WaitForElementToBeClickable(webElementPath);
            driver.FindElement(webElementPath).Click();
        }

        public void ClearField(IWebElement webElementPath)
        {
            webElementPath.Clear();
        }

        public void SendKeysInField(IWebElement webElementPath, string fieldValue)
        {
            webElementPath.SendKeys(fieldValue);
        }

        public string GetText(IWebElement webElementPath)
        {
            return webElementPath.Text;
        }

        public bool IsEnabled(IWebElement webElementPath)
        {
            return webElementPath.Enabled;
        }

        public bool IsSelected(IWebElement webElementPath)
        {
            return webElementPath.Selected;
        }

        public List<string> GetWindowHandles()
        {
            return driver.WindowHandles.ToList();
        }

        public IWebDriver SwitchWindows(string windowId)
        {
            return driver.SwitchTo().Window(windowId);
        }

        public IWebDriver SwitchFrames(IWebElement framePath)
        {
            return driver.SwitchTo().Frame(framePath);
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public void SelectByValue(IWebElement webElement, string valueToBeSelected)
        {
            var selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(valueToBeSelected);
        }

        public void SelectByText(IWebElement webElement, string valueToBeSelected)
        {
            var selectElement = new SelectElement(webElement);
            selectElement.SelectByText(valueToBeSelected);
        }
    }
}
