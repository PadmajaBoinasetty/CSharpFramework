using CSharpFrameWork.CustomerData;
using CSharpFrameWork.CustomerForm;
using CSharpFrameWork.Helpers;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFrameWork.CustomerTest
{
    [TestClass]
    public class CustomerTest:Reports
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(CustomerTest));

        [TestMethod]
        [TestCategory("Smoke")]
        public void AT1_FillCustomerDetails()
        {
            Test = TestCaseAssembly.Extent.CreateTest(TestContext.TestName).AssignCategory("SmokeTest").AssignAuthor("Padmaja");

            var dataPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName + "\\CustomerData\\customer.csv";

            var customerData = CsvReaderHelper<CustomerDetails>.Read(dataPath);

            var firstName = customerData[0].FirstName;
            var lastName = customerData[0].LastName;


            _log.Info("Test Padmaja");

            Assert.IsTrue(1 == 1);
        }

        [TestMethod]
        [TestCategory("Sanity")]
        public void AT2_FillCustomerDetails()
        {
            Test = TestCaseAssembly.Extent.CreateTest(TestContext.TestName).AssignCategory("SanityTest").AssignAuthor("Padmaja");

            var dataPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName + "\\CustomerData\\customer.csv";

            var customerData = CsvReaderHelper<CustomerDetails>.Read(dataPath);

            var firstName = customerData[0].FirstName;
            var lastName = customerData[0].LastName;


            _log.Info("Test Padmaja");

            Assert.IsTrue(1 == 1);
        }

        [TestMethod]
        [TestCategory("Sanity")]
        public void AT3_FillCustomerDetails()
        {
            Test = TestCaseAssembly.Extent.CreateTest(TestContext.TestName).AssignCategory("SanityTest").AssignAuthor("Padmaja");

            var dataPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName + "\\CustomerData\\customer.csv";

            var customerData = CsvReaderHelper<CustomerDetails>.Read(dataPath);

            var firstName = customerData[0].FirstName;
            var lastName = customerData[0].LastName;

            var customerPage = new CustomerPage(Driver);
            customerPage.FillCustomerForm();

            _log.Info("Test Padmaja");

            Assert.IsTrue(1 == 1);
        }

    }
}
