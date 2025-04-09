using Faker.Locales;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Net.Test.LocaleTest
{
    [MSTest.TestClass]
    public class LocaleFactoryTest
    {
        [MSTest.TestMethod]
        public void TestCreate()
        {
            Assert.AreEqual(typeof(En), LocaleFactory.Create(LocaleType.en).GetType());
        }
    }
}