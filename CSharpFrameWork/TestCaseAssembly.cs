using AventStack.ExtentReports;
using CSharpFrameWork.Logs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFrameWork
{
    [TestClass]
    public class TestCaseAssembly
    {
        public static ExtentReports Extent;

        [AssemblyInitialize]
        public static void OneTimeSetup(TestContext testContext)
        {
            Extent = ExtentManager.Instance;
            LogConfig.LoadLog4NetConfig();
        }

        [AssemblyCleanup]
        public static void EndReport()
        {
            Extent.Flush();
        }
    }
}
