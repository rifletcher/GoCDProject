using GoCDTest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ValuesController _valuesController;

        public UnitTest1()
        {
            _valuesController = new ValuesController();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = _valuesController.Get();
            Assert.IsNotNull(result);
        }
    }
}
