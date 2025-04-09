using System.Linq;
using Faker.Locales;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Tests
{
    [TestClass]
    public class FinanceTests
    {
        [TestMethod]
        public void GetCurrencyNameTest()
        {
            var currencyName = Finance.Default.GetCurrencyName();
            Assert.IsFalse(string.IsNullOrEmpty(currencyName));
        }
    }
}