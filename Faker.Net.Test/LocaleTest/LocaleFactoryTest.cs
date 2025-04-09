using Faker.Locales;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Net.Test.LocaleTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class LocaleFactoryTest
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestCreate()
        {
            Assert.AreEqual(typeof(En), LocaleFactory.Create(LocaleType.en).GetType());
        }
    }
}