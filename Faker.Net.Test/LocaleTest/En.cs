using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Faker.Net.Test.LocaleTest
{
    [TestClass]
    public class En
    {
        [TestMethod]
        public void TestCurrencyRead()
        {
            var enType = typeof(Faker.Locales).GetNestedType("En", BindingFlags.NonPublic);
            var en = Activator.CreateInstance(enType);
            var currencyProperty = enType.GetProperty("Currency", BindingFlags.Public | BindingFlags.Instance);
            var dic = currencyProperty.GetValue(en) as dynamic;
            dynamic result = dic["UAE Dirham"];
            Assert.AreEqual("AED", result["code"]);
        }
    }
}