using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Reflection;

namespace Faker.Net.Test.LocaleTest
{
    [TestClass]
    public class En
    {
        [TestMethod]
        public void TestCurrencyRead()
        {
            var fakerAssembly = typeof(Faker.Name).Assembly;
            var enType = fakerAssembly.GetType("Faker.Locales.En");
            var en = Activator.CreateInstance(enType);
            var currencyProperty = enType.GetProperty("Currency");
            var dic = currencyProperty.GetValue(en) as dynamic;
            dynamic result = dic["UAE Dirham"];
            Assert.AreEqual("AED", result["code"]);
        }
    }
}