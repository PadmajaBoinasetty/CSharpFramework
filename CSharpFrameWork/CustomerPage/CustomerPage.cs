using CSharpFrameWork.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CSharpFrameWork.CustomerForm
{
    public class CustomerPage
    {
        //public WebElementHelpers webElementsHelper;// { get; set; }
        WebElementHelpers webElementsHelper = new WebElementHelpers();

        public CustomerPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='FirstName']")]
        private readonly IWebElement FirstNameElement;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='LastName']")]
        private readonly IWebElement LastNameElement;

        public void FillCustomerForm()
        {
            webElementsHelper.SendKeysInField(FirstNameElement, "Padmaja");
            webElementsHelper.SendKeysInField(LastNameElement, "Test");
        }
    }
}
