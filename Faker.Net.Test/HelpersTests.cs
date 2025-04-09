using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest.TestFramework;

namespace Faker.Tests
{
    [TestClass]
    public class HelpersTests
    {
        [TestMethod]
        public void GetAvailableLocaleTypesTest()
        {
            var result = Helpers.GetAvailableLocaleTypes();
            Assert.IsTrue(result.Length > 1);
        }
    }
}