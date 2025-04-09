using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Net.Test.LocaleTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class En
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestCurrencyRead()
        {
            Locales.En en = new Locales.En();
            var dic = en.Currency;
            dynamic result = dic["UAE Dirham"];
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("AED", result["code"]);
        }
    }
}