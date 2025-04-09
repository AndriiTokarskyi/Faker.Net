using System.Linq;
using Faker.Locales;
using NUnit.Framework;

namespace Faker.Tests
{
    [TestFixture]
    public class FinanceTests
    {
        [Test]
        public void GetCurrencyNameTest()
        {
            var currencyName = Finance.Default.GetCurrencyName();
            Assert.IsFalse(string.IsNullOrEmpty(currencyName));
        }
    }
}