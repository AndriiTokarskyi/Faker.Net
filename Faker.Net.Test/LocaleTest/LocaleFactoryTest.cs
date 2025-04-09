using Faker.Locales;
using NUnit.Framework;

namespace Faker.Net.Test.LocaleTest
{
    [TestFixture]
    public class LocaleFactoryTest
    {
        [Test]
        public void TestCreate()
        {
            Assert.AreEqual(typeof(En), LocaleFactory.Create(LocaleType.en).GetType());
        }
    }
}