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
            Assert.That(LocaleFactory.Create(LocaleType.en).GetType(), Is.EqualTo(typeof(En)));
        }
    }
}