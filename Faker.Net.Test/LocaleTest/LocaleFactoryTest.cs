using Faker.Locales;
using System;
using System.Reflection;

namespace Faker.Net.Test.LocaleTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class LocaleFactoryTest
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestCreate()
        {
            Type localeFactoryType = typeof(En).Assembly.GetType("Faker.LocaleFactory");
            MethodInfo createMethod = localeFactoryType.GetMethod("Create", BindingFlags.Public | BindingFlags.Static);
            object result = createMethod.Invoke(null, new object[] { LocaleType.en });
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(typeof(En), result.GetType());
        }
    }
}