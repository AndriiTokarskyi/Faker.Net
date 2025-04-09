using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Faker.Net.Test.LocaleTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class En
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
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