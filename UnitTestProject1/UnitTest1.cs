using GoCDTest.Controllers;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        private readonly ValuesController _valuesController;

        public UnitTest1()
        {
            _valuesController = new ValuesController();
        }

        [Test]
        public void TestMethod1()
        {
            var result = _valuesController.Get();
            Assert.IsNotNull(result, "I should not be Null");
        }

        [Test]
        public void TestMethod2()
        {
            var result = _valuesController.Get();
            Assert.IsNotNull(result, "I should not be Null");
        }
    }
}
