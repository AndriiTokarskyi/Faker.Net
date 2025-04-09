using Faker.Locales;
using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Net.Test.LocaleTest
{
    [TestClass]
    public class LocaleFactoryTest
    {
        [TestMethod]
        public void TestCreate()
        {
            Type localeFactoryType = typeof(En).Assembly.GetType("Faker.LocaleFactory");
            MethodInfo createMethod = localeFactoryType.GetMethod("Create", BindingFlags.Public | BindingFlags.Static);
            object result = createMethod.Invoke(null, new object[] { LocaleType.en });
            Assert.AreEqual(typeof(En), result.GetType());
        }
    }
}