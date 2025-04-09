using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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